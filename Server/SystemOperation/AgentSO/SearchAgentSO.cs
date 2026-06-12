using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.InstruktorSO
{
    public class SearchAgentSO : SystemOperationBase
    {
        protected readonly Agent agent;

        public SearchAgentSO(Agent agent)
        {
            this.agent = agent;
        }

        protected override void ExecuteOperation()
        {
            broker.GetAll(agent);
        }
    }
}
