using Client.UserControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void ChangePanel(Control control)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(control);
            control.Dock = DockStyle.Fill;
        }

        private void putnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new PutnikUC());
            this.Text = "Putnik";

        }

        private void rezervacijaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new RezervacijaUC(null));
            this.Text = "Rezervacija";
        }

        private void licencaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePanel(new LicencaUC());
            this.Text = "Licenca";
        }
    }







}
