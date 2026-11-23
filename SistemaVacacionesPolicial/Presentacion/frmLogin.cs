using System;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show(this, "Completa el usuario y la contraseña.", "Acceso al sistema");
                return;
            }

            MessageBox.Show(this, "La autenticación aún está pendiente de conexión.", "Acceso al sistema");
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void VistaPrevia_Click(object sender, EventArgs e)
        {
            using (var principal = new frmPrincipal(null, cmbVista.SelectedIndex == 1))
                principal.ShowDialog(this);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmbVista.SelectedIndex = 0;
        }
    }
}
