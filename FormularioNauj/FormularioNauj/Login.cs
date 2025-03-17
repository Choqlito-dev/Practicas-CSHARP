using System;
using System.Windows.Forms;
using KeyAuth;

namespace FormularioNauj
{
    public partial class Login : Form
    {

        public static api KeyAuthApp = new api(
            name: "Choqlito", // App name
            ownerid: "ShS7AgPckY", // Account ID
            version: "1.0" // Application version. Used for automatic downloads see video here https://www.youtube.com/watch?v=kW195PLCBKs
                           //path: @"Your_Path_Here" // (OPTIONAL) see tutorial here https://www.youtube.com/watch?v=I9rxt821gMk&t=1s
        );


        public Login()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {
            Registro registroForm = new Registro();
            this.Hide();
            registroForm.Show();
        }

        private void guna2TextBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            await KeyAuthApp.login(Username.Text, Password.Text);
            if (KeyAuthApp.response.success)
            {
                Main main = new Main();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Verifique sus credenciales y intente de nuevo.");


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
