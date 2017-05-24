using OpenFax.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace OpenFax
{
    public partial class OpenFax : Form
    {
        public DIDConfiguration DidForm { get; set; }
        public SortableBindingList<LogXml> Logs { get; set; }

        public OpenFax()
        {
            InitializeComponent();
            LoadLogs();
            StartSchedular();
            CheckVersion();
            StartSoftwareUpdateSchedular();
            //using (ServiceHost host = new ServiceHost(typeof(StringReverser), new Uri[] { new Uri("http://localhost:8211"), new Uri("net.pipe://localhost") }))
            //{
            //ServiceHost host = new ServiceHost(typeof(StringReverser));
            //host.AddServiceEndpoint(typeof(IStringReverser), new BasicHttpBinding(), "Reverse");
            //host.AddServiceEndpoint(typeof(IStringReverser), new NetNamedPipeBinding(), "reverse");
            //host.Open();
            //Console.WriteLine("Service is available. " + "Press <ENTER> to exit.");
            //Console.ReadLine();
            //ServiceHost host = new ServiceHost(typeof(StringReverser), new Uri[] { new Uri("http://localhost:8000"), new Uri("net.pipe://localhost") });
            //host.AddServiceEndpoint(typeof(IStringReverser),
            //  new BasicHttpBinding("WSHttpBinding_IRepositorio"),
            //  "Reverse");
            //host.AddServiceEndpoint(typeof(IStringReverser),
            //  new NetNamedPipeBinding("NetHttpBinding_IRepositorio"),
            //  "PipeReverse");
            //host.Open();
            //Console.WriteLine("Service is available. " +
            //  "Press <ENTER> to exit.");
            //Console.ReadLine();
            //host.Close();
        }

        public void StartSoftwareUpdateSchedular()
        {
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 12 * 60 * 60 * 1000;
            timer.Elapsed += timer_Elapsed2;
            timer.Start();
        }

        private void timer_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
        {
            CheckVersion();
        }

        private static void CheckVersion()
        {
            var latestFile = Functions.GetLatestVersion();
            if (latestFile != null && !string.IsNullOrEmpty(latestFile.Version) && Assembly.GetExecutingAssembly().GetName().Version.ToString() != latestFile.Version + ".0.0.0")
            {
                LatestSoftware soft = new LatestSoftware(latestFile.DownloadURL);
                soft.ShowDialog();
            }
        }

        public void LoadLogs()
        {
            try
            {
                Control.CheckForIllegalCrossThreadCalls = false;
                XmlSerializer serializer = new XmlSerializer(typeof(LogList));
                XmlDocument xml = new XmlDocument();
                xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
                using (TextReader reader = new StringReader(xml.InnerXml))
                {
                    var result = (LogList)serializer.Deserialize(reader);
                    this.dgvFaxDownloadLog.AutoGenerateColumns = false;
                    this.Logs = new SortableBindingList<LogXml>(result.Logs);

                    if (this.dgvFaxDownloadLog.InvokeRequired)
                    {
                        this.dgvFaxDownloadLog.Invoke(new Action(() => { this.dgvFaxDownloadLog.DataSource = typeof(SortableBindingList<LogXml>); this.dgvFaxDownloadLog.DataSource = this.Logs; }));
                    }
                    else
                    {
                        this.dgvFaxDownloadLog.DataSource = this.Logs;
                    }
                    this.dgvFaxDownloadLog.Refresh();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("There is error while loading newfaxes" + ex.Message);
            }
        }

        public void StartSchedular()
        {
            try
            {
                System.Timers.Timer timer = new System.Timers.Timer();

                //get time 
                var accountdata = Classes.Functions.LoadAccountFromXml();
                var durationTime = accountdata.CheckNewFaxes;
                double miliseconds = 0;
                switch (durationTime)
                {
                    case "Every 2 Minutes":
                        miliseconds = 2 * 60 * 1000;
                        break;
                    case "Every 5 Minutes":
                        miliseconds = 5 * 60 * 1000;
                        break;
                    case "Every 15 Minutes":
                        miliseconds = 15 * 60 * 1000;
                        break;
                    case "Every 30 Minutes":
                        miliseconds = 30 * 60 * 1000;
                        break;
                    case "Every 1 hour":
                        miliseconds = 60 * 60 * 1000;
                        break;
                }
                if (miliseconds > 0)
                {
                    timer.Interval = 1 * 60 * 1000;
                    timer.Elapsed += timer_Elapsed;
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("There is error while starting timer" + ex.Message);
            }
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.LoadLogs();
            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "DIDConfiguration")
                {
                    this.DidForm.LoadDIDConfiguration();
                    break;
                }
            }
        }

        private void saveExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Account accountForm = new Account(this);
            accountForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DIDConfiguration didForm = new DIDConfiguration(this);
            this.DidForm = didForm;
            didForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void btnClearSelection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in this.dgvFaxDownloadLog.Rows)
            {
                row.Cells["Redownload"].Value = "false";
            }
        }

        private void btnRedownload_Click(object sender, EventArgs e)
        {
            bool itemsselected = false;
            this.dgvFaxDownloadLog.CommitEdit(DataGridViewDataErrorContexts.Commit);
            foreach (DataGridViewRow row in this.dgvFaxDownloadLog.Rows)
            {
                if (row.Cells["Redownload"].FormattedValue.ToString() == "True" || row.Cells["Redownload"].FormattedValue.ToString() == "true")
                {
                    itemsselected = true;
                    new NewFax().RedownloadFaxes(row.Cells["InTransID"].FormattedValue.ToString());
                    row.Cells["Redownload"].Value = "false";
                }
            }

            if (itemsselected)
            {
                MessageBox.Show("Faxes are in queue for redownload.", "Faxes Redownload", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
       MessageBoxDefaultButton.Button1);
            }
            else
            {
                MessageBox.Show("There are no faxes selected.", "No Faxes Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
       MessageBoxDefaultButton.Button1);
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Clearing the log cannnot be undone." + Environment.NewLine + "Are you sure want to clear the entire log?", "Clear Log", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation,
    MessageBoxDefaultButton.Button1);

            if (result == DialogResult.OK)
            {
                if (this.Logs.Count == 0)
                {
                    MessageBox.Show("There are no logs to clear.", "Logs Clear", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);

                }
                else
                {
                    //download selected file
                    XmlDocument xml = new XmlDocument();
                    xml.Load(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
                    XmlNode ParentElement = xml.SelectSingleNode("logs");
                    ParentElement.RemoveAll();
                    xml.Save(Path.GetDirectoryName(Application.ExecutablePath) + Constants.LOG_XML_PATH);
                    this.LoadLogs();
                    MessageBox.Show("Logs have been cleared.", "Logs Clear", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
        MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
