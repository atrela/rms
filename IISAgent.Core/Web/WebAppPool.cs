namespace RMS.IISAgent.Core.Web
{
    public class WebAppPool
    {
        private readonly int processId;

        public WebAppPool(string name, int processId)
        {
            Name = name;
            this.processId = processId;
        }

        public string Name { get; }
    }
}