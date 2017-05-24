using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OpenFax.Classes
{
    public class DIDConfigurationXml
    {
        [XmlElement("isdefault")]
        public string IsDefault { get; set; }
        [XmlElement("poll")]
        public string Poll { get; set; }
        [XmlElement("did")]
        public string Did { get; set; }
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("type")]
        public string Type { get; set; }
        [XmlElement("filepath")]
        public string FilePath { get; set; }
        [XmlElement("prefix")]
        public string Prefix { get; set; }
        [XmlElement("suffix")]
        public string Suffix { get; set; }
        [XmlElement("d")]
        public string D { get; set; }
        [XmlElement("e")]
        public string E { get; set; }
        [XmlElement("p")]
        public string P { get; set; }
        [XmlElement("s")]
        public string S { get; set; }
        [XmlElement("isprefix")]
        public string Isprefix { get; set; }
        [XmlElement("issuffix")]
        public string Issuffix { get; set; }
    }

    [XmlRoot("didconfigurations")]
    public class DIDConfigureList
    {
        [XmlElement("did")]
        public List<DIDConfigurationXml> Configurations { get; set; }
    }
}
