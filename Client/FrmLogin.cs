using Client.GUIControlor;

namespace Client
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {

            InitializeComponent();
        }

        public string email => txtEmail.Text;
        public string password => txtPassword.Text;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginControler.GetInstance().Login();
            
        }
        public bool Validation()
        {
            if (String.IsNullOrEmpty(email))
                return false;
            if (String.IsNullOrEmpty(password))
                return false;
            return true;
        }


    }
}
