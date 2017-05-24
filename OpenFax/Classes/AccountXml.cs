using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenFax.Classes
{
    [XmlRoot("account")]
    public class AccountXml
    {
        [XmlElement("accountnumber")]
        public string AccountNumber { get; set; }

        [XmlElement("apikey")]
        public string ApiKey { get; set; }

        [XmlElement("imagetype")]
        public string ImageType { get; set; }

        [XmlElement("imagesavepath")]
        public string ImageSavePath { get; set; }

        [XmlElement("isprefix")]
        public string IsPrefix { get; set; }

        [XmlElement("prefix")]
        public string Prefix { get; set; }

        [XmlElement("issuffix")]
        public string IsSuffix { get; set; }

        [XmlElement("suffix")]
        public string Suffix { get; set; }

        [XmlElement("checknewfaxes")]
        public string CheckNewFaxes { get; set; }
    }
}
