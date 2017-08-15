using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace AgentSDK.WebApi
{
    public interface IApiClient<T> where T: class
    {
        Task<HttpResponseMessage> PostData(Uri uri, T dto);
    }
}