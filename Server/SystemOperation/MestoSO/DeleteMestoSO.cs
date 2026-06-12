using Common.Domain;
using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.SystemOperation.MestoSO
{
    public class DeleteMestoSO :SystemOperationBase
    {
        private readonly Mesto mesto;

        public DeleteMestoSO(Mesto mesto)
        {
            this.mesto = mesto;
        }

        protected override void ExecuteOperation()
        {
            broker.Delete(mesto);
        }
    }
}
