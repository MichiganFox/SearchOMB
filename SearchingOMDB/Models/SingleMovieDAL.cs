using Newtonsoft.Json;
using System.Net;

namespace SearchingOMDB.Models
{
    public class SingleMovieDAL
    {
        public static SingleMovie MovieSearch(string input)//adjust here
        {
            //Adjust here
            //Setup
            string url = $"https://www.omdbapi.com/?t={input}&apikey={Secret.ApiKey}";

            //request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Convert it to JSON
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Adjust here
            //Convert to C#
            SingleMovie result = JsonConvert.DeserializeObject<SingleMovie>(JSON);
            return result;
        }
    }
}