using System.Net.Http;

namespace AgentSDK.WebApi
{
    internal class HttpClientFactory
    {
        private const int MAX_RESPONSE_CONTENT_BUFFER_SIZE = 256000;

        public HttpClient CreateDefault()
        {
            var client = new HttpClient();
            client.MaxResponseContentBufferSize = MAX_RESPONSE_CONTENT_BUFFER_SIZE;

            return client;
        }
    }
}