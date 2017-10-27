using Dapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ApiGateway.Persistance.Queries.AgentConfiguration
{
    public class FindMyAgentsHandler : IAsyncRequestHandler<FindMyAgents, IEnumerable<MyAgentDto>>
    {
        private readonly Func<IDbConnection> dbConnectionFactory;

        public FindMyAgentsHandler(Func<IDbConnection> dbConnectionFactory)
        {
            this.dbConnectionFactory = dbConnectionFactory;
        }

        public async Task<IEnumerable<MyAgentDto>> Handle(FindMyAgents message)
        {
            using (var dbConnection = dbConnectionFactory())
            {
                const string sql = "SELECT * FROM Configuration.MyAgents";
                return await dbConnection.QueryAsync<MyAgentDto>(sql);
            }
        }
    }
}
