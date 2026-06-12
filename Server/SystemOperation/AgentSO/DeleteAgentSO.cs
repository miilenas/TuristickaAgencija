using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.AgentSO
{
    internal class DeleteAgentSO : SystemOperationBase
    {
        private readonly Agent agent;

        public DeleteAgentSO(Agent agent)
        {
            this.agent = agent;
        }

        protected override void ExecuteOperation()
        {
            broker.Delete(agent);
        }
    }
}
