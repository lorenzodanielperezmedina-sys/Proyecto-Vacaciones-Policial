namespace Presentacion
{
    partial class frmReporteAusencia
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridView dgvAusencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVacaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLicencias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPermisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAusencias;
        private System.Windows.Forms.Label lblPeriodo;
        private System.Windows.Forms.Label lblProgreso;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series serieVacaciones = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series serieLicencias = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series seriePermisos = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title chartTitle = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle alternatingStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporteAusencia));
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.dgvAusencias = new System.Windows.Forms.DataGridView();
            this.colDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVacaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLicencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPermisos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartAusencias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.lblProgreso = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAusencias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAusencias)).BeginInit();
            this.SuspendLayout();
            // 
            // Labels de filtros
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDesde.ForeColor = System.Drawing.Color.FromArgb(31, 48, 73);
            this.lblDesde.Location = new System.Drawing.Point(14, 42);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(36, 13);
            this.lblDesde.TabIndex = 0;
            this.lblDesde.Text = "Desde";
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblHasta.ForeColor = System.Drawing.Color.FromArgb(31, 48, 73);
            this.lblHasta.Location = new System.Drawing.Point(207, 42);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(35, 13);
            this.lblHasta.TabIndex = 1;
            this.lblHasta.Text = "Hasta";
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblDepartamento.ForeColor = System.Drawing.Color.FromArgb(31, 48, 73);
            this.lblDepartamento.Location = new System.Drawing.Point(329, 42);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(75, 13);
            this.lblDepartamento.TabIndex = 2;
            this.lblDepartamento.Text = "Departamento";
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(31, 48, 73);
            this.lblTipo.Location = new System.Drawing.Point(550, 42);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.Location = new System.Drawing.Point(58, 38);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(135, 22);
            this.dtpDesde.TabIndex = 4;
            this.dtpDesde.Value = new System.DateTime(2026, 11, 1, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpHasta.Location = new System.Drawing.Point(249, 38);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(102, 22);
            this.dtpHasta.TabIndex = 5;
            this.dtpHasta.Value = new System.DateTime(2026, 11, 30, 0, 0, 0, 0);
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] { "Todos", "Operaciones", "Investigaciones", "Tránsito", "Administración" });
            this.cboDepartamento.Location = new System.Drawing.Point(408, 38);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(127, 21);
            this.cboDepartamento.TabIndex = 6;
            this.cboDepartamento.SelectedIndex = 0;
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] { "Todos", "Vacaciones", "Licencias", "Permisos" });
            this.cboTipo.Location = new System.Drawing.Point(582, 38);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(126, 21);
            this.cboTipo.TabIndex = 7;
            this.cboTipo.SelectedIndex = 0;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.FromArgb(31, 58, 94);
            this.btnGenerar.FlatAppearance.BorderSize = 0;
            this.btnGenerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.ForeColor = System.Drawing.Color.White;
            this.btnGenerar.Location = new System.Drawing.Point(729, 37);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(105, 25);
            this.btnGenerar.TabIndex = 8;
            this.btnGenerar.Text = "▶   Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            // 
            // dgvAusencias
            // 
            this.dgvAusencias.AllowUserToAddRows = false;
            this.dgvAusencias.AllowUserToDeleteRows = false;
            this.dgvAusencias.AllowUserToResizeRows = false;
            this.dgvAusencias.BackgroundColor = System.Drawing.Color.White;
            this.dgvAusencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvAusencias.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAusencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(31, 58, 94);
            headerStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.White;
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(31, 58, 94);
            headerStyle.SelectionForeColor = System.Drawing.Color.White;
            headerStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAusencias.ColumnHeadersDefaultCellStyle = headerStyle;
            this.dgvAusencias.ColumnHeadersHeight = 25;
            this.dgvAusencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAusencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colDepartamento, this.colVacaciones, this.colLicencias, this.colPermisos, this.colTotal});
            alternatingStyle.BackColor = System.Drawing.Color.FromArgb(242, 245, 249);
            this.dgvAusencias.AlternatingRowsDefaultCellStyle = alternatingStyle;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 8F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(35, 43, 54);
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(224, 235, 247);
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(35, 43, 54);
            this.dgvAusencias.DefaultCellStyle = cellStyle;
            this.dgvAusencias.EnableHeadersVisualStyles = false;
            this.dgvAusencias.GridColor = System.Drawing.Color.FromArgb(220, 226, 234);
            this.dgvAusencias.Location = new System.Drawing.Point(14, 75);
            this.dgvAusencias.MultiSelect = false;
            this.dgvAusencias.Name = "dgvAusencias";
            this.dgvAusencias.ReadOnly = true;
            this.dgvAusencias.RowHeadersVisible = false;
            this.dgvAusencias.RowTemplate.Height = 27;
            this.dgvAusencias.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvAusencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAusencias.Size = new System.Drawing.Size(430, 166);
            this.dgvAusencias.TabIndex = 9;
            this.dgvAusencias.Rows.Add("Operaciones", "14", "3", "5", "22");
            this.dgvAusencias.Rows.Add("Investigaciones", "9", "5", "3", "17");
            this.dgvAusencias.Rows.Add("Tránsito", "11", "2", "4", "17");
            this.dgvAusencias.Rows.Add("Administración", "6", "4", "2", "12");
            this.dgvAusencias.Rows.Add("Total", "40", "14", "14", "68");
            // 
            // Columnas de la tabla
            // 
            this.colDepartamento.HeaderText = "Departamento";
            this.colDepartamento.Name = "colDepartamento";
            this.colDepartamento.ReadOnly = true;
            this.colDepartamento.Width = 150;
            this.colVacaciones.HeaderText = "Vacaciones";
            this.colVacaciones.Name = "colVacaciones";
            this.colVacaciones.ReadOnly = true;
            this.colVacaciones.Width = 70;
            this.colLicencias.HeaderText = "Licencias";
            this.colLicencias.Name = "colLicencias";
            this.colLicencias.ReadOnly = true;
            this.colLicencias.Width = 70;
            this.colPermisos.HeaderText = "Permisos";
            this.colPermisos.Name = "colPermisos";
            this.colPermisos.ReadOnly = true;
            this.colPermisos.Width = 70;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 68;
            // 
            // chartAusencias
            // 
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            chartArea.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(45, 52, 62);
            chartArea.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.Interval = 2;
            chartArea.AxisY.Minimum = 0D;
            chartArea.AxisY.Maximum = 16D;
            chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            chartArea.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(45, 52, 62);
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(215, 222, 231);
            chartArea.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea.BackColor = System.Drawing.Color.White;
            chartArea.Position.Auto = false;
            chartArea.Position.X = 4F;
            chartArea.Position.Y = 8F;
            chartArea.Position.Width = 93F;
            chartArea.Position.Height = 77F;
            chartArea.InnerPlotPosition.Auto = false;
            chartArea.InnerPlotPosition.X = 8F;
            chartArea.InnerPlotPosition.Y = 4F;
            chartArea.InnerPlotPosition.Width = 88F;
            chartArea.InnerPlotPosition.Height = 82F;
            this.chartAusencias.BackColor = System.Drawing.Color.White;
            this.chartAusencias.ChartAreas.Add(chartArea);
            legend.Alignment = System.Drawing.StringAlignment.Center;
            legend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            legend.IsTextAutoFit = false;
            legend.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend.BackColor = System.Drawing.Color.White;
            this.chartAusencias.Legends.Add(legend);
            this.chartAusencias.Location = new System.Drawing.Point(469, 70);
            this.chartAusencias.Name = "chartAusencias";
            this.chartAusencias.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartAusencias.PaletteCustomColors = new System.Drawing.Color[] {
                System.Drawing.Color.FromArgb(25, 118, 210),
                System.Drawing.Color.FromArgb(31, 58, 94),
                System.Drawing.Color.FromArgb(232, 164, 29)};
            serieVacaciones.ChartArea = chartArea.Name;
            serieVacaciones.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            serieVacaciones.IsValueShownAsLabel = true;
            serieVacaciones.LabelForeColor = System.Drawing.Color.FromArgb(45, 52, 62);
            serieVacaciones.Font = new System.Drawing.Font("Segoe UI", 7F);
            serieVacaciones.Legend = legend.Name;
            serieVacaciones.Name = "Vacaciones";
            serieVacaciones.Points.AddXY("Operaciones", 14);
            serieVacaciones.Points.AddXY("Investigaciones", 9);
            serieVacaciones.Points.AddXY("Tránsito", 11);
            serieVacaciones.Points.AddXY("Administración", 6);
            serieLicencias.ChartArea = chartArea.Name;
            serieLicencias.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            serieLicencias.IsValueShownAsLabel = true;
            serieLicencias.LabelForeColor = System.Drawing.Color.FromArgb(45, 52, 62);
            serieLicencias.Font = new System.Drawing.Font("Segoe UI", 7F);
            serieLicencias.Legend = legend.Name;
            serieLicencias.Name = "Licencias";
            serieLicencias.Points.AddXY("Operaciones", 3);
            serieLicencias.Points.AddXY("Investigaciones", 5);
            serieLicencias.Points.AddXY("Tránsito", 2);
            serieLicencias.Points.AddXY("Administración", 4);
            seriePermisos.ChartArea = chartArea.Name;
            seriePermisos.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriePermisos.IsValueShownAsLabel = true;
            seriePermisos.LabelForeColor = System.Drawing.Color.FromArgb(45, 52, 62);
            seriePermisos.Font = new System.Drawing.Font("Segoe UI", 7F);
            seriePermisos.Legend = legend.Name;
            seriePermisos.Name = "Permisos";
            seriePermisos.Points.AddXY("Operaciones", 5);
            seriePermisos.Points.AddXY("Investigaciones", 3);
            seriePermisos.Points.AddXY("Tránsito", 4);
            seriePermisos.Points.AddXY("Administración", 2);
            this.chartAusencias.Series.Add(serieVacaciones);
            this.chartAusencias.Series.Add(serieLicencias);
            this.chartAusencias.Series.Add(seriePermisos);
            chartTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartTitle.ForeColor = System.Drawing.Color.FromArgb(31, 58, 94);
            chartTitle.Text = "Días de ausencia por departamento";
            this.chartAusencias.Titles.Add(chartTitle);
            this.chartAusencias.Size = new System.Drawing.Size(407, 211);
            this.chartAusencias.TabIndex = 10;
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.AutoSize = true;
            this.lblPeriodo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblPeriodo.ForeColor = System.Drawing.Color.FromArgb(66, 82, 110);
            this.lblPeriodo.Location = new System.Drawing.Point(14, 258);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(171, 13);
            this.lblPeriodo.TabIndex = 11;
            this.lblPeriodo.Text = "Días de ausencia, noviembre de 2026";
            // 
            // lblProgreso
            // 
            this.lblProgreso.AutoSize = true;
            this.lblProgreso.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lblProgreso.ForeColor = System.Drawing.Color.FromArgb(31, 48, 73);
            this.lblProgreso.Location = new System.Drawing.Point(14, 310);
            this.lblProgreso.Name = "lblProgreso";
            this.lblProgreso.Size = new System.Drawing.Size(48, 13);
            this.lblProgreso.TabIndex = 12;
            this.lblProgreso.Text = "Progreso";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(74, 307);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(326, 12);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 13;
            this.progressBar.Value = 100;
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lblPorcentaje.ForeColor = System.Drawing.Color.FromArgb(35, 43, 54);
            this.lblPorcentaje.Location = new System.Drawing.Point(407, 306);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(31, 13);
            this.lblPorcentaje.TabIndex = 14;
            this.lblPorcentaje.Text = "100 %";
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Location = new System.Drawing.Point(617, 298);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(125, 29);
            this.btnExportar.TabIndex = 15;
            this.btnExportar.Text = "▣   Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(31, 58, 94);
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(753, 298);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(108, 29);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "▣   Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // frmReporteAusencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(886, 340);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.lblProgreso);
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.chartAusencias);
            this.Controls.Add(this.dgvAusencias);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.cboDepartamento);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblDepartamento);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "frmReporteAusencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de ausencias por departamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAusencias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAusencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
