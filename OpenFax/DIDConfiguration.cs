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
using System.Xml.Serialization;

namespace OpenFax
{
    public partial class DIDConfiguration : Form
    {
        public OpenFax OpenFaxForm { get; set; }
        public DIDConfiguration(OpenFax form)
        {
            InitializeComponent();
            this.OpenFaxForm = form;
            new NewFax().ProcessDIDs();
            LoadDIDConfiguration();
        }

        public void LoadDIDConfiguration()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(DIDConfigureList));
                XmlDocument xml = new XmlDocument();
                xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
                using (TextReader reader = new StringReader(xml.InnerXml))
                {
                    var result = (DIDConfigureList)serializer.Deserialize(reader);
                    SortableBindingList<DIDConfigurationXml> configs = new SortableBindingList<DIDConfigurationXml>(result.Configurations);
                    this.dgvDIDConfiguration.AutoGenerateColumns = false;
                    if (this.dgvDIDConfiguration.InvokeRequired)
                    {
                        this.dgvDIDConfiguration.Invoke(new Action(() => { this.dgvDIDConfiguration.DataSource = typeof(SortableBindingList<DIDConfigurationXml>); this.dgvDIDConfiguration.DataSource = configs; }));
                    }
                    else
                    {
                        this.dgvDIDConfiguration.DataSource = configs;
                    }
                    this.dgvDIDConfiguration.Columns[Constants.DIDCONFIG_COLUMN_ISDEFAULT].Visible = false;
                    this.dgvDIDConfiguration.Refresh();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error occured while loading DIDs" + ex.Message);
            }
        }

        private void btnConfigureSelected_Click(object sender, EventArgs e)
        {
            List<DIDConfigurationXml> configs = GetSelectedRows();
            if (configs.Count > 0)
            {
                SingleDIDConfiguration singleDIDForm = new SingleDIDConfiguration(configs, this);
                singleDIDForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select atleast one DID to configure.", "Select DID Configuration", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
MessageBoxDefaultButton.Button1);
            }
        }

        private List<DIDConfigurationXml> GetSelectedRows()
        {
            List<DIDConfigurationXml> configs = new List<DIDConfigurationXml>();
            foreach (DataGridViewRow row in this.dgvDIDConfiguration.Rows)
            {
                bool selected = false;
                bool.TryParse(row.Cells[Constants.DIDCONFIG_COLUMN_SELECTED].FormattedValue.ToString(), out selected);
                if (selected)
                {
                    DIDConfigurationXml didXml = new DIDConfigurationXml();
                    didXml.Poll = row.Cells[Constants.DIDCONFIG_COLUMN_POLL].FormattedValue.ToString();
                    didXml.Did = row.Cells[Constants.DIDCONFIG_COLUMN_DID].FormattedValue.ToString();
                    didXml.Name = row.Cells[Constants.DIDCONFIG_COLUMN_NAME].FormattedValue.ToString();
                    didXml.P = row.Cells[Constants.DIDCONFIG_COLUMN_P].FormattedValue.ToString();
                    didXml.S = row.Cells[Constants.DIDCONFIG_COLUMN_S].FormattedValue.ToString();
                    didXml.Prefix = row.Cells[Constants.DIDCONFIG_COLUMN_PREFIX].FormattedValue.ToString();
                    didXml.Suffix
                        = row.Cells[Constants.DIDCONFIG_COLUMN_SUFFIX].FormattedValue.ToString();
                    didXml.Type
                        = row.Cells[Constants.DIDCONFIG_COLUMN_TYPE].FormattedValue.ToString();
                    didXml.D
                        = row.Cells[Constants.DIDCONFIG_COLUMN_D].FormattedValue.ToString();
                    didXml.E
                        = row.Cells[Constants.DIDCONFIG_COLUMN_E].FormattedValue.ToString();
                    didXml.FilePath
                        = row.Cells[Constants.DIDCONFIG_COLUMN_FILEPATH].FormattedValue.ToString();
                    didXml.IsDefault = row.Cells[Constants.DIDCONFIG_COLUMN_ISDEFAULT].FormattedValue.ToString();
                    configs.Add(didXml);
                }
            }

            return configs;
        }

        private void btnSaveConfigurationAndExit_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvDIDConfiguration.Rows)
            {
                DIDConfigurationXml didXml = new DIDConfigurationXml();
                didXml.Poll = row.Cells[Constants.DIDCONFIG_COLUMN_POLL].FormattedValue.ToString();
                didXml.Did = row.Cells[Constants.DIDCONFIG_COLUMN_DID].FormattedValue.ToString();
                SaveToXml(didXml);
            }

            //download
            new NewFax().ProcessFax();
            OpenFaxForm.LoadLogs();
            this.Close();
        }

        private static void SaveToXml(DIDConfigurationXml didXml)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
            XmlNodeList xnList = xml.SelectNodes("/didconfigurations/did[@id=" + didXml.Did + "]");
            foreach (XmlNode xn in xnList)
            {
                if (xn.HasChildNodes)
                {
                    foreach (XmlNode item in xn.ChildNodes)
                    {
                        if (item.Name == Constants.DIDCONFIG_XML_POLL)
                        {
                            item.InnerText = didXml.Poll;
                            break;
                        }
                    }
                }
            }
            xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.DIDCONFIG_XML_PATH);
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvDIDConfiguration.Rows)
            {
                row.Cells[Constants.DIDCONFIG_COLUMN_SELECTED].Value = "false";
            }
        }

        private void dgvDIDConfiguration_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.dgvDIDConfiguration.Columns[Constants.DIDCONFIG_COLUMN_SELECTED].Index)
            {
                this.dgvDIDConfiguration.CommitEdit(DataGridViewDataErrorContexts.Commit);
                int ct = 0;
                foreach (DataGridViewRow row in this.dgvDIDConfiguration.Rows)
                {
                    if (row.Cells[Constants.DIDCONFIG_COLUMN_SELECTED].FormattedValue.ToString().ToLower() == "true")
                    {
                        ct++;
                    }
                }
                this.btnConfigureSelected.Text = (ct == 0 || ct == 1) ? "Configure Single" : "Configure Multiple";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DIDConfiguration_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
