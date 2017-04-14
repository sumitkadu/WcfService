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

        public string PostData(string data)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Output.json"))
                {
                    writer.Write(data);
                    writer.Close();
                    return "Data Written Successfully";
                }
            }
            catch
            {
                return "Something went wrong";
            }
        }
    }
}
