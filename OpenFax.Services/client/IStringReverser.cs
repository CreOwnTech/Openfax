using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Services.client
{
    [ServiceContract]
    public interface IStringReverser
    {
        [OperationContract]
        string ReverseString(string value);
    }
}
