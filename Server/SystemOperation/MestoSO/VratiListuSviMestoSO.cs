using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.MestoSO
{
    public class VratiListuSviMestoSO :SystemOperationBase
    {
        public List<Mesto> Result { get; set; } = new List<Mesto>();
        protected override void ExecuteOperation()
        {
            Result = broker.GetAll(new Mesto()).Cast<Mesto>().ToList();

            if (Result == null || Result.Count == 0)
            {
                throw new Exception("Nema sacuvanih mesta u bazi!");
            }
        }
    }
}
