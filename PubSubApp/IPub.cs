using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PubSubApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPubSubService" in both code and config file together.
    [ServiceContract]
    public interface IPub
    {
        [OperationContract(IsOneWay = true)]
        void WriteMessage(string message);
    }
    [ServiceContract(CallbackContract = typeof(ICallback))]
    public interface ISub
    {
        [OperationContract(IsOneWay = true)]
        void InitSub(string username, string password);
    }
    public interface ICallback
    {
        [OperationContract(IsOneWay = true)]
        void MessageArrived(string message);
    }
}
