using OpenFax.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OpenFax
{
    public partial class SingleDIDConfiguration : Form
    {
        public List<DIDConfigurationXml> Configs { get; set; }
        public AccountXml DefaultConfig { get; set; }
        public DIDConfiguration configForm { get; set; }

        public SingleDIDConfiguration(List<DIDConfigurationXml> configs, DIDConfiguration configForm)
        {
            InitializeComponent();
            this.Configs = configs;
            this.configForm = configForm;
            this.LoadDefaultConfig();

            if (this.Configs.Count == 1)
            {
                this.dgvSelectedConfig.Visible = false;
                this.lblSingleTitle.Visible = true;
                this.lblSingleDIDAndName.Text = this.Configs.First().Name;
            }
            else
            {
                this.dgvSelectedConfig.Visible = true;
                this.lblSingleTitle.Visible = false;
                this.lblSingleDIDAndName.Text = Constants.MULTIDIDCONFIG_TITLE;
                this.dgvSelectedConfig.AutoGenerateColumns = false;
                this.dgvSelectedConfig.DataSource = this.Configs;
            }
        }

        private void LoadDefaultConfig()
        {
            var defaultConfig = Functions.LoadAccountFromXml();
            this.DefaultConfig = defaultConfig;
            this.lblDefaultFaxImageSavePath.Text = defaultConfig.ImageSavePath;
            this.lblDefaultFaxImageType.Text = defaultConfig.ImageType;
            this.lblDefaultPrefix.Text = defaultConfig.Prefix;
            this.lblDefaultSuffix.Text = defaultConfig.Suffix;
            var currentDate = System.DateTime.Now;
            this.lblSampleFileOutput.Text = defaultConfig.Prefix + currentDate.Date.Year + "-" + currentDate.Date.Month + "-" + currentDate.Date.Day + "-" + currentDate.Hour + "-" + currentDate.Minute + "-" + currentDate.Second + "test" + defaultConfig.Suffix + "." + defaultConfig.ImageType.ToLower();

            this.rbUserDefaultSetting.Checked = this.Configs.First().IsDefault == "true";
            this.rbCustomSettings.Checked = !this.rbUserDefaultSetting.Checked;
            this.rbPDF.Checked = this.Configs.First().Type == "PDF";
            this.rbMultipageTIFF.Checked = !this.rbPDF.Checked;
            this.chkAddPrefix.Checked = !string.IsNullOrEmpty(this.Configs.First().Prefix);
            this.chkSuffix.Checked = !string.IsNullOrEmpty(this.Configs.First().Suffix);
            this.txtFilePrefix.Text = this.Configs.First().Prefix;
            this.txtSuffix.Text = this.Configs.First().Suffix;
            this.txtDefaultImageSavePath.Text = this.Configs.First().FilePath;
            this.lblCustomSampleFileOutput.Text = this.Configs.First().Prefix + currentDate.Date.Year + "-" + currentDate.Date.Month + "-" + currentDate.Date.Day + "-" + currentDate.Hour + "-" + currentDate.Minute + "-" + currentDate.Second + "test" + this.Configs.First().Suffix + "." + this.Configs.First().Type.ToLower();
        }

        private void btnSaveAndExit_Click(object sender, EventArgs e)
        {
            DIDConfigurationXml didXml = new DIDConfigurationXml();
            didXml.Did = this.Configs.First().Did;
            didXml.IsDefault = this.rbUserDefaultSetting.Checked ? "true" : "false";
            didXml.Prefix = this.rbUserDefaultSetting.Checked ? this.DefaultConfig.Prefix : this.txtFilePrefix.Text;
            didXml.Suffix = this.rbUserDefaultSetting.Checked ? this.DefaultConfig.Suffix : this.txtSuffix.Text;
            didXml.FilePath = this.rbUserDefaultSetting.Checked ? this.DefaultConfig.ImageSavePath : this.txtDefaultImageSavePath.Text;
            didXml.Type = this.rbUserDefaultSetting.Checked ? this.DefaultConfig.ImageType : (this.rbMultipageTIFF.Checked ? this.rbMultipageTIFF.Text : this.rbPDF.Text);

            didXml.Isprefix = this.chkAddPrefix.Checked ? "true" : "false";
            didXml.Issuffix = this.chkSuffix.Checked ? "true" : "false";
            foreach (var did in this.Configs)
            {
                SaveToXml(didXml, did.Did);
            }
            this.configForm.LoadDIDConfiguration();
            this.Close();
        }

        private static void SaveToXml(DIDConfigurationXml didXml, string did)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
            XmlNodeList xnList = xml.SelectNodes("/didconfigurations/did[@id=" + did + "]");
            foreach (XmlNode xn in xnList)
            {
                if (xn.HasChildNodes)
                {
                    foreach (XmlNode item in xn.ChildNodes)
                    {
                        switch (item.Name)
                        {
                            case Constants.DIDCONFIG_XML_PREFIX:
                                item.InnerText = didXml.Prefix;
                                break;
                            case Constants.DIDCONFIG_XML_SUFFIX:
                                item.InnerText = didXml.Suffix;
                                break;
                            case Constants.DIDCONFIG_XML_TYPE:
                                item.InnerText = didXml.Type;
                                break;
                            case Constants.DIDCONFIG_XML_IMAGESAVEPATH:
                                item.InnerText = didXml.FilePath;
                                break;
                            case Constants.DIDCONFIG_XML_ISDEFAULT:
                                item.InnerText = didXml.IsDefault;
                                break;
                            case Constants.DIDCONFIG_XML_ISSUFFIX:
                                item.InnerText = didXml.Issuffix;
                                break;
                            case Constants.DIDCONFIG_XML_ISPREFIX:
                                item.InnerText = didXml.Isprefix;
                                break;
                            case Constants.DIDCONFIG_XML_D:
                                item.InnerText = didXml.IsDefault;
                                break;
                        }
                    }
                }
            }
            xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.fldrBrowseDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.txtDefaultImageSavePath.Text = this.fldrBrowseDialog.SelectedPath;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtFilePrefix_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
