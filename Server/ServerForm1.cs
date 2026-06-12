namespace Server
{
    public partial class ServerForm1 : Form
    {
        public Server server;
        public ServerForm1()
        {
            InitializeComponent();

            buttonStop.Enabled = false;
            textBox1.ReadOnly = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            server = new Server();
            buttonStart.Enabled = false;
            buttonStop.Enabled = true;
            server.Start();
            textBox1.Text = "Server je pokrenut";

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            buttonStart.Enabled = true;
            server.Stop();
            textBox1.Text = "Server nije pokrenut";
        }

        private void ServerForm1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
