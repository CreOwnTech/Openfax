using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OpenFax.Classes
{
    public class Functions
    {
        public static AccountXml LoadAccountFromXml()
        {
            AccountXml account = new AccountXml();
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.ACCOUNT_XML_PATH);
            account.AccountNumber = xml.SelectSingleNode("//account/accountnumber").InnerText;
            account.ApiKey = xml.SelectSingleNode("//account/apikey").InnerText;
            account.CheckNewFaxes = xml.SelectSingleNode("//account/checknewfaxes").InnerText;
            account.ImageSavePath = xml.SelectSingleNode("//account/imagesavepath").InnerText;
            account.IsPrefix = xml.SelectSingleNode("//account/isprefix").InnerText;
            account.IsSuffix = xml.SelectSingleNode("//account/issuffix").InnerText;
            account.Suffix = xml.SelectSingleNode("//account/suffix").InnerText;
            account.Prefix = xml.SelectSingleNode("//account/prefix").InnerText;
            account.ImageType = xml.SelectSingleNode("//account/imagetype").InnerText;
            return account;
        }

        public static List<APIDid> GetDIDs(APIFaxParam param)
        {
            string url = Constants.DID_APIURL + "?" + Constants.NEWFAX_QUERYPARAM_ACCOUNTID + "=" + param.AccountID + "&" + Constants.NEWFAX_QUERYPARAM_APIKEY + "=" + param.APIKey;

            using (WebClient client = new WebClient())
            {
                string s = client.DownloadString(url);
                var model = JsonConvert.DeserializeObject<List<APIDid>>(s);
                return model;
            }
        }

        public static APISoftwareVersion GetLatestVersion()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string s = client.DownloadString(Constants.VERSION_APIURL);
                    var model = JsonConvert.DeserializeObject<APISoftwareVersion>(s);
                    return model;
                }
            }
            catch(Exception ex)
            {
                Logger.Log("Error occured while getting latest version - " + ex.Message);
            }
            return new APISoftwareVersion();
        }

        public static bool AuthenticateAccount(string accountid, string apikey)
        {
            bool isvalid = false;
            try
            {
                var dids = GetDIDs(new APIFaxParam() { AccountID = accountid, APIKey = apikey });
                return dids != null && dids.First().Response != "InvalidMissingValue";
            }
            catch (Exception ex)
            {

            }
            return isvalid;
        }
    }
}
