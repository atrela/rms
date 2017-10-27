namespace ApiGateway.Data.IISAgent.Dto
{
    /// <summary>
    ///     Represents Data Transfer Object for ADO.NET statistics.
    /// </summary>
    public class AdoNetStatisticsDto
    {
        /// <summary>
        ///     Gets or sets number of active connection pools.
        /// </summary>
        public int NumberOfActiveConnectionPools { get; set; }

        /// <summary>
        ///     Gets or sets number of inactive connection pools.
        /// </summary>
        public int NumberOfInactiveConnectionPools { get; set; }

        /// <summary>
        ///     Gets or sets number of pooled connections.
        /// </summary>
        public int NumberOfPooledConnections { get; set; }

        /// <summary>
        ///     Gets or sets number of non-pooled connections.
        /// </summary>
        public int NumberOfNonPooledConnections { get; set; }

        /// <summary>
        ///     Gets or sets number of active connections.
        /// </summary>
        public int NumberOfActiveConnections { get; set; }

        /// <summary>
        ///     Gets or sets number of free connections.
        /// </summary>
        public int NumberOfFreeConnections { get; set; }

        /// <summary>
        ///     Gets or sets number of reclaimed connections.
        /// </summary>
        public int NumberOfReclaimedConnections { get; set; }

        /// <summary>
        ///     Gets or sets number of soft connects per second.
        /// </summary>
        public int SoftConnectsPerSecond { get; set; }

        /// <summary>
        ///     Gets or sets number of disconnects per second.
        /// </summary>
        public int SoftDisconnectsPerSecond { get; set; }
    }
}
