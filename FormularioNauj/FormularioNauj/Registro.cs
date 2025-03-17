using System;
using System.Windows.Forms;
using KeyAuth;

namespace FormularioNauj
{
    public partial class Registro : Form
    {

        public static api KeyAuthApp = new api(
            name: "", // App name
            ownerid: "", // Account ID
            version: "" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                           //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
        );


        public Registro()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            this.Hide();
            loginForm.Show();
        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            await KeyAuthApp.register(Username.Text, Password.Text, Key.Text, "");
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Status: " + "Verifique sus credenciales y intente de nuevo.");
        }
    }
}
