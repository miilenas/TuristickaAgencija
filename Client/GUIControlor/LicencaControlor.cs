using Client.UserControl;
using Common.Communication;
using Common.Domain;
using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUIControlor
{
    public class LicencaControlor
    {
        private LicencaUC licencaUC;
        public LicencaControlor(LicencaUC uc)
        {
            this.licencaUC = uc;
            this.UcitajTipLicence();
            this.VratiListuSviAgent();


        }
        private void UcitajTipLicence()
        {
            licencaUC.CmbTipLicence.DataSource = Enum.GetValues(typeof(TipLicence));
            licencaUC.CmbTipLicence.SelectedIndex = -1;
        }

        public void UbaciLicenca()
        {
            if (licencaUC.CmbTipLicence.SelectedIndex == -1 ||
                licencaUC.CmbAgent.SelectedIndex == -1 ||
                licencaUC.DtpDatumIzdavanja.Value >= licencaUC.DtpDatumIsteka.Value)
            {
                MessageBox.Show("Molimo Vas popunite sva polja ispravno.");
                return;
            }

            Licenca licenca = new Licenca()
            {
                TipLicence = licencaUC.CmbTipLicence.SelectedValue.ToString()
            };

            AgentLicenca agentLicenca = new AgentLicenca()
            {
                Agent = (Agent)licencaUC.CmbAgent.SelectedItem,
                DatumIzdavanja = DateOnly.FromDateTime(licencaUC.DtpDatumIzdavanja.Value),
                DatumIsteka = DateOnly.FromDateTime(licencaUC.DtpDatumIsteka.Value)
            };

            licenca.agentLicenca = agentLicenca;

            Response response = Communication.Instance.UbaciLicenca(licenca);

            if (response.IsSuccess)
            {
                MessageBox.Show("Sistem je zapamtio licencu.");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da sacuva licencu.");
            }
        }

        private void VratiListuSviAgent()
        {
            try
            {
                List<Agent> agenti = (List<Agent>)Communication.Instance.VratiListuSviAgent();

                if (agenti == null || agenti.Count == 0)
                {
                    MessageBox.Show("Nema registrovanih agenata.");
                    return;
                }

                licencaUC.CmbAgent.DataSource = agenti;
                licencaUC.CmbAgent.ValueMember = "IdAgent";
                licencaUC.CmbAgent.DisplayMember = "FullName";
                licencaUC.CmbAgent.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita agente.");
            }
        }



    








    }
}
