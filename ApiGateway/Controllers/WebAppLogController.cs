using Logs.Agents.IIS.Commands;
using Logs.IISAgent.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ApiGateway.Controllers
{
    [Route("iisagent/log")]
    public class WebAppLogController : Controller
    {
        private readonly IMediator mediator;

        public WebAppLogController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] WebAppLogEntry log)
        {
            var insertLogEntryCmd = new InsertWebAppLogEntryCmd(log);
            await mediator.Send(insertLogEntryCmd);
            return Ok();
        }
    }
}