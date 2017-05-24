using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Classes
{
    public class APIDid
    {
        public string DID { get; set; }
        public object CustomerDescription { get; set; }
        public string MonthlyCharge { get; set; }
        public string ToEmail { get; set; }
        public string FromEmail { get; set; }
        public string EmailNotification { get; set; }
        public string PostToS3 { get; set; }
        public string PostBack { get; set; }
        public string BucketName { get; set; }
        public string PostBackURL { get; set; }
        public string DIDType { get; set; }
        public string is_deleted { get; set; }
        public string Response { get; set; }
    }
}
