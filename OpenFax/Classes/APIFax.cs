using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Classes
{
    public class APIFax
    {
        public string InTransID { get; set; }
        public string FaxDocJpegURL { get; set; }
        public string ReceivedTime { get; set; }
        public string Status { get; set; }
        public string SenderCallerID { get; set; }
        public string SenderCallerName { get; set; }
        public string To { get; set; }
        public string Pages { get; set; }
        public double Cost { get; set; }
        public string FaxDocPDFURL { get; set; }
        public string PDFFileName { get; set; }
        public string DocPDFSize { get; set; }
        public string FaxDocTiffURL { get; set; }
        public string PostToS3 { get; set; }
        public string CustomerBucketURL { get; set; }
        public string Response { get; set; }
    }
}
