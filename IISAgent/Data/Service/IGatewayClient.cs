using RMS.IISAgent.Data.Model;
using System.Threading.Tasks;

namespace RMS.IISAgent.Data.Service
{
    public interface IGatewayClient
    {
        Task PushData(WebAppLogDto dto);
    }
}