using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class frmLogin
    {
        private Panel pnlIdentidad;
        private PictureBox picUsuario;
        private PictureBox picClave;
        private PictureBox picEscudo;
        private Label lblMarca;
        private Label lblSistema;
        private Label lblDireccion;
        private Label lblInicio;
        private Label lblInstruccion;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblClave;
        private TextBox txtClave;
        private CheckBox chkRecordar;
        private Button btnIngresar;
        private Button btnSalir;
        private Label lblVista;
        private ComboBox cmbVista;
        private Button btnVistaPrevia;
        private Label lblVersion;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.picUsuario = new PictureBox();
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Location = new Point(369, 151);
            this.picUsuario.Size = new Size(24, 24);
            this.picUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            this.picUsuario.Image = ((Image)(resources.GetObject("picUsuario.Image")));
            this.Controls.Add(this.picUsuario);
            this.picClave = new PictureBox();
            this.picClave.Name = "picClave";
            this.picClave.Location = new Point(369, 214);
            this.picClave.Size = new Size(24, 24);
            this.picClave.SizeMode = PictureBoxSizeMode.Zoom;
            this.picClave.Image = ((Image)(resources.GetObject("picClave.Image")));
            this.Controls.Add(this.picClave);
            this.picEscudo = new PictureBox();
            this.picEscudo.Name = "picEscudo";
            this.picEscudo.Location = new Point(109, 62);
            this.picEscudo.Size = new Size(112, 112);
            this.picEscudo.Image = ((Image)(resources.GetObject("picEscudo.Image")));
            this.picEscudo.SizeMode = PictureBoxSizeMode.Zoom;
            this.picEscudo.TabStop = false;
            this.pnlIdentidad = new Panel();
            this.lblMarca = new Label();
            this.lblSistema = new Label();
            this.lblDireccion = new Label();
            this.lblInicio = new Label();
            this.lblInstruccion = new Label();
            this.lblUsuario = new Label();
            this.txtUsuario = new TextBox();
            this.lblClave = new Label();
            this.txtClave = new TextBox();
            this.chkRecordar = new CheckBox();
            this.btnIngresar = new Button();
            this.btnSalir = new Button();
            this.lblVista = new Label();
            this.cmbVista = new ComboBox();
            this.btnVistaPrevia = new Button();
            this.lblVersion = new Label();
            this.SuspendLayout();
            this.pnlIdentidad.SuspendLayout();

            this.pnlIdentidad.Location = new Point(0, 0);
            this.pnlIdentidad.Size = new Size(330, 480);
            this.pnlIdentidad.Name = "pnlIdentidad";
            this.pnlIdentidad.BackColor = Color.FromArgb(31, 58, 95);

            this.lblMarca.Location = new Point(30, 184);
            this.lblMarca.Size = new Size(270, 45);
            this.lblMarca.TextAlign = ContentAlignment.MiddleCenter;
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Text = "SIGVLP";
            this.lblMarca.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            this.lblMarca.ForeColor = Color.White;

            this.lblSistema.Location = new Point(30, 239);
            this.lblSistema.Size = new Size(270, 80);
            this.lblSistema.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSistema.Name = "lblSistema";
            this.lblSistema.Text = "Gestión de vacaciones, licencias y permisos policiales";
            this.lblSistema.Font = new Font("Segoe UI", 13F);
            this.lblSistema.ForeColor = Color.White;

            this.lblDireccion.Location = new Point(30, 425);
            this.lblDireccion.Size = new Size(270, 32);
            this.lblDireccion.TextAlign = ContentAlignment.MiddleCenter;
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Text = "Dirección de Recursos Humanos";
            this.lblDireccion.ForeColor = Color.FromArgb(222, 232, 244);

            this.lblInicio.Location = new Point(367, 36);
            this.lblInicio.Size = new Size(355, 46);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Text = "Iniciar sesión";
            this.lblInicio.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblInicio.ForeColor = Color.FromArgb(31, 58, 95);

            this.lblInstruccion.Location = new Point(369, 85);
            this.lblInstruccion.Size = new Size(350, 25);
            this.lblInstruccion.Name = "lblInstruccion";
            this.lblInstruccion.Text = "Ingrese sus credenciales para continuar";
            this.lblInstruccion.ForeColor = Color.FromArgb(76, 94, 117);

            this.lblUsuario.Location = new Point(369, 128);
            this.lblUsuario.Size = new Size(340, 22);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Text = "Usuario";

            this.txtUsuario.Location = new Point(399, 151);
            this.txtUsuario.Size = new Size(312, 27);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.TabIndex = 0;

            this.lblClave.Location = new Point(369, 191);
            this.lblClave.Size = new Size(340, 22);
            this.lblClave.Name = "lblClave";
            this.lblClave.Text = "Contraseña";

            this.txtClave.Location = new Point(399, 214);
            this.txtClave.Size = new Size(312, 27);
            this.txtClave.Name = "txtClave";
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.TabIndex = 1;

            this.chkRecordar.Location = new Point(369, 253);
            this.chkRecordar.Size = new Size(200, 26);
            this.chkRecordar.Name = "chkRecordar";
            this.chkRecordar.Text = "Recordar usuario";
            this.chkRecordar.TabIndex = 2;

            this.btnIngresar.Location = new Point(369, 291);
            this.btnIngresar.Size = new Size(204, 40);
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.BackColor = Color.FromArgb(31, 58, 95);
            this.btnIngresar.ForeColor = Color.White;
            this.btnIngresar.FlatStyle = FlatStyle.Flat;
            this.btnIngresar.TabIndex = 3;

            this.btnSalir.Location = new Point(588, 291);
            this.btnSalir.Size = new Size(123, 40);
            this.btnSalir.FlatStyle = FlatStyle.Flat;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Text = "Salir";
            this.btnSalir.TabIndex = 4;

            this.lblVista.Location = new Point(369, 389);
            this.lblVista.Size = new Size(106, 21);
            this.lblVista.Name = "lblVista";
            this.lblVista.Text = "Vista previa";
            this.lblVista.ForeColor = Color.FromArgb(76, 94, 117);

            this.cmbVista.Location = new Point(479, 384);
            this.cmbVista.Size = new Size(125, 27);
            this.cmbVista.Name = "cmbVista";
            this.cmbVista.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbVista.TabIndex = 5;

            this.btnVistaPrevia.Location = new Point(609, 383);
            this.btnVistaPrevia.Size = new Size(102, 29);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Text = "Abrir panel";
            this.btnVistaPrevia.TabIndex = 6;

            this.lblVersion.Location = new Point(369, 439);
            this.lblVersion.Size = new Size(345, 20);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Text = "v1.0 · Proyecto ISC-340";
            this.lblVersion.ForeColor = Color.FromArgb(76, 94, 117);
            this.cmbVista.Items.AddRange(new object[] { "Operador RRHH", "Administrador" });
            this.btnIngresar.Click += new System.EventHandler(this.Ingresar_Click);
            this.btnSalir.Click += new System.EventHandler(this.Salir_Click);
            this.btnVistaPrevia.Click += new System.EventHandler(this.VistaPrevia_Click);

            this.AutoScaleDimensions = new SizeF(96F, 96F);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.BackColor = Color.White;
            this.ClientSize = new Size(780, 480);
            this.Font = new Font("Segoe UI", 10F);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "frmLogin";
            this.Text = "Acceso al sistema";
            this.Controls.Add(this.pnlIdentidad);
            this.pnlIdentidad.Controls.Add(this.picEscudo);
            this.pnlIdentidad.Controls.Add(this.lblMarca);
            this.pnlIdentidad.Controls.Add(this.lblSistema);
            this.pnlIdentidad.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.lblInstruccion);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.chkRecordar);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblVista);
            this.Controls.Add(this.cmbVista);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.lblVersion);
            this.pnlIdentidad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
