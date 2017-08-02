using Newtonsoft.Json;
using RMS.IISAgent.Data.Model;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace RMS.IISAgent.Data.Service
{
    internal class GatewayClient : IGatewayClient
    {
        private readonly Configuration.IConfigurationProvider configurationProvider;

        public GatewayClient(Configuration.IConfigurationProvider configurationProvider)
        {
            this.configurationProvider = configurationProvider;
        }

        public async Task PushData(WebAppLogDto dto)
        {
            var uri = new Uri(configurationProvider.GatewayUrl);
            var jsonData = JsonConvert.SerializeObject(dto);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var httpClient = new HttpClientFactory().CreateDefault();
            var response = await httpClient.PostAsync(uri, content);
            if (!response.IsSuccessStatusCode)
                throw new HttpRequestException("An error has occurred.");
        }
    }
}