using System;
using System.Web.SessionState;
using System.Windows.Forms;

namespace FormularioNauj
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarsesion_Click(object sender, EventArgs e)
        {
            // Mostrar un cuadro de diálogo para confirmar
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Limpiar información de sesión
                SessionManager.UsuarioActual = null;

                // Mostrar mensaje de cierre exitoso
                MessageBox.Show("Has cerrado sesión correctamente.", "Cerrar Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Redirigir al usuario a la pantalla de inicio de sesión
                Login loginForm = new Login();
                this.Hide();
                loginForm.Show();
            }
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Perfil perfilForm = new Perfil();
            this.Hide();
            perfilForm.Show();
        }
    }

    public static class SessionManager
    {
        public static string UsuarioActual { get; set; } // Por ejemplo, el nombre de usuario logueado
    }


}
