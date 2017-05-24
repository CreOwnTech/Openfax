using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenFax.Classes
{
    public class LogXml
    {
        [XmlElement("intransid")]
        public string IntransId { get; set; }
        [XmlElement("received")]
        public string Received { get; set; }
        [XmlElement("did")]
        public string Did { get; set; }
        [XmlElement("receivedfrom")]
        public string ReceivedFrom { get; set; }
        [XmlElement("pages")]
        public string Pages { get; set; }
        [XmlElement("faximagefile")]
        public string FaxImageFile { get; set; }
        [XmlElement("redownload")]
        public string ReDownload { get; set; }
        [XmlElement("status")]
        public string Status { get; set; }
    }

    [XmlRoot("logs")]
    public class LogList
    {
        [XmlElement("log")]
        public List<LogXml> Logs { get; set; }
    }
}
