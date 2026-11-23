using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class frmUsuarios
    {
        private Label lblEncabezado;
        private TableLayoutPanel tlpUsuarios;
        private GroupBox grpListado;
        private FlowLayoutPanel flpAcciones;
        private DataGridView dgvUsuarios;
        private DataGridViewTextBoxColumn dgvUsuariosCol0;
        private DataGridViewTextBoxColumn dgvUsuariosCol1;
        private DataGridViewTextBoxColumn dgvUsuariosCol2;
        private DataGridViewTextBoxColumn dgvUsuariosCol3;
        private DataGridViewTextBoxColumn dgvUsuariosCol4;
        private Button btnNuevo;
        private Button btnEditar;
        private Button btnDesactivar;
        private GroupBox grpDatos;
        private Label lblUsuario;
        private TextBox campoUsuario;
        private Label lblNombre;
        private TextBox campoNombre;
        private Label lblRol;
        private ComboBox campoRol;
        private Label lblClave;
        private TextBox campoClave;
        private Label lblConfirmar;
        private TextBox campoConfirmar;
        private CheckBox chkActivo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblEstadoUsuarios;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.tlpUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.grpListado = new System.Windows.Forms.GroupBox();
            this.flpAcciones = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.dgvUsuariosCol0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuariosCol1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuariosCol2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuariosCol3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuariosCol4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.campoUsuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.campoNombre = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.campoRol = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.campoClave = new System.Windows.Forms.TextBox();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.campoConfirmar = new System.Windows.Forms.TextBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblEstadoUsuarios = new System.Windows.Forms.Label();
            this.tlpUsuarios.SuspendLayout();
            this.grpListado.SuspendLayout();
            this.flpAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblEncabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblEncabezado.ForeColor = System.Drawing.Color.White;
            this.lblEncabezado.Location = new System.Drawing.Point(0, 0);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.lblEncabezado.Size = new System.Drawing.Size(1000, 44);
            this.lblEncabezado.TabIndex = 1;
            this.lblEncabezado.Text = "Administración de usuarios";
            this.lblEncabezado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlpUsuarios
            // 
            this.tlpUsuarios.ColumnCount = 2;
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tlpUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tlpUsuarios.Controls.Add(this.grpListado, 0, 0);
            this.tlpUsuarios.Controls.Add(this.grpDatos, 1, 0);
            this.tlpUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpUsuarios.Location = new System.Drawing.Point(0, 44);
            this.tlpUsuarios.Name = "tlpUsuarios";
            this.tlpUsuarios.Padding = new System.Windows.Forms.Padding(18);
            this.tlpUsuarios.RowCount = 1;
            this.tlpUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpUsuarios.Size = new System.Drawing.Size(1000, 556);
            this.tlpUsuarios.TabIndex = 0;
            // 
            // grpListado
            // 
            this.grpListado.Controls.Add(this.flpAcciones);
            this.grpListado.Controls.Add(this.dgvUsuarios);
            this.grpListado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpListado.Location = new System.Drawing.Point(21, 21);
            this.grpListado.Name = "grpListado";
            this.grpListado.Padding = new System.Windows.Forms.Padding(12);
            this.grpListado.Size = new System.Drawing.Size(601, 514);
            this.grpListado.TabIndex = 0;
            this.grpListado.TabStop = false;
            this.grpListado.Text = "Usuarios del sistema";
            // 
            // flpAcciones
            // 
            this.flpAcciones.Controls.Add(this.btnNuevo);
            this.flpAcciones.Controls.Add(this.btnEditar);
            this.flpAcciones.Controls.Add(this.btnDesactivar);
            this.flpAcciones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flpAcciones.Location = new System.Drawing.Point(12, 458);
            this.flpAcciones.Name = "flpAcciones";
            this.flpAcciones.Size = new System.Drawing.Size(577, 44);
            this.flpAcciones.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.AutoSize = true;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.btnNuevo.Enabled = false;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(3, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 35);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = true;
            this.btnEditar.Enabled = false;
            this.btnEditar.Location = new System.Drawing.Point(84, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 33);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.AutoSize = true;
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDesactivar.Enabled = false;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.Location = new System.Drawing.Point(165, 3);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(100, 35);
            this.btnDesactivar.TabIndex = 2;
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuarios.ColumnHeadersHeight = 29;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUsuariosCol0,
            this.dgvUsuariosCol1,
            this.dgvUsuariosCol2,
            this.dgvUsuariosCol3,
            this.dgvUsuariosCol4});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(223)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuarios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(12, 35);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(577, 467);
            this.dgvUsuarios.TabIndex = 1;
            // 
            // dgvUsuariosCol0
            // 
            this.dgvUsuariosCol0.HeaderText = "Usuario";
            this.dgvUsuariosCol0.MinimumWidth = 6;
            this.dgvUsuariosCol0.Name = "dgvUsuariosCol0";
            this.dgvUsuariosCol0.ReadOnly = true;
            // 
            // dgvUsuariosCol1
            // 
            this.dgvUsuariosCol1.HeaderText = "Nombre";
            this.dgvUsuariosCol1.MinimumWidth = 6;
            this.dgvUsuariosCol1.Name = "dgvUsuariosCol1";
            this.dgvUsuariosCol1.ReadOnly = true;
            // 
            // dgvUsuariosCol2
            // 
            this.dgvUsuariosCol2.HeaderText = "Rol";
            this.dgvUsuariosCol2.MinimumWidth = 6;
            this.dgvUsuariosCol2.Name = "dgvUsuariosCol2";
            this.dgvUsuariosCol2.ReadOnly = true;
            // 
            // dgvUsuariosCol3
            // 
            this.dgvUsuariosCol3.HeaderText = "Estado";
            this.dgvUsuariosCol3.MinimumWidth = 6;
            this.dgvUsuariosCol3.Name = "dgvUsuariosCol3";
            this.dgvUsuariosCol3.ReadOnly = true;
            // 
            // dgvUsuariosCol4
            // 
            this.dgvUsuariosCol4.HeaderText = "Último acceso";
            this.dgvUsuariosCol4.MinimumWidth = 6;
            this.dgvUsuariosCol4.Name = "dgvUsuariosCol4";
            this.dgvUsuariosCol4.ReadOnly = true;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.grpDatos.Controls.Add(this.lblUsuario);
            this.grpDatos.Controls.Add(this.campoUsuario);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.campoNombre);
            this.grpDatos.Controls.Add(this.lblRol);
            this.grpDatos.Controls.Add(this.campoRol);
            this.grpDatos.Controls.Add(this.lblClave);
            this.grpDatos.Controls.Add(this.campoClave);
            this.grpDatos.Controls.Add(this.lblConfirmar);
            this.grpDatos.Controls.Add(this.campoConfirmar);
            this.grpDatos.Controls.Add(this.chkActivo);
            this.grpDatos.Controls.Add(this.btnGuardar);
            this.grpDatos.Controls.Add(this.btnCancelar);
            this.grpDatos.Controls.Add(this.lblEstadoUsuarios);
            this.grpDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDatos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.grpDatos.Location = new System.Drawing.Point(637, 21);
            this.grpDatos.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(342, 514);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del usuario";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblUsuario.Location = new System.Drawing.Point(16, 50);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(122, 22);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            // 
            // campoUsuario
            // 
            this.campoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campoUsuario.Enabled = false;
            this.campoUsuario.Location = new System.Drawing.Point(143, 47);
            this.campoUsuario.Name = "campoUsuario";
            this.campoUsuario.Size = new System.Drawing.Size(313, 30);
            this.campoUsuario.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblNombre.Location = new System.Drawing.Point(16, 96);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(122, 22);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre completo";
            // 
            // campoNombre
            // 
            this.campoNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campoNombre.Enabled = false;
            this.campoNombre.Location = new System.Drawing.Point(143, 93);
            this.campoNombre.Name = "campoNombre";
            this.campoNombre.Size = new System.Drawing.Size(313, 30);
            this.campoNombre.TabIndex = 3;
            // 
            // lblRol
            // 
            this.lblRol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblRol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblRol.Location = new System.Drawing.Point(16, 142);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(122, 22);
            this.lblRol.TabIndex = 4;
            this.lblRol.Text = "Rol";
            // 
            // campoRol
            // 
            this.campoRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campoRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoRol.Enabled = false;
            this.campoRol.Location = new System.Drawing.Point(143, 139);
            this.campoRol.Name = "campoRol";
            this.campoRol.Size = new System.Drawing.Size(313, 31);
            this.campoRol.TabIndex = 5;
            // 
            // lblClave
            // 
            this.lblClave.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblClave.Location = new System.Drawing.Point(16, 188);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(122, 22);
            this.lblClave.TabIndex = 6;
            this.lblClave.Text = "Contraseña";
            // 
            // campoClave
            // 
            this.campoClave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campoClave.Enabled = false;
            this.campoClave.Location = new System.Drawing.Point(143, 185);
            this.campoClave.Name = "campoClave";
            this.campoClave.Size = new System.Drawing.Size(313, 30);
            this.campoClave.TabIndex = 7;
            this.campoClave.UseSystemPasswordChar = true;
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblConfirmar.Location = new System.Drawing.Point(16, 234);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(122, 22);
            this.lblConfirmar.TabIndex = 8;
            this.lblConfirmar.Text = "Confirmar contraseña";
            // 
            // campoConfirmar
            // 
            this.campoConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.campoConfirmar.Enabled = false;
            this.campoConfirmar.Location = new System.Drawing.Point(143, 231);
            this.campoConfirmar.Name = "campoConfirmar";
            this.campoConfirmar.Size = new System.Drawing.Size(313, 30);
            this.campoConfirmar.TabIndex = 9;
            this.campoConfirmar.UseSystemPasswordChar = true;
            // 
            // chkActivo
            // 
            this.chkActivo.Enabled = false;
            this.chkActivo.Location = new System.Drawing.Point(16, 284);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(180, 25);
            this.chkActivo.TabIndex = 10;
            this.chkActivo.Text = "Usuario activo";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(16, 326);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(96, 32);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(120)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(127, 326);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 32);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lblEstadoUsuarios
            // 
            this.lblEstadoUsuarios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstadoUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.lblEstadoUsuarios.Location = new System.Drawing.Point(16, 375);
            this.lblEstadoUsuarios.Name = "lblEstadoUsuarios";
            this.lblEstadoUsuarios.Size = new System.Drawing.Size(256, 24);
            this.lblEstadoUsuarios.TabIndex = 13;
            this.lblEstadoUsuarios.Text = "Gestión pendiente de conexión";
            // 
            // frmUsuarios
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tlpUsuarios);
            this.Controls.Add(this.lblEncabezado);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "frmUsuarios";
            this.Text = "Administración de usuarios";
            this.tlpUsuarios.ResumeLayout(false);
            this.grpListado.ResumeLayout(false);
            this.flpAcciones.ResumeLayout(false);
            this.flpAcciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
