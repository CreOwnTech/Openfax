using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OpenFax.Services.Service
{
    [ServiceContract(CallbackContract = typeof(IGUIService))]
    public interface IServerService
    {
        [OperationContract(IsOneWay = true)]
        void Subscribe();

        [OperationContract(IsOneWay = true)]
        void Unsubscribe();
    }

    [ServiceContract]
    public interface IGUIService
    {
        [OperationContract(IsOneWay = true)]
        void MessageCallback(string Message);
    }
}
