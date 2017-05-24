using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFax
{
    public partial class LatestSoftware : Form
    {
        public string DownloadLink { get; set; }
        public LatestSoftware(string link)
        {
            InitializeComponent();
            this.DownloadLink = link;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.DownloadLink);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
