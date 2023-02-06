using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APICaller
{
    public class APIRequests
    {
        private HttpClient client;
        public APIRequests()
        {
            client = new HttpClient();
        }
        public Task<HttpResponseMessage> AddClient(string name, string guid)
        {
            string requestBody = "{\"name\": \"" + name + "\", \"guid\": \"" + guid + "\"}";

            HttpContent firstRequestContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> firstResponseTask = client.PostAsync("https://localhost:7286/api/Client/Create", firstRequestContent);

            return firstResponseTask;
        }
        public Task<HttpResponseMessage> UpdateClient(string id, string name, string userid, string guid)
        {
            string requestBody = "{\"id\": \"" + id + "\", \"name\": \"" + name + "\", \"userid\": \"" + userid + "\", \"guid\": \"" + guid + "\"}";

            HttpContent firstRequestContent = new StringContent(requestBody, Encoding.UTF8, "application/json");

            Task<HttpResponseMessage> firstResponseTask = client.PutAsync("https://localhost:7286/api/Client/Update", firstRequestContent);

            return firstResponseTask;
        }

    }
}
