using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Classes
{
    public class APIFaxParam
    {
        public string AccountID { get; set; }
        public string APIKey { get; set; }
        public string FaxType { get; set; }
        public string Limit { get; set; }
        public string DID { get; set; }
    }
}
