using Traveller.Models;

namespace Traveller.Interface
{
    public interface IAgent
    {
        public Task<ICollection<Agent>> GetAgent();

        public Task<Agent> PutAgent(Agent Agent);

        public Task<Agent> PostAgent(Agent Agent);

        public Task<Agent> DeleteAgent(int id);

        public Task<Agent> GetAgentById(int customer_id);
        public Task<Agent> GetAgent(string email_id);
    }
}
