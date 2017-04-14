using System.ServiceModel;
using System.ServiceModel.Web;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IRestService
    {
        [OperationContract]        
        string GetData();

        [OperationContract]
        string PostData(string data);
    }    
}
