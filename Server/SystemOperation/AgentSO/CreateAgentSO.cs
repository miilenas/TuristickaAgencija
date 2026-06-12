using DBBroker;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.AgentSO
{
    internal class CreateAgentSO : SystemOperationBase
    {
        private readonly Agent agent;

        public CreateAgentSO(Agent agent)
        {
            this.agent = agent;
        }

        protected override void ExecuteOperation()
        {
            broker.Add(agent);
        }
    }
}
