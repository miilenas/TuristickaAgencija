using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.InstruktorSO
{
    internal class VratiListuSviAgentSO : SystemOperationBase
    {
        public List<Agent> Result { get; set; } = new List<Agent>();

        public VratiListuSviAgentSO()
        {
        }

        protected override void ExecuteOperation()
        {
            Result = broker.GetAll(new Agent()).Cast<Agent>().ToList();
            if (Result == null || Result.Count == 0)
            {
                throw new Exception("Nema sacuvanih agenata u bazi!");
            }
        }
    }
}
