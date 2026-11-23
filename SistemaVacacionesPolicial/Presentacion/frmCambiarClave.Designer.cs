using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class frmCambiarClave
    {
        private Label lblEncabezado;
        private Label lblActual;
        private TextBox txtActual;
        private Label lblNueva;
        private TextBox txtNueva;
        private Label lblConfirmar;
        private TextBox txtConfirmar;
        private Button btnGuardar;
        private Label lblEstado;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.lblEncabezado = new Label();
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Location = new Point(0, 0);
            this.lblEncabezado.Size = new Size(720, 46);
            this.lblEncabezado.Text = "Cambiar contraseña";
            this.lblEncabezado.BackColor = Color.FromArgb(31, 58, 95);
            this.lblEncabezado.ForeColor = Color.White;
            this.lblEncabezado.Dock = DockStyle.Top;
            this.lblEncabezado.Padding = new Padding(18, 0, 0, 0);
            this.lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            this.lblEncabezado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblActual = new Label();
            this.lblActual.Name = "lblActual";
            this.lblActual.Location = new Point(24, 72);
            this.lblActual.Size = new Size(300, 24);
            this.lblActual.Text = "Contraseña actual";
            this.txtActual = new TextBox();
            this.txtActual.Name = "txtActual";
            this.txtActual.Location = new Point(24, 96);
            this.txtActual.Size = new Size(300, 28);
            this.txtActual.UseSystemPasswordChar = true;
            this.txtActual.Enabled = false;
            this.lblNueva = new Label();
            this.lblNueva.Name = "lblNueva";
            this.lblNueva.Location = new Point(24, 134);
            this.lblNueva.Size = new Size(300, 24);
            this.lblNueva.Text = "Nueva contraseña";
            this.txtNueva = new TextBox();
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.Location = new Point(24, 158);
            this.txtNueva.Size = new Size(300, 28);
            this.txtNueva.UseSystemPasswordChar = true;
            this.txtNueva.Enabled = false;
            this.lblConfirmar = new Label();
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Location = new Point(24, 196);
            this.lblConfirmar.Size = new Size(300, 24);
            this.lblConfirmar.Text = "Confirmar contraseña";
            this.txtConfirmar = new TextBox();
            this.txtConfirmar.Name = "txtConfirmar";
            this.txtConfirmar.Location = new Point(24, 220);
            this.txtConfirmar.Size = new Size(300, 28);
            this.txtConfirmar.UseSystemPasswordChar = true;
            this.txtConfirmar.Enabled = false;
            this.btnGuardar = new Button();
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Location = new Point(24, 266);
            this.btnGuardar.Size = new Size(106, 34);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Enabled = false;
            this.lblEstado = new Label();
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Location = new Point(24, 314);
            this.lblEstado.Size = new Size(520, 26);
            this.lblEstado.Text = "Cambio de contraseña pendiente de conexión.";
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtConfirmar);
            this.Controls.Add(this.lblConfirmar);
            this.Controls.Add(this.txtNueva);
            this.Controls.Add(this.lblNueva);
            this.Controls.Add(this.txtActual);
            this.Controls.Add(this.lblActual);
            this.Controls.Add(this.lblEncabezado);
            this.Text = "Cambiar contraseña";
            this.Name = "frmCambiarClave";
            this.ClientSize = new Size(720, 430);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.FromArgb(244, 246, 248);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
