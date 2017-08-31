namespace ApiGateway.IISAgent.Dto
{
    /// <summary>
    ///     Represents Data Transfer Object for web application statistics
    /// </summary>
    public class ApplicationStatisticsDto
    {
        /// <summary>
        ///     Gets or sets number of HTTP requests per second.
        /// </summary>
        public int RequestsPerSecond { get; set; }

        /// <summary>
        ///     Gets or sets number of total HTTP requests in application.
        /// </summary>
        public int TotalRequests { get; set; }
    }
}
