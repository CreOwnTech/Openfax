using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFax
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.lbllatestversion.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
