namespace ApiGateway.Domain.Configuration.Agents
{
    public class Agent
    {
        private int id;
        private string name;
        private string description;
        private int customerId;
        private bool isEnabled;

        public int Id => id;

        public void Enable(int customerId)
        {
            this.customerId = customerId;
            isEnabled = true;
        }
    }
}