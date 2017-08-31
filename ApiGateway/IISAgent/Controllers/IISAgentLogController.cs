using ApiGateway.IISAgent.Dto;
using AutoMapper;
using Logs.Agents.IIS.Commands;
using Logs.Agents.IIS.Queries;
using Logs.IISAgent.Model;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGateway.IISAgent.Controllers
{
    /// <summary>
    ///     Provides methods to handle IIS Agent Log requests.
    /// </summary>
    [Route("iisagent/log")]
    public class IISAgentLogController : Controller
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        /// <summary>
        ///     Initializes a new instance of the <see cref="IISAgentLogController"/> class.
        /// </summary>
        /// <param name="mediator">An instance of in-process messaging bus.</param>
        /// <param name="mapper">An instance of object mapper</param>
        public IISAgentLogController(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        /// <summary>
        ///     Adds statistics of web app to the data store.
        /// </summary>
        /// <param name="dto">Data Transfer Object containing web app statistics</param>
        /// <returns>HTTP Response</returns>
        /// <response code="200">If item is added successfully</response>
        /// <response code="400">If request body does not have content</response>
        /// <response code="500">If unknown error occurred</response>
        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] IISAgentLogDto dto)
        {
            if (dto == null)
                return BadRequest();

            try
            {
                var webAppLog = mapper.Map<IISAgentLogDto, WebAppLogEntry>(dto);
                var insertLogEntryCmd = new InsertWebAppLogEntryCmd(webAppLog);
                await mediator.Send(insertLogEntryCmd);
                return Ok();
            }
            catch (Exception ex)
            {
                // TODO: log and remove exception info from response
                return StatusCode(StatusCodes.Status500InternalServerError, Json(ex));
            }
        }

        /// <summary>
        ///     Returns statistics for all web apps on the IIS server.
        /// </summary>
        /// <returns>HTTP Request with statistics from all web apps on the IIS server.</returns>
        /// <response code="200">If all data has been retrieved successfully</response>
        /// <response code="400">If data not found</response>
        /// <response code="500">If unknown error occurred</response>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var getLogEntriesQuery = new GetAllLogEntriesQuery();
                var logEntries = await mediator.Send(getLogEntriesQuery);
                if (!logEntries.Any())
                    return NotFound();

                return Ok(logEntries);
            }
            catch (Exception ex)
            {
                // TODO: log and remove exception info from response
                return StatusCode(StatusCodes.Status500InternalServerError, Json(ex));
            }
        }
    }
}