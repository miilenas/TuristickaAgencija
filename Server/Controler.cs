using Common.Domain;
using Common.Model;
using DBBroker;
using Server.SystemOperation.InstruktorSO;
using Server.SystemOperation.LicencaSO;
using Server.SystemOperation.MestoSO;
using Server.SystemOperation.PutnikSO;
using Server.SystemOperation.Rezervacije;
using Server.SystemOperation.SmestajSO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Controler
    {
        private BrokerDB broker;

        private static Controler instance;
       // private Putnik kriterijum;

        public static Controler Instance
        {
            get
            {
                if (instance == null)
                    instance = new Controler();
                return instance;
            }
        }
        private Controler()
        {
            broker = new BrokerDB();
        }

        //agent
        public Agent Login(Agent agent)
        {
            LoginAgentSO so = new LoginAgentSO(agent);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List<Agent> VratiListuSviAgent()
        {
            VratiListuSviAgentSO so = new VratiListuSviAgentSO();
            so.ExecuteTemplate();
            return so.Result;
        }

        //rezervacija
        public Rezervacija CreateRezervacija(Rezervacija rez)
        {
            CreateRezervacijaSO so = new CreateRezervacijaSO(rez);
            so.ExecuteTemplate();
            return so.Result;

        }
        public List <Rezervacija> SearchRezervacija(KriterijumiRezervacija kriterijum)
        {
            SearchRezervacijaSO so = new SearchRezervacijaSO(kriterijum);
            so.ExecuteTemplate();
            return so.Result;

        }

        public Rezervacija UpdateRezervacija (Rezervacija rez)
        {
            UpdateRezervacijaSO so = new UpdateRezervacijaSO(rez);
            so.ExecuteTemplate();
            return so.Result;
        }

        public List <Rezervacija> VratiListuSviRezervacija()
        {
            VratiListuSviRezervacijaSO so=new VratiListuSviRezervacijaSO();
            so.ExecuteTemplate() ;
            return so.Result;

        }


        //putnik
        public Putnik CreatePutnik(Putnik putnik)
        {
            CreatePutnikSO so=new CreatePutnikSO(putnik);
            so.ExecuteTemplate();
            return so.Result;
        }
        public Putnik UpdatePutnik(Putnik putnik)
        {
            UpdatePutnikSO so = new UpdatePutnikSO(putnik);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<Putnik> SearchPutnik(KriterijumPutnik kriterijum)
        {
            SearchPutnikSO so = new SearchPutnikSO(kriterijum);
            so.ExecuteTemplate();
            return so.Result;
        }
        public List<Putnik> VratiListuSviPutnik()
        {
            VratiListuSviPutnikSO so = new VratiListuSviPutnikSO();
            so.ExecuteTemplate();
            return so.Result;
        }
        public void DeletePutnik(Putnik putnik)
        {
            DeletePutnikSO so = new DeletePutnikSO(putnik);
            so.ExecuteTemplate();
        }

        //mesto
        public void CreateMesto(Mesto mesto)
        {
            CreateMestoSO so= new CreateMestoSO(mesto);
            so.ExecuteTemplate();
           //proveri da li ova so treba da vraca povratnu vrednost mesto ili ovako void
        }
        public void DeleteMesto(Mesto mesto)
        {
            DeleteMestoSO so = new DeleteMestoSO(mesto);
            so.ExecuteTemplate();
        }
        public List<Mesto> VratiListuSviMesto()
        {
            VratiListuSviMestoSO so = new VratiListuSviMestoSO();
            so.ExecuteTemplate();
            return so.Result;
        }
        
        //licenca

        public void DeleteLicenca(Licenca lic)
        {
            DeleteLicencaSO so= new DeleteLicencaSO(lic);
            so.ExecuteTemplate();
        }
        public Licenca UbaciLicenca(Licenca licenca)
        {
            UbaciLicencaSO so = new UbaciLicencaSO(licenca);
            so.ExecuteTemplate();
            return so.Result;
        }

        //smestaj
        public void CreateSmestaj(Smestaj smestaj)
        {
            CreateSmestajSO so = new CreateSmestajSO(smestaj);
            so.ExecuteTemplate();
        }
        public void DeleteSmestaj(Smestaj smestaj)
        {
            DeleteSmestajSO so = new DeleteSmestajSO(smestaj);
            so.ExecuteTemplate();
        }

        public List<Smestaj> VratiListuSviSmestaj()
        {
            VratiListuSviSmestajSO so = new VratiListuSviSmestajSO();
            so.ExecuteTemplate();
            return so.Result;
        }







    }
}
