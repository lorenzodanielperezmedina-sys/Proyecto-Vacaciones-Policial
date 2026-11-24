
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabCatalogos = new System.Windows.Forms.TabControl();
            this.tabRangos = new System.Windows.Forms.TabPage();
            this.tabDepartamentos = new System.Windows.Forms.TabPage();
            this.tabCargos = new System.Windows.Forms.TabPage();
            this.tabTiposAusencia = new System.Windows.Forms.TabPage();
            this.dgvCatalogo = new System.Windows.Forms.DataGridView();
            this.pnlFormulario = new System.Windows.Forms.Panel();
            this.lblTituloFormulario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblDiasMaximos = new System.Windows.Forms.Label();
            this.cboDiasMaximos = new System.Windows.Forms.ComboBox();
            this.chkRequiereDocumento = new System.Windows.Forms.CheckBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblNota = new System.Windows.Forms.Label();
            this.tabFeriados = new System.Windows.Forms.TabPage();
            this.lblRequiereDocumento = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiasMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Requiedocmento = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabCatalogos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tabCatalogos.Location = new System.Drawing.Point(18, 35);
            this.tabCatalogos.Name = "tabCatalogos";
            this.tabCatalogos.SelectedIndex = 3;
            this.tabCatalogos.Size = new System.Drawing.Size(1106, 477);
            this.tabCatalogos.TabIndex = 0;
            // 
            // tabRangos
            // 
            this.tabRangos.Location = new System.Drawing.Point(4, 24);
            this.tabRangos.Name = "tabRangos";
            this.tabRangos.Size = new System.Drawing.Size(1098, 449);
            this.tabRangos.TabIndex = 0;
            this.tabRangos.Text = "Rangos";
            this.tabRangos.UseVisualStyleBackColor = true;
            // 
            // tabDepartamentos
            // 
            this.tabDepartamentos.Location = new System.Drawing.Point(4, 24);
            this.tabDepartamentos.Name = "tabDepartamentos";
            this.tabDepartamentos.Size = new System.Drawing.Size(1098, 449);
            this.tabDepartamentos.TabIndex = 1;
            this.tabDepartamentos.Text = "Departamentos";
            this.tabDepartamentos.UseVisualStyleBackColor = true;
            // 
            // tabCargos
            // 
            this.tabCargos.Location = new System.Drawing.Point(4, 24);
            this.tabCargos.Name = "tabCargos";
            this.tabCargos.Size = new System.Drawing.Size(1098, 449);
            this.tabCargos.TabIndex = 2;
            this.tabCargos.Text = "Cargos";
            this.tabCargos.UseVisualStyleBackColor = true;
            // 
            // tabTiposAusencia
            // 
            this.tabTiposAusencia.Controls.Add(this.dgvCatalogo);
            this.tabTiposAusencia.Controls.Add(this.pnlFormulario);
            this.tabTiposAusencia.Location = new System.Drawing.Point(4, 24);
            this.tabTiposAusencia.Name = "tabTiposAusencia";
            this.tabTiposAusencia.Size = new System.Drawing.Size(1098, 449);
            this.tabTiposAusencia.TabIndex = 3;
            this.tabTiposAusencia.Text = "Tipos de ausencia";
            this.tabTiposAusencia.UseVisualStyleBackColor = true;
            // 
            // dgvCatalogo
            // 
            this.dgvCatalogo.AllowUserToAddRows = false;
            this.dgvCatalogo.AllowUserToDeleteRows = false;
            this.dgvCatalogo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvCatalogo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCatalogo.BackgroundColor = System.Drawing.Color.White;
            this.dgvCatalogo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCatalogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCatalogo.ColumnHeadersHeight = 25;
            this.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.Categoria,
            this.DiasMax,
            this.Requiedocmento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(225)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCatalogo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCatalogo.EnableHeadersVisualStyles = false;
            this.dgvCatalogo.Location = new System.Drawing.Point(14, 15);
            this.dgvCatalogo.MultiSelect = false;
            this.dgvCatalogo.Name = "dgvCatalogo";
            this.dgvCatalogo.ReadOnly = true;
            this.dgvCatalogo.RowHeadersVisible = false;
            this.dgvCatalogo.RowTemplate.Height = 27;
            this.dgvCatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogo.Size = new System.Drawing.Size(488, 410);
            this.dgvCatalogo.TabIndex = 0;
            // 
            // pnlFormulario
            // 
            this.pnlFormulario.BackColor = System.Drawing.Color.White;
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
            this.pnlFormulario.Location = new System.Drawing.Point(520, 15);
            this.pnlFormulario.Name = "pnlFormulario";
            this.pnlFormulario.Size = new System.Drawing.Size(560, 410);
            this.pnlFormulario.TabIndex = 1;
            // 
            // lblTituloFormulario
            // 
            this.lblTituloFormulario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTituloFormulario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.lblTituloFormulario.Location = new System.Drawing.Point(76, 20);
            this.lblTituloFormulario.Name = "lblTituloFormulario";
            this.lblTituloFormulario.Size = new System.Drawing.Size(250, 25);
            this.lblTituloFormulario.TabIndex = 0;
            this.lblTituloFormulario.Text = "Tipo de ausencia";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(76, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 22);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(180, 53);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 23);
            this.txtNombre.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.Location = new System.Drawing.Point(76, 94);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(100, 22);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoría";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Items.AddRange(new object[] {
            "Vacación",
            "Licencia",
            "Permiso"});
            this.cboCategoria.Location = new System.Drawing.Point(180, 91);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(185, 23);
            this.cboCategoria.TabIndex = 4;
            // 
            // lblDiasMaximos
            // 
            this.lblDiasMaximos.Location = new System.Drawing.Point(76, 132);
            this.lblDiasMaximos.Name = "lblDiasMaximos";
            this.lblDiasMaximos.Size = new System.Drawing.Size(100, 22);
            this.lblDiasMaximos.TabIndex = 5;
            this.lblDiasMaximos.Text = "Días máximos";
            // 
            // cboDiasMaximos
            // 
            this.cboDiasMaximos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDiasMaximos.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "5",
            "7",
            "10",
            "15",
            "20",
            "30",
            "45",
            "60",
            "84",
            "90",
            "120",
            "180",
            "365"});
            this.cboDiasMaximos.Location = new System.Drawing.Point(180, 129);
            this.cboDiasMaximos.Name = "cboDiasMaximos";
            this.cboDiasMaximos.Size = new System.Drawing.Size(75, 23);
            this.cboDiasMaximos.TabIndex = 6;
            // 
            // chkRequiereDocumento
            // 
            this.chkRequiereDocumento.Location = new System.Drawing.Point(180, 168);
            this.chkRequiereDocumento.Name = "chkRequiereDocumento";
            this.chkRequiereDocumento.Size = new System.Drawing.Size(185, 24);
            this.chkRequiereDocumento.TabIndex = 7;
            this.chkRequiereDocumento.Text = "Requiere documento";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(92)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(76, 204);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(80, 35);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(165, 204);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(88, 35);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(262, 204);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(88, 35);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // lblNota
            // 
            this.lblNota.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblNota.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblNota.Location = new System.Drawing.Point(76, 250);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(400, 50);
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "Un formulario base heredado sirve para Rangos, Departamentos, Cargos y Feriados.";
            // 
            // tabFeriados
            // 
            this.tabFeriados.Location = new System.Drawing.Point(4, 24);
            this.tabFeriados.Name = "tabFeriados";
            this.tabFeriados.Size = new System.Drawing.Size(1098, 449);
            this.tabFeriados.TabIndex = 4;
            this.tabFeriados.Text = "Feriados";
            this.tabFeriados.UseVisualStyleBackColor = true;
            // 
            // lblRequiereDocumento
            // 
            this.lblRequiereDocumento.Location = new System.Drawing.Point(0, 0);
            this.lblRequiereDocumento.Name = "lblRequiereDocumento";
            this.lblRequiereDocumento.Size = new System.Drawing.Size(100, 23);
            this.lblRequiereDocumento.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // DiasMax
            // 
            this.DiasMax.HeaderText = "Dias Max";
            this.DiasMax.Name = "DiasMax";
            this.DiasMax.ReadOnly = true;
            // 
            // Requiedocmento
            // 
            this.Requiedocmento.HeaderText = "Requiere Documento";
            this.Requiedocmento.Name = "Requiedocmento";
            this.Requiedocmento.ReadOnly = true;
            this.Requiedocmento.Width = 150;
            // 
            // frmmantenimientocatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1142, 524);
            this.Controls.Add(this.tabCatalogos);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Name = "frmmantenimientocatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogos del sistema";
            this.tabCatalogos.ResumeLayout(false);
            this.tabTiposAusencia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogo)).EndInit();
            this.pnlFormulario.ResumeLayout(false);
            this.pnlFormulario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiasMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Requiedocmento;
    }
}
