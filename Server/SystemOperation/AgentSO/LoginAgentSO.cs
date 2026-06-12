using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.InstruktorSO
{
    public class LoginAgentSO : SystemOperationBase
    {
        private readonly Agent agent;
        public Agent Result { get; set; }

        public LoginAgentSO(Agent agent)
        {
            this.agent = agent;
        }

        protected override void ExecuteOperation()
        {
            string condition = $"email = '{agent.Email}' AND password = '{agent.Password}'";

            List<IEntity> lista = broker.GetAll(agent, condition);

            if (lista == null || lista.Count == 0)
                throw new Exception("Email adresa i/ili lozinka nisu ispravni.");

            Result = lista.OfType<Agent>().FirstOrDefault();

            if (Result == null)
                throw new Exception("Email adresa i/ili lozinka nisu ispravni.");

        }
    }
}
