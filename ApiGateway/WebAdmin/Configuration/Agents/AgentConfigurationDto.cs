using System;

namespace ApiGateway.WebAdmin.Configuration.Agents
{
    /// <summary>
    ///     Transfers agent configuration data between view and controller.
    /// </summary>
    public class AgentConfigurationDto
    {
        /// <summary>
        ///     Gets or sets id of the agent.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        ///     Gets or sets description of the agent.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Determines whether agent is endabled or not.
        /// </summary>
        public bool IsEnabled { get; set; }

        /// <summary>
        ///     Gets or sets url to the agent documentation.
        /// </summary>
        public Uri HelpLink { get; set; }
    }
}