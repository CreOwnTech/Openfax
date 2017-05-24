using OpenFax.Services.client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Services
{
    class Program
    {
        static void Main(string[] args)
        {
           

            System.ServiceProcess.ServiceBase[] ServicesToRun;
            ServicesToRun = new System.ServiceProcess.ServiceBase[]
            {
                new OpenFaxDownloadService()
            };
            System.ServiceProcess.ServiceBase.Run(ServicesToRun);
        }
    }
}
