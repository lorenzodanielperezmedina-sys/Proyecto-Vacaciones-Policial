namespace Presentacion
{
    partial class frmmantenimientoPersonal
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.Label lblTitulo;

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cboFiltroDepartamento;
        private System.Windows.Forms.ComboBox cboFiltroEstado;

        private System.Windows.Forms.DataGridView dgvPersonal;

        private System.Windows.Forms.Panel pnlDatos;
        private System.Windows.Forms.Label lblDatosTitulo;

        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombres;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblCorreo;

        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cboRango;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.DateTimePicker dtpIngreso;
        private System.Windows.Forms.TextBox txtCorreo;

        private System.Windows.Forms.Label lblErrorCorreo;
        private System.Windows.Forms.Label lblTotalPersonal;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnDesactivar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();

            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cboFiltroDepartamento = new System.Windows.Forms.ComboBox();
            this.cboFiltroEstado = new System.Windows.Forms.ComboBox();

            this.dgvPersonal = new System.Windows.Forms.DataGridView();

            this.pnlDatos = new System.Windows.Forms.Panel();
            this.lblDatosTitulo = new System.Windows.Forms.Label();

            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombres = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblRango = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();

            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();

            this.cboRango = new System.Windows.Forms.ComboBox();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();

            this.dtpIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtCorreo = new System.Windows.Forms.TextBox();

            this.lblErrorCorreo = new System.Windows.Forms.Label();
            this.lblTotalPersonal = new System.Windows.Forms.Label();

            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnDesactivar = new System.Windows.Forms.Button();

            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.pnlDatos.SuspendLayout();
            this.SuspendLayout();

            // 
            // frmmantenimientoPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1082, 523);
            this.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ForeColor = System.Drawing.Color.FromArgb(35, 45, 55);
            this.MinimumSize = new System.Drawing.Size(1098, 562);
            this.Name = "frmmantenimientoPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de personal";

            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(45, 94, 143);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Height = 30;
            this.pnlSuperior.Controls.Add(this.lblTitulo);

            // 
            // lblTitulo
            // 
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitulo.Text = "Mantenimiento de personal";
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(14, 38);
            this.txtBuscar.Size = new System.Drawing.Size(260, 22);
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(90, 100, 115);
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Text = "";

            // 
            // cboFiltroDepartamento
            // 
            this.cboFiltroDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroDepartamento.Items.AddRange(new object[]
            {
                "Todos los departamentos"
            });
            this.cboFiltroDepartamento.Location = new System.Drawing.Point(286, 38);
            this.cboFiltroDepartamento.Size = new System.Drawing.Size(168, 22);
            this.cboFiltroDepartamento.Font = new System.Drawing.Font("Segoe UI", 8F);

            // 
            // cboFiltroEstado
            // 
            this.cboFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltroEstado.Items.AddRange(new object[]
            {
                "Activos",
                "Inactivos",
                "Todos"
            });
            this.cboFiltroEstado.Location = new System.Drawing.Point(468, 38);
            this.cboFiltroEstado.Size = new System.Drawing.Size(132, 22);
            this.cboFiltroEstado.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboFiltroEstado.SelectedIndex = 0;

            // 
            // dgvPersonal
            // 
            this.dgvPersonal.Location = new System.Drawing.Point(14, 72);
            this.dgvPersonal.Size = new System.Drawing.Size(577, 235);

            this.dgvPersonal.BackgroundColor = System.Drawing.Color.White;
            this.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvPersonal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AllowUserToResizeRows = false;
            this.dgvPersonal.AutoGenerateColumns = false;
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.RowHeadersVisible = false;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.EnableHeadersVisualStyles = false;

            this.dgvPersonal.ColumnHeadersHeight = 25;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPersonal.RowTemplate.Height = 27;

            this.dgvPersonal.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dgvPersonal.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 40, 50);
            this.dgvPersonal.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(207, 224, 243);
            this.dgvPersonal.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(30, 40, 50);

            this.dgvPersonal.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(243, 246, 250);

            this.dgvPersonal.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 92);
            this.dgvPersonal.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            this.dgvPersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                new System.Windows.Forms.DataGridViewTextBoxColumn()
                {
                    Name = "colCedula",
                    HeaderText = "Cédula",
                    Width = 110
                },
                new System.Windows.Forms.DataGridViewTextBoxColumn()
                {
                    Name = "colNombres",
                    HeaderText = "Nombres",
                    Width = 112
                },
                new System.Windows.Forms.DataGridViewTextBoxColumn()
                {
                    Name = "colApellidos",
                    HeaderText = "Apellidos",
                    Width = 116
                },
                new System.Windows.Forms.DataGridViewTextBoxColumn()
                {
                    Name = "colRango",
                    HeaderText = "Rango",
                    Width = 78
                },
                new System.Windows.Forms.DataGridViewTextBoxColumn()
                {
                    Name = "colDepartamento",
                    HeaderText = "Departamento",
                    Width = 95
                },
                new System.Windows.Forms.DataGridViewTextBoxColumn()
                {
                    Name = "colEstado",
                    HeaderText = "Estado",
                    Width = 65
                }
            });

            // 
            // lblTotalPersonal
            // 
            this.lblTotalPersonal.Location = new System.Drawing.Point(14, 319);
            this.lblTotalPersonal.Size = new System.Drawing.Size(400, 20);
            this.lblTotalPersonal.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblTotalPersonal.ForeColor = System.Drawing.Color.FromArgb(95, 105, 120);
            this.lblTotalPersonal.Text = "Mostrando miembros";

            // 
            // pnlDatos
            // 
            this.pnlDatos.Location = new System.Drawing.Point(606, 38);
            this.pnlDatos.Size = new System.Drawing.Size(270, 397);
            this.pnlDatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatos.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);

            // 
            // lblDatosTitulo
            // 
            this.lblDatosTitulo.Location = new System.Drawing.Point(12, 12);
            this.lblDatosTitulo.Size = new System.Drawing.Size(240, 22);
            this.lblDatosTitulo.Text = "Datos del miembro";
            this.lblDatosTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDatosTitulo.ForeColor = System.Drawing.Color.FromArgb(31, 58, 92);

            // 
            // Labels
            // 
            this.lblCedula.Text = "Cédula";
            this.lblCedula.SetBounds(12, 43, 75, 22);

            this.lblNombres.Text = "Nombres";
            this.lblNombres.SetBounds(12, 70, 75, 22);

            this.lblApellidos.Text = "Apellidos";
            this.lblApellidos.SetBounds(12, 97, 75, 22);

            this.lblRango.Text = "Rango";
            this.lblRango.SetBounds(12, 124, 75, 22);

            this.lblDepartamento.Text = "Departamento";
            this.lblDepartamento.SetBounds(12, 151, 75, 22);

            this.lblCargo.Text = "Cargo";
            this.lblCargo.SetBounds(12, 178, 75, 22);

            this.lblIngreso.Text = "Ingreso";
            this.lblIngreso.SetBounds(12, 205, 75, 22);

            this.lblCorreo.Text = "Correo";
            this.lblCorreo.SetBounds(12, 232, 75, 22);

            // 
            // txtCedula
            // 
            this.txtCedula.SetBounds(89, 40, 192, 23);
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // txtNombres
            // 
            this.txtNombres.SetBounds(89, 67, 192, 23);
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // txtApellidos
            // 
            this.txtApellidos.SetBounds(89, 94, 192, 23);
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // cboRango
            // 
            this.cboRango.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRango.SetBounds(89, 121, 192, 23);

            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.SetBounds(89, 148, 192, 23);

            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.SetBounds(89, 175, 192, 23);

            // 
            // dtpIngreso
            // 
            this.dtpIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIngreso.SetBounds(89, 202, 192, 23);
            this.dtpIngreso.Font = new System.Drawing.Font("Segoe UI", 8F);

            // 
            // txtCorreo
            // 
            this.txtCorreo.SetBounds(89, 229, 192, 23);
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.SetBounds(89, 252, 192, 15);
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.lblErrorCorreo.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.lblErrorCorreo.Text = "";
            this.lblErrorCorreo.Visible = false;

            // 
            // btnNuevo
            // 
            this.btnNuevo.SetBounds(12, 269, 75, 32);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(31, 58, 92);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // 
            // btnGuardar
            // 
            this.btnGuardar.SetBounds(94, 269, 82, 32);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // 
            // btnDesactivar
            // 
            this.btnDesactivar.SetBounds(183, 269, 75, 32);
            this.btnDesactivar.Text = "Desactivar";
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // 
            // Agregar controles al panel de datos
            // 
            this.pnlDatos.Controls.Add(this.lblDatosTitulo);

            this.pnlDatos.Controls.Add(this.lblCedula);
            this.pnlDatos.Controls.Add(this.lblNombres);
            this.pnlDatos.Controls.Add(this.lblApellidos);
            this.pnlDatos.Controls.Add(this.lblRango);
            this.pnlDatos.Controls.Add(this.lblDepartamento);
            this.pnlDatos.Controls.Add(this.lblCargo);
            this.pnlDatos.Controls.Add(this.lblIngreso);
            this.pnlDatos.Controls.Add(this.lblCorreo);

            this.pnlDatos.Controls.Add(this.txtCedula);
            this.pnlDatos.Controls.Add(this.txtNombres);
            this.pnlDatos.Controls.Add(this.txtApellidos);

            this.pnlDatos.Controls.Add(this.cboRango);
            this.pnlDatos.Controls.Add(this.cboDepartamento);
            this.pnlDatos.Controls.Add(this.cboCargo);

            this.pnlDatos.Controls.Add(this.dtpIngreso);
            this.pnlDatos.Controls.Add(this.txtCorreo);
            this.pnlDatos.Controls.Add(this.lblErrorCorreo);

            this.pnlDatos.Controls.Add(this.btnNuevo);
            this.pnlDatos.Controls.Add(this.btnGuardar);
            this.pnlDatos.Controls.Add(this.btnDesactivar);

            // 
            // Agregar controles al formulario
            // 
            this.Controls.Add(this.pnlSuperior);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboFiltroDepartamento);
            this.Controls.Add(this.cboFiltroEstado);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.lblTotalPersonal);
            this.Controls.Add(this.pnlDatos);

            this.pnlSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.pnlDatos.ResumeLayout(false);
            this.pnlDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}