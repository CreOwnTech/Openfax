using OpenFax.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace OpenFax
{
    //[ServiceContract]
    //public interface IStringReverser
    //{
    //    [OperationContract]
    //    string ReverseString(string value);
    //}

    public partial class Account : Form
    {
        public OpenFax OpenFaxLogForm { get; set; }
        public Account(OpenFax form)
        {
            InitializeComponent();
            this.OpenFaxLogForm = form;
            this.chkDefaultPrefix.Checked = false;
            this.chkDefaultSuffix.Checked = false;
            this.cmbCheckNewFaxes.SelectedIndex = 0;
            var accountdata = Functions.LoadAccountFromXml();
            this.txtAccountNumber.Text = accountdata.AccountNumber;
            this.txtAPIKey.Text = accountdata.ApiKey;
            this.cmbCheckNewFaxes.SelectedItem = accountdata.CheckNewFaxes;
            this.txtSaveImagePath.Text = accountdata.ImageSavePath;
            bool chkval = false;
            bool.TryParse(accountdata.IsPrefix, out chkval);
            this.chkDefaultPrefix.Checked = !string.IsNullOrEmpty(accountdata.IsPrefix) ? chkval : false;
            chkval = false;
            bool.TryParse(accountdata.IsSuffix, out chkval);
            this.chkDefaultSuffix.Checked = !string.IsNullOrEmpty(accountdata.IsSuffix) ? chkval : false;
            this.txtDefaultSuffix.Text = accountdata.Suffix;
            this.txtDefaultPrefix.Text = accountdata.Prefix;
            this.rbPDF.Checked = accountdata.ImageType == Constants.ACCOUNT_IMAGETYPE_PDF;
            this.rbMultipageTiff.Checked = accountdata.ImageType == Constants.ACCOUNT_IMAGETYPE_TIFF;


            //ChannelFactory<IStringReverser> httpFactory = new ChannelFactory<IStringReverser>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8000/reverse"));

            //ChannelFactory<IStringReverser> pipeFactory = new ChannelFactory<IStringReverser>(new NetNamedPipeBinding(), new EndpointAddress("net.pipe://localhost/PipeReverse"));

            //IStringReverser httpProxy = httpFactory.CreateChannel();

            //IStringReverser pipeProxy = pipeFactory.CreateChannel();

            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    string asda = httpProxy.ReverseString(str);
            //    Console.WriteLine("http: " + httpProxy.ReverseString(str));
            //    Console.WriteLine("pipe: " + pipeProxy.ReverseString(str));
            //}

            //ChannelFactory<IStringReverser> httpFactory = new ChannelFactory<IStringReverser>(new BasicHttpBinding(), new EndpointAddress("http://localhost:8000/reverse"));

            //ChannelFactory<IStringReverser> pipeFactory = new ChannelFactory<IStringReverser>(new NetNamedPipeBinding(NetNamedPipeSecurityMode.Transport), new EndpointAddress("net.pipe://localhost/reverse"));

            ////IStringReverser httpProxy = httpFactory.CreateChannel();

            //IStringReverser pipeProxy = pipeFactory.CreateChannel();
            
            //var output = pipeProxy.ReverseString("Rak");
            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    //string asda = httpProxy.ReverseString(str);
            //    //Console.WriteLine("http: " + httpProxy.ReverseString(str));
            //    Console.WriteLine("pipe: " + pipeProxy.ReverseString(str));
            //}

            //ChannelFactory<IStringReverser> httpFactory = new ChannelFactory<IStringReverser>(new BasicHttpBinding("WSHttpBinding_IRepositorio"), new EndpointAddress("http://localhost:8000/Reverse"));

            //ChannelFactory<IStringReverser> pipeFactory = new ChannelFactory<IStringReverser>(new NetNamedPipeBinding("NetHttpBinding_IRepositorio"), new EndpointAddress("net.pipe://localhost/PipeReverse"));

            //IStringReverser httpProxy = httpFactory.CreateChannel(); ;

            //IStringReverser pipeProxy = pipeFactory.CreateChannel();

            //while (true)
            //{
            //    string str = Console.ReadLine();
            //    Console.WriteLine("http: " + httpProxy.ReverseString(str));
            //    Console.WriteLine("pipe: " + pipeProxy.ReverseString(str));
            //}
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = fileDailogueImagePath.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderPath = fileDailogueImagePath.SelectedPath;
                this.txtSaveImagePath.Text = folderPath;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            AccountXml account = new AccountXml();
            account.AccountNumber = this.txtAccountNumber.Text;
            account.ApiKey = this.txtAPIKey.Text;
            account.CheckNewFaxes = this.cmbCheckNewFaxes.SelectedItem != null ? this.cmbCheckNewFaxes.SelectedItem.ToString() : string.Empty;
            account.ImageSavePath = this.txtSaveImagePath.Text;
            account.IsPrefix = this.chkDefaultPrefix.Checked.ToString();
            account.IsSuffix = this.chkDefaultSuffix.Checked.ToString();
            account.Suffix = this.txtDefaultSuffix.Text;
            account.Prefix = this.txtDefaultPrefix.Text;
            account.ImageType = this.rbMultipageTiff.Checked ? this.rbMultipageTiff.Text : this.rbPDF.Text;

            if (!string.IsNullOrEmpty(this.txtAccountNumber.Text) && !string.IsNullOrEmpty(this.txtAPIKey.Text))
            {
                if (!string.IsNullOrEmpty(this.txtSaveImagePath.Text))
                {
                    if (!string.IsNullOrEmpty(account.ImageType))
                    {
                        if (!string.IsNullOrEmpty(account.CheckNewFaxes))
                        {
                            if (!string.IsNullOrEmpty(this.txtDefaultPrefix.Text) && !this.chkDefaultPrefix.Checked)
                            {
                                MessageBox.Show("Please select add default file prefix checkbox.", "Select File Prefix", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(this.txtDefaultSuffix.Text) && !this.chkDefaultSuffix.Checked)
                                {
                                    MessageBox.Show("Please select add default file suffix checkbox.", "Select File Suffix", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                                }
                                else
                                {
                                    //before saving checks the accountnumber and api is valid or not
                                    if (ValidateAccount())
                                    {
                                        SaveToXml(account);

                                        //start windows service
                                        ServiceController service = new ServiceController("OpenfaxDownloader");
                                        bool isservicestarted = false;
                                        switch (service.Status)
                                        {
                                            case ServiceControllerStatus.Running:
                                                isservicestarted = true;
                                                break;
                                            case ServiceControllerStatus.StartPending:
                                                isservicestarted = true;
                                                break;
                                        }
                                        if (!isservicestarted)
                                        {
                                            try
                                            {
                                                TimeSpan timeout = TimeSpan.FromMilliseconds(10000);
                                                service.Start();
                                                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                                                MessageBox.Show("Windows opefax service is started.", "Service Started", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1);
                                            }
                                            catch (Exception ex)
                                            {
                                                Logger.Log("Error occured while starting the service - " + ex.Message);
                                            }
                                        }
                                        else
                                        {
                                            service.Refresh();
                                        }
                                        this.OpenFaxLogForm.StartSchedular();
                                        DialogResult result = MessageBox.Show(Constants.ACCOUNT_SAVEALL, Constants.ACCOUNT_SAVEALLTITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                                        if (result == DialogResult.OK)
                                            this.Close();
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please select time for new faxes from dropdown.", "Check for new faxes validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select fax type.", "Select Fax Type", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show(Constants.ACCOUNT_IMAGESAVE_VALIDATIONERROR, Constants.ACCOUNT_IMAGESAVE_VALIDATIONERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show(Constants.ACCOUNT_VALIDATIONERROR1 + Environment.NewLine + Constants.ACCOUNT_VALIDATIONERROR2, Constants.ACCOUNT_VALIDATIONERROR_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private static void SaveToXml(AccountXml account)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.ACCOUNT_XML_PATH);
            xml.SelectSingleNode("//account/accountnumber").InnerText = account.AccountNumber;
            xml.SelectSingleNode("//account/apikey").InnerText = account.ApiKey;
            xml.SelectSingleNode("//account/checknewfaxes").InnerText = account.CheckNewFaxes;
            xml.SelectSingleNode("//account/imagesavepath").InnerText = account.ImageSavePath;
            xml.SelectSingleNode("//account/isprefix").InnerText = account.IsPrefix;
            xml.SelectSingleNode("//account/issuffix").InnerText = account.IsSuffix;
            xml.SelectSingleNode("//account/suffix").InnerText = account.Suffix;
            xml.SelectSingleNode("//account/prefix").InnerText = account.Prefix;
            xml.SelectSingleNode("//account/imagetype").InnerText = account.ImageType;
            xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.ACCOUNT_XML_PATH);

            //update did configurations  which are using default configs
            XmlDocument xmldid = new XmlDocument();
            xmldid.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
            XmlNodeList xnList = xmldid.SelectNodes("/didconfigurations/did/isdefault[text()='true']");
            foreach (XmlNode xn in xnList)
            {
                foreach (XmlNode item in xn.ParentNode.ChildNodes)
                {
                    switch (item.Name)
                    {
                        case "filepath":
                            item.InnerText = account.ImageSavePath;
                            break;
                        case "suffix":
                            item.InnerText = account.Suffix;
                            break;
                        case "prefix":
                            item.InnerText = account.Prefix;
                            break;
                        case "isprefix":
                            item.InnerText = account.IsPrefix;
                            break;
                        case "issuffix":
                            item.InnerText = account.IsSuffix;
                            break;
                        case "type":
                            item.InnerText = account.ImageType;
                            break;
                    }
                }
            }
            xmldid.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
        }

        private void lnkWhereAPI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Constants.ACCOUNT_WHEREAPILINK, Constants.ACCOUNT_WHEREAPILINKTITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            ValidateAccount();
        }

        private bool ValidateAccount()
        {
            bool isAuthenticated = Functions.AuthenticateAccount(this.txtAccountNumber.Text, this.txtAPIKey.Text);
            if (isAuthenticated)
            {
                MessageBox.Show(Constants.ACCOUNT_MESSAGE_TESTSUCCESSFUL, Constants.ACCOUNT_MESSAGETITLE_TESTSUCCESSFUL, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show(Constants.ACCOUNT_MESSAGE_TESTFAILED, Constants.ACCOUNT_MESSAGETITLE_TESTFAILED, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            return isAuthenticated;
        }

        private void txtDefaultPrefix_TextChanged(object sender, EventArgs e)
        {
            CheckTheBox(this.chkDefaultPrefix, this.txtDefaultPrefix);
        }

        private void CheckTheBox(CheckBox chk, TextBox txt, bool isPrefix = true)
        {
            if (!string.IsNullOrEmpty(txt.Text) && !chk.Checked)
            {
                if (isPrefix)
                    MessageBox.Show("Please select add default file prefix checkbox");
                else
                    MessageBox.Show("Please select add default file suffix checkbox");
            }
        }

        private void txtDefaultSuffix_TextChanged(object sender, EventArgs e)
        {
            CheckTheBox(this.chkDefaultSuffix, this.txtDefaultSuffix, false);
        }
    }
}
