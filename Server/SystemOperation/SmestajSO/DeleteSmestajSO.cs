using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.SmestajSO
{
    public class DeleteSmestajSO :SystemOperationBase
    {
        private readonly Smestaj smestaj;

        public DeleteSmestajSO(Smestaj smestaj)
        {
            this.smestaj = smestaj;
        }

        protected override void ExecuteOperation()
        {
            if (smestaj == null)
                throw new Exception("Smestaj ne sme biti null.");

            if (smestaj.IdSmestaj == 0)
                throw new Exception("Smestaj za brisanje mora imati validan ID.");

            broker.Delete(smestaj);
        }
    }
}
