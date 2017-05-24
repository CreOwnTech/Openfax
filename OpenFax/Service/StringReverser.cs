using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax
{
    [ServiceContract]
    public interface IStatusService
    {
        [OperationContract]
        string SendStatus(string status, string id);
    }

    [ServiceBehavior(UseSynchronizationContext = false)]
    public class StatusService : IStatusService
    {
        public string SendStatus(string status, string id)
        {
            //char[] retVal = value.ToCharArray();
            //int idx = 0;
            //for (int i = value.Length - 1; i >= 0; i--)
            //    retVal[idx++] = value[i];
            //return new string(retVal);
            
            return string.Empty;
        }
    }
}
