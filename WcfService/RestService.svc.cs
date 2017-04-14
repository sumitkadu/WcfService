using System.IO;
using System.ServiceModel.Web;

namespace WcfService
{
    public class RestService : IRestService
    {   
        public string GetData()
        {
            try
            {
                using (StreamReader reader = new StreamReader("Output.json"))
                {
                    string content = reader.ReadToEnd();
                    reader.Close();                   
                    return content;
                }
            }
            catch
            {
                return "Something went wrong";
            }
        }
    }
}
