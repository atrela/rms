namespace Logs.Agents.IIS.Model
{
    public class AdoNetStatistics
    {
        public int NumberOfActiveConnectionPools { get; set; }
        public int NumberOfInactiveConnectionPools { get; set; }
        public int NumberOfPooledConnections { get; set; }
        public int NumberOfNonPooledConnections { get; set; }
        public int NumberOfActiveConnections { get; set; }
        public int NumberOfFreeConnections { get; set; }
        public int NumberOfReclaimedConnections { get; set; }
        public int SoftConnectsPerSecond { get; set; }
        public int SoftDisconnectsPerSecond { get; set; }
    }
}