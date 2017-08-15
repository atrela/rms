using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AgentSDK.WebApi
{
    public class HttpApiClient<T> : IApiClient<T> where T : class
    {
        public async Task<HttpResponseMessage> PostData(Uri uri, T dto)
        {
            var jsonData = JsonConvert.SerializeObject(dto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var httpClient = new HttpClientFactory().CreateDefault();
            var response = await httpClient.PostAsync(uri, content);
            return response;
        }
    }
}