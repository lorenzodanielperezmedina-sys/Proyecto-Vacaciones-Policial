namespace Presentacion
{
    partial class frmDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblEstadoAusencias = new System.Windows.Forms.Label();
            this.tlpIndicadores = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAusentesHoy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPendientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblReincorporaciones = new System.Windows.Forms.Label();
            this.lblPersonalActivo = new System.Windows.Forms.Label();
            this.tlpResumen = new System.Windows.Forms.TableLayoutPanel();
            this.grpVuelven = new System.Windows.Forms.GroupBox();
            this.grpAusencias = new System.Windows.Forms.GroupBox();
            this.colMiembro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiembro.Name = "colMiembro";
            this.colMiembro.HeaderText = "Miembro";
            this.colDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.HeaderText = "Departamento";
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo.Name = "colTipo";
            this.colTipo.HeaderText = "Tipo";
            this.colRegresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegresa.Name = "colRegresa";
            this.colRegresa.HeaderText = "Regresa";
            this.dgvVuelven = new System.Windows.Forms.DataGridView();
            this.chtTipos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tlpIndicadores.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tlpResumen.SuspendLayout();
            this.grpVuelven.SuspendLayout();
            this.grpAusencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelven)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpIndicadores
            // 
            this.tlpIndicadores.ColumnCount = 4;
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIndicadores.Controls.Add(this.panel1, 3, 0);
            this.tlpIndicadores.Controls.Add(this.panel2, 2, 0);
            this.tlpIndicadores.Controls.Add(this.panel3, 1, 0);
            this.tlpIndicadores.Controls.Add(this.panel4, 0, 0);
            this.tlpIndicadores.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpIndicadores.Padding = new System.Windows.Forms.Padding(12, 3, 12, 5);
            this.tlpIndicadores.Location = new System.Drawing.Point(0, 48);
            this.tlpIndicadores.Name = "tlpIndicadores";
            this.tlpIndicadores.RowCount = 1;
            this.tlpIndicadores.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpIndicadores.Size = new System.Drawing.Size(800, 100);
            this.tlpIndicadores.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(244, 246, 248);
            this.picIndicador4 = new System.Windows.Forms.PictureBox();
            this.picIndicador4.Name = "picIndicador4";
            this.picIndicador4.Image = ((System.Drawing.Image)(resources.GetObject("picIndicador4.Image")));
            this.picIndicador4.Location = new System.Drawing.Point(10, 24);
            this.picIndicador4.Size = new System.Drawing.Size(32, 32);
            this.picIndicador4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicador4.TabStop = false;
            this.panel1.Controls.Add(this.picIndicador4);
            this.panel1.Controls.Add(this.lblPersonalActivo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(606, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(244, 246, 248);
            this.picIndicador3 = new System.Windows.Forms.PictureBox();
            this.picIndicador3.Name = "picIndicador3";
            this.picIndicador3.Image = ((System.Drawing.Image)(resources.GetObject("picIndicador3.Image")));
            this.picIndicador3.Location = new System.Drawing.Point(10, 24);
            this.picIndicador3.Size = new System.Drawing.Size(32, 32);
            this.picIndicador3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicador3.TabStop = false;
            this.panel2.Controls.Add(this.picIndicador3);
            this.panel2.Controls.Add(this.lblReincorporaciones);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(406, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(188, 88);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(244, 246, 248);
            this.picIndicador2 = new System.Windows.Forms.PictureBox();
            this.picIndicador2.Name = "picIndicador2";
            this.picIndicador2.Image = ((System.Drawing.Image)(resources.GetObject("picIndicador2.Image")));
            this.picIndicador2.Location = new System.Drawing.Point(10, 24);
            this.picIndicador2.Size = new System.Drawing.Size(32, 32);
            this.picIndicador2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicador2.TabStop = false;
            this.panel3.Controls.Add(this.picIndicador2);
            this.panel3.Controls.Add(this.lblPendientes);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(206, 6);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(188, 88);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(244, 246, 248);
            this.picIndicador1 = new System.Windows.Forms.PictureBox();
            this.picIndicador1.Name = "picIndicador1";
            this.picIndicador1.Image = ((System.Drawing.Image)(resources.GetObject("picIndicador1.Image")));
            this.picIndicador1.Location = new System.Drawing.Point(10, 24);
            this.picIndicador1.Size = new System.Drawing.Size(32, 32);
            this.picIndicador1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIndicador1.TabStop = false;
            this.panel4.Controls.Add(this.picIndicador1);
            this.panel4.Controls.Add(this.lblAusentesHoy);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 94);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ausentes hoy";
            // 
            // lblAusentesHoy
            // 
            this.lblAusentesHoy.AutoSize = true;
            this.lblAusentesHoy.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAusentesHoy.Location = new System.Drawing.Point(49, 12);
            this.lblAusentesHoy.Name = "lblAusentesHoy";
            this.lblAusentesHoy.Size = new System.Drawing.Size(34, 46);
            this.lblAusentesHoy.TabIndex = 1;
            this.lblAusentesHoy.Text = "—";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solicitudes pendientes";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPendientes
            // 
            this.lblPendientes.AutoSize = true;
            this.lblPendientes.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendientes.Location = new System.Drawing.Point(49, 12);
            this.lblPendientes.Name = "lblPendientes";
            this.lblPendientes.Size = new System.Drawing.Size(34, 46);
            this.lblPendientes.TabIndex = 2;
            this.lblPendientes.Text = "—";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Regresan en 7 días";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Personal activo";
            // 
            // lblReincorporaciones
            // 
            this.lblReincorporaciones.AutoSize = true;
            this.lblReincorporaciones.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReincorporaciones.Location = new System.Drawing.Point(49, 12);
            this.lblReincorporaciones.Name = "lblReincorporaciones";
            this.lblReincorporaciones.Size = new System.Drawing.Size(34, 46);
            this.lblReincorporaciones.TabIndex = 3;
            this.lblReincorporaciones.Text = "—";
            // 
            // lblPersonalActivo
            // 
            this.lblPersonalActivo.AutoSize = true;
            this.lblPersonalActivo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonalActivo.Location = new System.Drawing.Point(49, 12);
            this.lblPersonalActivo.Name = "lblPersonalActivo";
            this.lblPersonalActivo.Size = new System.Drawing.Size(34, 46);
            this.lblPersonalActivo.TabIndex = 3;
            this.lblPersonalActivo.Text = "—";
            // 
            // tlpResumen
            // 
            this.tlpResumen.ColumnCount = 2;
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpResumen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpResumen.Controls.Add(this.grpVuelven, 0, 0);
            this.tlpResumen.Controls.Add(this.grpAusencias, 1, 0);
            this.tlpResumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpResumen.Location = new System.Drawing.Point(0, 148);
            this.tlpResumen.Name = "tlpResumen";
            this.tlpResumen.Padding = new System.Windows.Forms.Padding(12, 16, 12, 12);
            this.tlpResumen.RowCount = 1;
            this.tlpResumen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpResumen.Size = new System.Drawing.Size(800, 302);
            this.tlpResumen.TabIndex = 2;
            // 
            // grpVuelven
            // 
            this.grpVuelven.Controls.Add(this.dgvVuelven);
            this.grpVuelven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpVuelven.Location = new System.Drawing.Point(3, 23);
            this.grpVuelven.Name = "grpVuelven";
            this.grpVuelven.Size = new System.Drawing.Size(474, 276);
            this.grpVuelven.TabIndex = 0;
            this.grpVuelven.TabStop = false;
            this.grpVuelven.Text = "Vuelven esta semana";
            // 
            // grpAusencias
            // 
            this.grpAusencias.Controls.Add(this.lblEstadoAusencias);
            this.grpAusencias.Controls.Add(this.chtTipos);
            this.lblEstadoAusencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEstadoAusencias.BackColor = System.Drawing.Color.White;
            this.lblEstadoAusencias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstadoAusencias.Text = "Consulta de ausencias pendiente";
            this.lblEstadoAusencias.Name = "lblEstadoAusencias";
            this.grpAusencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpAusencias.Location = new System.Drawing.Point(483, 23);
            this.grpAusencias.Name = "grpAusencias";
            this.grpAusencias.Size = new System.Drawing.Size(314, 276);
            this.grpAusencias.TabIndex = 1;
            this.grpAusencias.TabStop = false;
            this.grpAusencias.Text = "Ausencias por tipo";
            // 
            // dgvVuelven
            // 
            this.dgvVuelven.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVuelven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVuelven.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colMiembro, this.colDepartamento, this.colTipo, this.colRegresa });
            this.dgvVuelven.EnableHeadersVisualStyles = false;
            this.dgvVuelven.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.dgvVuelven.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVuelven.BackgroundColor = System.Drawing.Color.White;
            this.dgvVuelven.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVuelven.ReadOnly = true;
            this.dgvVuelven.AllowUserToAddRows = false;
            this.dgvVuelven.AllowUserToDeleteRows = false;
            this.dgvVuelven.RowHeadersVisible = false;
            this.dgvVuelven.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVuelven.Location = new System.Drawing.Point(3, 18);
            this.dgvVuelven.Name = "dgvVuelven";
            this.dgvVuelven.RowHeadersWidth = 51;
            this.dgvVuelven.RowTemplate.Height = 24;
            this.dgvVuelven.Size = new System.Drawing.Size(468, 255);
            this.dgvVuelven.TabIndex = 0;
            // 
            // chtTipos
            // 
            chartArea2.Name = "ChartArea1";
            this.chtTipos.ChartAreas.Add(chartArea2);
            this.chtTipos.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chtTipos.Legends.Add(legend2);
            this.chtTipos.Location = new System.Drawing.Point(3, 18);
            this.chtTipos.Name = "chtTipos";



            this.chtTipos.Visible = false;
            this.chtTipos.Size = new System.Drawing.Size(308, 255);
            this.chtTipos.TabIndex = 0;
            this.chtTipos.Text = "chart1";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpResumen);
            this.Controls.Add(this.tlpIndicadores);
            this.lblBienvenida.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBienvenida.Height = 44;
            this.lblBienvenida.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Text = "Resumen de gestión";
            this.Controls.Add(this.lblBienvenida);
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitulo.Height = 40;
            this.lblTitulo.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Text = "Panel de control";
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmDashboard";
            this.Text = "Panel de control";
            this.tlpIndicadores.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tlpResumen.ResumeLayout(false);
            this.grpVuelven.ResumeLayout(false);
            this.grpAusencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVuelven)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtTipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picIndicador1;
        private System.Windows.Forms.PictureBox picIndicador2;
        private System.Windows.Forms.PictureBox picIndicador3;
        private System.Windows.Forms.PictureBox picIndicador4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiembro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegresa;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblEstadoAusencias;
        private System.Windows.Forms.TableLayoutPanel tlpIndicadores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAusentesHoy;
        private System.Windows.Forms.Label lblPersonalActivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblReincorporaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPendientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tlpResumen;
        private System.Windows.Forms.GroupBox grpVuelven;
        private System.Windows.Forms.GroupBox grpAusencias;
        private System.Windows.Forms.DataGridView dgvVuelven;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTipos;
    }
}