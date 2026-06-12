using Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.LicencaSO
{
    public class DeleteLicencaSO : SystemOperationBase
    {
        private readonly Licenca licenca;

        public DeleteLicencaSO(Licenca licenca)
        {
            this.licenca = licenca;
        }

        protected override void ExecuteOperation()
        {
            broker.Delete(licenca);
        }
    }
}
