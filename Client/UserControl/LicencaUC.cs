using Client.GUIControlor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UserControl
{
    public partial class LicencaUC : System.Windows.Forms.UserControl
    {
        private LicencaControlor controlor;
        public LicencaUC()
        {
            InitializeComponent();
            controlor = new LicencaControlor(this);
        }

        public ComboBox CmbTipLicence => cmbTipLicence;
        public ComboBox CmbAgent => cmbAgent;
        public DateTimePicker DtpDatumIzdavanja => dpIzdavanje;
        public DateTimePicker DtpDatumIsteka => dpIstek;

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            controlor.UbaciLicenca();
        }
    }
}
