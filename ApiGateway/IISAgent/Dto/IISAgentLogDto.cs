namespace ApiGateway.IISAgent.Dto
{
    /// <summary>
    ///     Represents Data Transfer Object for IIS Agent data.
    /// </summary>
    public class IISAgentLogDto
    {
        /// <summary>
        ///     Gets or sets name of the web application.
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        ///     Gets or sets ADO.NET statistics of web application.
        /// </summary>
        public AdoNetStatisticsDto AdoNetStatistics { get; set; }

        /// <summary>
        ///     Gets or sets statistics of web application.
        /// </summary>
        public ApplicationStatisticsDto ApplicationStatistics { get; set; }

    }
}