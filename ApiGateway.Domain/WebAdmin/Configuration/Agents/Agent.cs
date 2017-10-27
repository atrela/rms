namespace ApiGateway.Domain.Configuration.Agents
{
    public class Agent
    {
        internal Agent()
        {

        }

        private Agent(string name, string description, bool isEnabled)
        {
            this.name = name;
            this.description = description;
            this.isEnabled = isEnabled;
        }

        private int id;
        private string name;
        private string description;
        private bool isEnabled;

        public int Id => id;

        public static Agent Create(string name, string description, bool isEnabled = false) =>
            new Agent(name, description, isEnabled);

        public void Enable()
        {
            isEnabled = true;
        }
    }
}