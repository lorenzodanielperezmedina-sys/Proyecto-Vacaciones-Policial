namespace Presentacion
{
    partial class frmmantenimientocatalogo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.TabControl tabCatalogos;
        private System.Windows.Forms.TabPage tabRangos;
        private System.Windows.Forms.TabPage tabDepartamentos;
        private System.Windows.Forms.TabPage tabCargos;
        private System.Windows.Forms.TabPage tabTiposAusencia;
        private System.Windows.Forms.TabPage tabFeriados;

        private System.Windows.Forms.DataGridView dgvCatalogo;
        private System.Windows.Forms.Panel pnlFormulario;
        private System.Windows.Forms.Label lblTituloFormulario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblDiasMaximos;
        private System.Windows.Forms.Label lblRequiereDocumento;

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.ComboBox cboDiasMaximos;
        private System.Windows.Forms.CheckBox chkRequiereDocumento;

        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;

        private System.Windows.Forms.Label lblNota;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.tabCatalogos = new System.Windows.Forms.TabControl();
            this.tabRangos = new System.Windows.Forms.TabPage();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.tabCargos = new System.Windows.Forms.TabPage();
            this.tabTiposAusencia = new System.Windows.Forms.TabPage();
            this.tabFeriados = new System.Windows.Forms.TabPage();

            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.pnlFormulario = new System.Windows.Forms.Panel();

            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblDiasMaximos = new System.Windows.Forms.Label();
            this.lblRequiereDocumento = new System.Windows.Forms.Label();

            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.cboDiasMaximos = new System.Windows.Forms.ComboBox();
            this.chkRequiereDocumento = new System.Windows.Forms.CheckBox();

            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();

            this.lblNota = new System.Windows.Forms.Label();

            this.tabCatalogos.SuspendLayout();
            this.tabTiposAusencia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).BeginInit();
            this.pnlFormulario.SuspendLayout();
            this.SuspendLayout();

            // 
            // tabCatalogos
            // 
            this.tabCatalogos.Controls.Add(this.tabRangos);
            this.tabCatalogos.Controls.Add(this.tabDepartamentos);
            this.tabCatalogos.Controls.Add(this.tabCargos);
            this.tabCatalogos.Controls.Add(this.tabTiposAusencia);
            this.tabCatalogos.Controls.Add(this.tabFeriados);

            this.tabCatalogos.Font = new System.Drawing.Font(
                "Segoe UI", 9F);

            this.tabCatalogos.Location = new System.Drawing.Point(18, 35);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.SelectedIndex = 3;
            this.tabCatalogos.Size = new System.Drawing.Size(1106, 477);
            this.tabCatalogos.TabIndex = 0;

            // 
            // Pestañas
            // 
            this.tabRangos.Text = "Rangos";
            this.tabRangos.UseVisualStyleBackColor = true;

            this.tabDepartamentos.Text = "Departamentos";
            this.tabDepartamentos.UseVisualStyleBackColor = true;

            this.tabCargos.Text = "Cargos";
            this.tabCargos.UseVisualStyleBackColor = true;

            this.tabTiposAusencia.Text = "Tipos de ausencia";
            this.tabTiposAusencia.UseVisualStyleBackColor = true;

            this.tabFeriados.Text = "Feriados";
            this.tabFeriados.UseVisualStyleBackColor = true;

            // 
            // tabTiposAusencia
            // 
            this.tabTiposAusencia.Controls.Add(this.dgvCatalogo);
            this.tabTiposAusencia.Controls.Add(this.pnlFormulario);

            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToResizeRows = false;
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogo.CellBorderStyle =
                System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvCatalogo.ColumnHeadersHeight = 25;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvCatalogo.EnableHeadersVisualStyles = false;
            this.dgvCatalogo.Location = new System.Drawing.Point(14, 15);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvCatalogo.Size = new System.Drawing.Size(488, 280);
            this.dgvCatalogo.TabIndex = 0;

            // 
            // Estilo de tabla
            // 
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(31, 58, 92);

            this.dgvCatalogo.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvCatalogo.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 8F,
                System.Drawing.FontStyle.Bold);

            this.dgvCatalogo.DefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI", 8F);

            this.dgvCatalogo.DefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(35, 35, 35);

            this.dgvCatalogo.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(207, 225, 245);

            this.dgvCatalogo.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.FromArgb(30, 30, 30);

            this.dgvCatalogo.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(244, 247, 250);

            this.dgvCatalogo.RowTemplate.Height = 27;

            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
            this.pnlFormulario.Location = new System.Drawing.Point(520, 15);
            this.pnlFormulario.Size = new System.Drawing.Size(560, 410);
            this.pnlFormulario.TabIndex = 1;

            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.Font = new System.Drawing.Font(
                "Segoe UI", 10F, System.Drawing.FontStyle.Bold);

            this.lblTituloFormulario.ForeColor =
                System.Drawing.Color.FromArgb(31, 58, 92);

            this.lblTituloFormulario.Location =
                new System.Drawing.Point(76, 20);

            this.lblTituloFormulario.Size = new System.Drawing.Size(250, 25);
            this.lblTituloFormulario.Text = "Tipo de ausencia";

            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(76, 56);
            this.lblNombre.Size = new System.Drawing.Size(100, 22);
            this.lblNombre.Text = "Nombre";

            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 53);
            this.txtNombre.Size = new System.Drawing.Size(185, 23);
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(76, 94);
            this.lblCategoria.Size = new System.Drawing.Size(100, 22);
            this.lblCategoria.Text = "Categoría";

            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboCategoria.Items.AddRange(new object[]
            {
                "Vacación",
                "Licencia",
                "Permiso"
            });

            this.cboCategoria.Location = new System.Drawing.Point(180, 91);
            this.cboCategoria.Size = new System.Drawing.Size(185, 23);

            // 
            // lblDiasMaximos
            // 
            this.lblDiasMaximos.Location = new System.Drawing.Point(76, 132);
            this.lblDiasMaximos.Size = new System.Drawing.Size(100, 22);
            this.lblDiasMaximos.Text = "Días máximos";

            // 
            // cboDiasMaximos
            // 
            this.cboDiasMaximos.DropDownStyle =
                System.Windows.Forms.ComboBoxStyle.DropDownList;

            this.cboDiasMaximos.Items.AddRange(new object[]
            {
                "1", "2", "3", "5", "7", "10", "15",
                "20", "30", "45", "60", "84", "90",
                "120", "180", "365"
            });

            this.cboDiasMaximos.Location =
                new System.Drawing.Point(180, 129);

            this.cboDiasMaximos.Size =
                new System.Drawing.Size(75, 23);

            // 
            // chkRequiereDocumento
            // 
            this.chkRequiereDocumento.Location =
                new System.Drawing.Point(180, 168);

            this.chkRequiereDocumento.Size =
                new System.Drawing.Size(185, 24);

            this.chkRequiereDocumento.Text = "Requiere documento";
            this.chkRequiereDocumento.Checked = false;

            // 
            // btnNuevo
            // 
            this.btnNuevo.Location =
                new System.Drawing.Point(76, 204);

            this.btnNuevo.Size = new System.Drawing.Size(80, 35);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.BackColor =
                System.Drawing.Color.FromArgb(31, 58, 92);

            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // 
            // btnGuardar
            // 
            this.btnGuardar.Location =
                new System.Drawing.Point(165, 204);

            this.btnGuardar.Size = new System.Drawing.Size(88, 35);
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.BackColor =
                System.Drawing.Color.FromArgb(46, 125, 50);

            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // 
            // btnEliminar
            // 
            this.btnEliminar.Location =
                new System.Drawing.Point(262, 204);

            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.BackColor =
                System.Drawing.Color.FromArgb(198, 40, 40);

            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font(
                "Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            // 
            // lblNota
            // 
            this.lblNota.Font = new System.Drawing.Font(
                "Segoe UI", 8F, System.Drawing.FontStyle.Italic);

            this.lblNota.ForeColor =
                System.Drawing.Color.FromArgb(100, 100, 100);

            this.lblNota.Location =
                new System.Drawing.Point(76, 250);

            this.lblNota.Size =
                new System.Drawing.Size(400, 50);

            this.lblNota.Text =
                "Un formulario base heredado sirve para Rangos, " +
                "Departamentos, Cargos y Feriados.";

            // 
            // Agregar controles al panel
            // 
            this.pnlFormulario.Controls.Add(this.lblTituloFormulario);
            this.pnlFormulario.Controls.Add(this.lblNombre);
            this.pnlFormulario.Controls.Add(this.txtNombre);
            this.pnlFormulario.Controls.Add(this.lblCategoria);
            this.pnlFormulario.Controls.Add(this.cboCategoria);
            this.pnlFormulario.Controls.Add(this.lblDiasMaximos);
            this.pnlFormulario.Controls.Add(this.cboDiasMaximos);
            this.pnlFormulario.Controls.Add(this.chkRequiereDocumento);
            this.pnlFormulario.Controls.Add(this.btnNuevo);
            this.pnlFormulario.Controls.Add(this.btnGuardar);
            this.pnlFormulario.Controls.Add(this.btnEliminar);
            this.pnlFormulario.Controls.Add(this.lblNota);

            // 
            // frmmantenimientocatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 524);

            this.Controls.Add(this.tabCatalogos);

            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(35, 35, 35);

            this.Name = "frmmantenimientocatalogo";
            this.Text = "Catálogos del sistema";

            this.StartPosition =
                System.Windows.Forms.FormStartPosition.CenterScreen;

            this.tabCatalogos.ResumeLayout(false);
            this.tabTiposAusencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}