using OpenFax.Classes;
using OpenFax.Services.client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace OpenFax.Services
{
    partial class OpenFaxDownloadService : ServiceBase
    {
        Timer timer = null;
        public OpenFaxDownloadService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            try
            {
                timer = new System.Timers.Timer();

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
                    timer.Interval = miliseconds;
                    timer.Elapsed += timer_Elapsed;
                    timer.Start();
                }
            }
            catch (Exception ex)
            {
                Logger.Log("Error occured while starting the service - " + ex.Message);
            }
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            NewFax fax = new NewFax();
            fax.ProcessDIDs();
            fax.ProcessFax();
        }

        protected override void OnStop()
        {
            timer.Enabled = false;
        }
    }
}
