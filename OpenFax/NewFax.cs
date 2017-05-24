using Newtonsoft.Json;
using OpenFax.Classes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace OpenFax
{
    public class NewFax
    {
        #region Fax
        public List<APIFax> GetNewFax(APIFaxParam param)
        {
            try
            {
                int limit = 1000;
                int.TryParse(ConfigurationManager.AppSettings[Constants.NEWFAX_APPCONFIG_FAXLIMIT].ToString(), out limit);
                string url = Constants.NEWFAX_APIURL + "?" + Constants.NEWFAX_QUERYPARAM_ACCOUNTID + "=" + param.AccountID + "&" + Constants.NEWFAX_QUERYPARAM_APIKEY + "=" + param.APIKey + "&" + Constants.NEWFAX_QUERYPARAM_FAXTYPE + "=" + param.FaxType + "&" + Constants.NEWFAX_QUERYPARAM_LIMIT + limit.ToString();
                if (!string.IsNullOrEmpty(param.DID))
                {
                    url = url + "&" + Constants.NEWFAX_QUERYPARAM_DID + "=" + param.DID;
                }

                using (WebClient client = new WebClient())
                {
                    string s = client.DownloadString(url);
                    var model = JsonConvert.DeserializeObject<List<APIFax>>(s);
                    return model;
                }
            }
            catch (Exception ex)
            {
                Logger.Log("API - Error occured while getting new faxes from API" + ex.Message);
            }
            return new List<APIFax>();
        }

        public void ProcessFax()
        {
            var accountinfo = Functions.LoadAccountFromXml();
            APIFaxParam param = new APIFaxParam() { AccountID = accountinfo.AccountNumber, APIKey = accountinfo.ApiKey, DID = "", FaxType = accountinfo.ImageType };

            XmlSerializer serializer = new XmlSerializer(typeof(DIDConfigureList));
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
            using (TextReader reader = new StringReader(xml.InnerXml))
            {
                var result = (DIDConfigureList)serializer.Deserialize(reader);
                foreach (var config in result.Configurations)
                {
                    if (!string.IsNullOrEmpty(config.Poll) && config.Poll.ToLower() == "true")
                    {
                        param.DID = config.Did;
                        param.FaxType = config.Type;

                        //get new fax information from api
                        var newfaxes = GetNewFax(param);

                        //save new faxes to local folder
                        foreach (var fax in newfaxes)
                        {
                            if (fax.Response != Constants.NEWFAX_NOFAXRECEIVED)
                            {
                                //check for default config
                                if (!string.IsNullOrEmpty(config.IsDefault) && config.IsDefault.ToLower() == "true")
                                {
                                    config.Prefix = accountinfo.Prefix;
                                    config.Suffix = accountinfo.Suffix;
                                    config.FilePath = accountinfo.ImageSavePath;
                                    config.Type = accountinfo.ImageType;
                                }

                                string filepath = DownloadFile(config, fax);
                                //send status through service call
                                //string status = !string.IsNullOrEmpty(filepath) ? "success" : "fail";
                                //SendToService(status, fax.InTransID);

                                if (IsFileAlreadyDownloaded(fax.InTransID))
                                    UpdateFaxToLog(config, fax, filepath);
                                else
                                    WriteFaxToLog(config, fax, filepath);
                            }
                        }
                    }
                }
            }
        }

        public void RedownloadFaxes(string transid)
        {
            try
            {
                var accountinfo = Functions.LoadAccountFromXml();
                string url = Constants.FAX_READUNREAD_APIURL + "?" + Constants.NEWFAX_QUERYPARAM_ACCOUNTID + "=" + accountinfo.AccountNumber + "&" + Constants.NEWFAX_QUERYPARAM_APIKEY + "=" + accountinfo.ApiKey + "&" + Constants.FAX_READUNREAD_QUERYPARAM_FROMTRANSID + "=" + transid + "&" + Constants.FAX_READUNREAD_QUERYPARAM_TOTRANSID + "=" + transid + "&" + Constants.FAX_READUNREAD_QUERYPARAM_READUNREADFLAG + "=0";
                using (WebClient client = new WebClient())
                {
                    string s = client.DownloadString(url);
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error occured for redownload faxes" + ex.Message);
            }
        }

        private static void WriteFaxToLog(DIDConfigurationXml config, APIFax fax, string filepath)
        {
            XmlDocument xmlcr = new XmlDocument();
            xmlcr.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
            XmlNode ParentElement = xmlcr.SelectSingleNode("logs");

            XmlElement parent = xmlcr.CreateElement("log");
            parent.SetAttribute("id", fax.InTransID);

            XmlElement intransID = xmlcr.CreateElement("intransid");
            intransID.InnerText = fax.InTransID;

            XmlElement received = xmlcr.CreateElement("received");
            received.InnerText = fax.ReceivedTime;

            XmlElement did = xmlcr.CreateElement("did");
            did.InnerText = config.Did;

            XmlElement receivedfrom = xmlcr.CreateElement("receivedfrom");
            receivedfrom.InnerText = fax.SenderCallerName;

            XmlElement pages = xmlcr.CreateElement("pages");
            pages.InnerText = fax.Pages;

            XmlElement filePath = xmlcr.CreateElement("faximagefile");
            filePath.InnerText = filepath;

            XmlElement status = xmlcr.CreateElement("status");
            status.InnerText = !string.IsNullOrEmpty(filepath) ? "success" : "fail";

            XmlElement redownload = xmlcr.CreateElement("redownload");
            redownload.InnerText = "false";

            XmlElement faxDocPDFURL = xmlcr.CreateElement("FaxDocPDFURL");
            faxDocPDFURL.InnerText = fax.FaxDocPDFURL;

            XmlElement faxDocTiffURL = xmlcr.CreateElement("FaxDocTiffURL");
            faxDocTiffURL.InnerText = fax.FaxDocTiffURL;

            XmlElement faxDocJpegURL = xmlcr.CreateElement("FaxDocJpegURL");
            faxDocJpegURL.InnerText = fax.FaxDocTiffURL;

            parent.AppendChild(intransID);
            parent.AppendChild(received);
            parent.AppendChild(did);
            parent.AppendChild(receivedfrom);
            parent.AppendChild(pages);
            parent.AppendChild(filePath);
            parent.AppendChild(status);
            parent.AppendChild(redownload);
            parent.AppendChild(faxDocPDFURL);
            parent.AppendChild(faxDocTiffURL);
            parent.AppendChild(faxDocJpegURL);
            ParentElement.AppendChild(parent);

            xmlcr.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
        }

        private static void UpdateFaxToLog(DIDConfigurationXml config, APIFax fax, string filepath)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
            XmlNodeList xnList = xml.SelectNodes("/logs/log[@id=" + fax.InTransID + "]");
            foreach (XmlNode xn in xnList)
            {
                if (xn.HasChildNodes)
                {
                    foreach (XmlNode item in xn.ChildNodes)
                    {
                        switch (item.Name)
                        {
                            case "received":
                                item.InnerText = fax.ReceivedTime;
                                break;
                            case "did":
                                item.InnerText = config.Did;
                                break;
                            case "receivedfrom":
                                item.InnerText = fax.SenderCallerName;
                                break;
                            case "pages":
                                item.InnerText = fax.Pages;
                                break;
                            case "faximagefile":
                                item.InnerText = filepath;
                                break;
                            case "status":
                                item.InnerText = !string.IsNullOrEmpty(filepath) ? "success" : "fail";
                                break;
                        }
                    }
                }
            }
            xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
        }

        private static bool IsFileAlreadyDownloaded(string logid)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
            XmlNodeList xnList = xml.SelectNodes("/logs/log[@id=" + logid + "]");
            foreach (XmlNode xn in xnList)
            {
                return xn.HasChildNodes;
            }

            return false;
        }

        private static string DownloadFile(DIDConfigurationXml config, APIFax fax)
        {
            string filepath = string.Empty;
            try
            {
                using (var client = new WebClient())
                {
                    switch (config.Type)
                    {
                        case Constants.ACCOUNT_IMAGETYPE_PDF:
                            if (fax.PDFFileName.Contains(".pdf"))
                            {
                                fax.PDFFileName = fax.PDFFileName.Replace(".pdf", "");
                            }
                            filepath = config.FilePath + "\\" + config.Prefix + fax.PDFFileName + config.Suffix + ".pdf";
                            client.DownloadFile(fax.FaxDocPDFURL, filepath);
                            break;
                        case Constants.ACCOUNT_IMAGETYPE_TIFF:
                            if (fax.PDFFileName.Contains(".pdf"))
                            {
                                fax.PDFFileName = fax.PDFFileName.Replace(".pdf", "");
                            }
                            else if (fax.PDFFileName.Contains(".tif"))
                            {
                                fax.PDFFileName = fax.PDFFileName.Replace(".tif", "");
                            }
                            filepath = config.FilePath + "\\" + config.Prefix + fax.PDFFileName + config.Suffix + ".tif";
                            client.DownloadFile(fax.FaxDocTiffURL, filepath);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error occured while downloading file - " + fax.PDFFileName + " - " + ex.Message);
            }
            return filepath;
        }
        #endregion

        #region DID
        public void ProcessDIDs()
        {
            var accountinfo = Functions.LoadAccountFromXml();
            if (!string.IsNullOrEmpty(accountinfo.AccountNumber) && !string.IsNullOrEmpty(accountinfo.ApiKey))
            {
                var dids = Functions.GetDIDs(new APIFaxParam() { AccountID = accountinfo.AccountNumber, APIKey = accountinfo.ApiKey });
                foreach (var did in dids)
                {
                    if (did.Response != "InvalidMissingValue")
                    {
                        // DID prefix
                        int preDid = 0;
                        int.TryParse(ConfigurationManager.AppSettings[Constants.NEWFAX_APPCONFIG_DIDPREFIX], out preDid);
                        if (preDid != 0)
                        {
                            did.DID = preDid + did.DID;
                        }

                        //check for XML file
                        var isFileExists = File.Exists(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
                        if (!isFileExists)
                        {
                            //it will create new xml file with "didconfigurations" node
                            new XDocument(new XElement("didconfigurations")).Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
                        }

                        //check if did is already exists
                        var didExist = IsDIDExist(did);

                        //its not exits then create new entry to xml
                        if (!didExist)
                        {
                            WriteDIDConfigToXml(did, accountinfo);
                        }
                    }
                }

                //remove deleted record from XML
                XmlDocument xmlcr = new XmlDocument();
                xmlcr.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
                foreach (XmlNode node in xmlcr.SelectNodes("/didconfigurations/did"))
                {
                    if (dids.FirstOrDefault(d => d.DID == node.Attributes["id"].Value) == null)
                    {
                        node.ParentNode.RemoveChild(node);
                    }
                }
                xmlcr.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
                //XmlElement el = (XmlElement)xmlcr.SelectSingleNode("/company/employee[id=2]");
                //if (el != null) { el.ParentNode.RemoveChild(el); }
            }
        }

        private static void WriteDIDConfigToXml(APIDid did, AccountXml accountInfo)
        {
            XmlDocument xmlcr = new XmlDocument();
            xmlcr.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
            XmlNode ParentElement = xmlcr.SelectSingleNode("didconfigurations"); //CreateElement("Employee");

            XmlElement parent = xmlcr.CreateElement("did");
            parent.SetAttribute("id", did.DID);

            XmlElement isDefault = xmlcr.CreateElement("isdefault");
            isDefault.InnerText = "true";

            XmlElement poll = xmlcr.CreateElement("poll");
            poll.InnerText = "false";

            XmlElement xdid = xmlcr.CreateElement("did");
            xdid.InnerText = did.DID;

            XmlElement name = xmlcr.CreateElement("name");
            name.InnerText = did.CustomerDescription != null ? did.CustomerDescription.ToString() : string.Empty;

            XmlElement type = xmlcr.CreateElement("type");
            type.InnerText = accountInfo.ImageType;// did.DIDType == "0" ? "PDF" : "TIF";

            XmlElement filePath = xmlcr.CreateElement("filepath");
            filePath.InnerText = accountInfo.ImageSavePath;

            XmlElement prefix = xmlcr.CreateElement("prefix");
            prefix.InnerText = accountInfo.Prefix;

            XmlElement suffix = xmlcr.CreateElement("suffix");
            suffix.InnerText = accountInfo.Suffix;

            XmlElement xd = xmlcr.CreateElement("d");
            xd.InnerText = "true";

            XmlElement xe = xmlcr.CreateElement("e");
            xe.InnerText = !string.IsNullOrEmpty(did.EmailNotification) && did.EmailNotification == "1" ? "true" : "false";

            XmlElement xp = xmlcr.CreateElement("p");
            xp.InnerText = !string.IsNullOrEmpty(did.PostBack) && did.PostBack == "1" ? "true" : "false";

            XmlElement xs = xmlcr.CreateElement("s");
            xs.InnerText = !string.IsNullOrEmpty(did.PostToS3) && did.PostToS3 == "1" ? "true" : "false";

            XmlElement isprefix = xmlcr.CreateElement("isprefix");
            isprefix.InnerText = accountInfo.IsPrefix;

            XmlElement issuffix = xmlcr.CreateElement("issuffix");
            issuffix.InnerText = accountInfo.IsSuffix;

            parent.AppendChild(isDefault);
            parent.AppendChild(poll);
            parent.AppendChild(xdid);
            parent.AppendChild(name);
            parent.AppendChild(type);
            parent.AppendChild(filePath);
            parent.AppendChild(prefix);
            parent.AppendChild(suffix);
            parent.AppendChild(xd);
            parent.AppendChild(xe);
            parent.AppendChild(xp);
            parent.AppendChild(xs);
            parent.AppendChild(isprefix);
            parent.AppendChild(issuffix);
            ParentElement.AppendChild(parent);

            xmlcr.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
        }

        private static bool IsDIDExist(APIDid did)
        {
            bool isExist = false;
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
            XmlNodeList xnList = xml.SelectNodes("/didconfigurations/did[@id=" + did.DID + "]");
            foreach (XmlNode xn in xnList)
            {
                isExist = xn.HasChildNodes;
                foreach (XmlNode item in xn.ChildNodes)
                {
                    switch (item.Name)
                    {
                        case "name":
                            item.InnerText = did.CustomerDescription != null ? did.CustomerDescription.ToString() : string.Empty;
                            break;
                        case "e":
                            item.InnerText = !string.IsNullOrEmpty(did.EmailNotification) && did.EmailNotification == "1" ? "true" : "false";
                            break;
                        case "p":
                            item.InnerText = !string.IsNullOrEmpty(did.PostBack) && did.PostBack == "1" ? "true" : "false";
                            break;
                        case "s":
                            item.InnerText = !string.IsNullOrEmpty(did.PostToS3) && did.PostToS3 == "1" ? "true" : "false";
                            break;
                    }
                }
            }
            xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);

            return isExist;
        }
        #endregion

        #region Service
        private void SendToService(string status, string id)
        {
            ChannelFactory<IStatusService> pipeFactory = new ChannelFactory<IStatusService>(new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport), new EndpointAddress("net.pipe://localhost/sendstatus"));

            IStatusService pipeProxy = pipeFactory.CreateChannel();

            var output = pipeProxy.SendStatus(status, id);
        }
        #endregion
    }
}
