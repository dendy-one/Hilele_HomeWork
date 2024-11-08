using System.Net.Http;
using System.Threading.Tasks;

namespace HomeWorkCpro25
{
    public class HTTPClient
    {
        private HttpClient client;
        private string baseUrl;
        public HTTPClient(string baseUrl) 
        { 
            this.client = new HttpClient(); this.baseUrl = baseUrl;
        }
        public async Task<string> SendGetRequest(string endpoint)
        { 
         HttpResponseMessage response = await client.GetAsync(baseUrl + endpoint); 
         response.EnsureSuccessStatusCode();
         return await response.Content.ReadAsStringAsync();
        }
        public async Task<string> SendPostRequest(string endpoint, HttpContent content) 
        {
          HttpResponseMessage response = await client.PostAsync(baseUrl + endpoint, content);
          response.EnsureSuccessStatusCode();
          return await response.Content.ReadAsStringAsync();
        }
    }
}
