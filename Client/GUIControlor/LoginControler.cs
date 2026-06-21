using Common.Communication;
using Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client.GUIControlor
{
    public class LoginControler
    {

        private static LoginControler instance;
        private FrmLogin frmLogin;

        private LoginControler() { }
        public static LoginControler GetInstance()
        {
            if (instance == null)
                instance = new LoginControler();
            return instance;
        }

        internal void ShowFrmLogin()
        {
            try
            {
                Communication.Instance.Connect();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                frmLogin = new Client.FrmLogin();
                frmLogin.AutoSize = true;
                Application.Run(frmLogin);
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Neupesno povezivanje sa serverom!");
            }
        }

        internal void Login()
        {
            if (!frmLogin.Validation())
            {
                MessageBox.Show("Greska! Molim Vas popunite sva polja");
                return;
            }

            Agent agent = new Agent()
            {
                Email = frmLogin.email,
                Password=frmLogin.password, 
            };

            try { 
                Response response = Communication.Instance.Login(agent);
                if (response.IsSuccess)
                {
                    MessageBox.Show("Email adresa i lozinka su ispravni.");
                    try
                    {
                        frmLogin.Visible = false;
                        FrmMain frmMain = new FrmMain();
                        frmMain.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ne moze da se otvori glavna forma i meni: " + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Email adresa i lozinka nisu ispravni.");
                }
            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
           


           
        }
    }
}
