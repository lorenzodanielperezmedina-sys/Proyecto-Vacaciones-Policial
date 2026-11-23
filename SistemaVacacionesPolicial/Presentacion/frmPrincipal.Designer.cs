namespace Presentacion
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrMensaje = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoDeVacacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaSolicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bandejaDeAprobaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausentesYReincorporacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saldoDeVacacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ausentesYReincorporacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevaSolicitud = new System.Windows.Forms.ToolStripButton();
            this.tsbPersonal = new System.Windows.Forms.ToolStripButton();
            this.tsbAusentesHoy = new System.Windows.Forms.ToolStripButton();
            this.tsbReportes = new System.Windows.Forms.ToolStripButton();
            this.tsbCambiarClave = new System.Windows.Forms.ToolStripButton();
            this.tsbCerrarSesion = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMensaje});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(31, 58, 95);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMensaje
            // 
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(40, 20);
            this.lblMensaje.ForeColor = System.Drawing.Color.White;
            this.lblMensaje.Text = "Listo";
            // 
            // tmrMensaje
            // 
            this.tmrMensaje.Interval = 4000;
            this.tmrMensaje.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.solicitudesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.administraciónToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem,
            this.saldoDeVacacionesToolStripMenuItem,
            this.saldoDeVacacionesToolStripMenuItem1});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // solicitudesToolStripMenuItem
            // 
            this.solicitudesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaSolicitudToolStripMenuItem,
            this.bandejaDeAprobaciónToolStripMenuItem});
            this.solicitudesToolStripMenuItem.Name = "solicitudesToolStripMenuItem";
            this.solicitudesToolStripMenuItem.Size = new System.Drawing.Size(95, 24);
            this.solicitudesToolStripMenuItem.Text = "Solicitudes";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausentesYReincorporacionesToolStripMenuItem1});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausentesYReincorporacionesToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // administraciónToolStripMenuItem
            // 
            this.administraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.bitácoraToolStripMenuItem});
            this.administraciónToolStripMenuItem.Name = "administraciónToolStripMenuItem";
            this.administraciónToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.administraciónToolStripMenuItem.Text = "Administración";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.catálogosToolStripMenuItem.Text = "Personal";
            this.catálogosToolStripMenuItem.Click += new System.EventHandler(this.catálogosToolStripMenuItem_Click);
            // 
            // saldoDeVacacionesToolStripMenuItem
            // 
            this.saldoDeVacacionesToolStripMenuItem.Name = "saldoDeVacacionesToolStripMenuItem";
            this.saldoDeVacacionesToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.saldoDeVacacionesToolStripMenuItem.Text = "Catálogos";
            // 
            // nuevaSolicitudToolStripMenuItem
            // 
            this.nuevaSolicitudToolStripMenuItem.Name = "nuevaSolicitudToolStripMenuItem";
            this.nuevaSolicitudToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.nuevaSolicitudToolStripMenuItem.Text = "Nueva solicitud";
            // 
            // bandejaDeAprobaciónToolStripMenuItem
            // 
            this.bandejaDeAprobaciónToolStripMenuItem.Name = "bandejaDeAprobaciónToolStripMenuItem";
            this.bandejaDeAprobaciónToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.bandejaDeAprobaciónToolStripMenuItem.Text = "Bandeja de aprobación";
            // 
            // ausentesYReincorporacionesToolStripMenuItem
            // 
            this.ausentesYReincorporacionesToolStripMenuItem.Name = "ausentesYReincorporacionesToolStripMenuItem";
            this.ausentesYReincorporacionesToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.ausentesYReincorporacionesToolStripMenuItem.Text = "\tReporte de ausencias";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // saldoDeVacacionesToolStripMenuItem1
            // 
            this.saldoDeVacacionesToolStripMenuItem1.Name = "saldoDeVacacionesToolStripMenuItem1";
            this.saldoDeVacacionesToolStripMenuItem1.Size = new System.Drawing.Size(227, 26);
            this.saldoDeVacacionesToolStripMenuItem1.Text = "Saldo de vacaciones";
            // 
            // ausentesYReincorporacionesToolStripMenuItem1
            // 
            this.ausentesYReincorporacionesToolStripMenuItem1.Name = "ausentesYReincorporacionesToolStripMenuItem1";
            this.ausentesYReincorporacionesToolStripMenuItem1.Size = new System.Drawing.Size(285, 26);
            this.ausentesYReincorporacionesToolStripMenuItem1.Text = "\tAusentes y reincorporaciones";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevaSolicitud,
            this.tsbPersonal,
            this.tsbAusentesHoy,
            this.tsbReportes,
            this.tsbCambiarClave,
            this.tsbCerrarSesion});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevaSolicitud
            // 
            this.tsbNuevaSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevaSolicitud.Image")));
            this.tsbNuevaSolicitud.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevaSolicitud.Name = "tsbNuevaSolicitud";
            this.tsbNuevaSolicitud.Size = new System.Drawing.Size(139, 28);
            this.tsbNuevaSolicitud.Text = "Nueva solicitud";
            // 
            // tsbPersonal
            // 
            this.tsbPersonal.Image = ((System.Drawing.Image)(resources.GetObject("tsbPersonal.Image")));
            this.tsbPersonal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPersonal.Name = "tsbPersonal";
            this.tsbPersonal.Size = new System.Drawing.Size(88, 24);
            this.tsbPersonal.Text = "Personal";
            // 
            // tsbAusentesHoy
            // 
            this.tsbAusentesHoy.Image = ((System.Drawing.Image)(resources.GetObject("tsbAusentesHoy.Image")));
            this.tsbAusentesHoy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAusentesHoy.Name = "tsbAusentesHoy";
            this.tsbAusentesHoy.Size = new System.Drawing.Size(120, 24);
            this.tsbAusentesHoy.Text = "Ausentes hoy";
            // 
            // tsbReportes
            // 
            this.tsbReportes.Image = ((System.Drawing.Image)(resources.GetObject("tsbReportes.Image")));
            this.tsbReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReportes.Name = "tsbReportes";
            this.tsbReportes.Size = new System.Drawing.Size(92, 24);
            this.tsbReportes.Text = "Reportes";
            // 
            // tsbCambiarClave
            // 
            this.tsbCambiarClave.Image = ((System.Drawing.Image)(resources.GetObject("tsbCambiarClave.Image")));
            this.tsbCambiarClave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCambiarClave.Name = "tsbCambiarClave";
            this.tsbCambiarClave.Size = new System.Drawing.Size(127, 24);
            this.tsbCambiarClave.Text = "Cambiar clave";
            // 
            // tsbCerrarSesion
            // 
            this.tsbCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("tsbCerrarSesion.Image")));
            this.tsbCerrarSesion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrarSesion.Name = "tsbCerrarSesion";
            this.tsbCerrarSesion.Size = new System.Drawing.Size(118, 24);
            this.tsbCerrarSesion.Text = "Cerrar sesión";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "SIGVLP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMensaje;
        private System.Windows.Forms.Timer tmrMensaje;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitudesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoDeVacacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaSolicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bandejaDeAprobaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausentesYReincorporacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saldoDeVacacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ausentesYReincorporacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNuevaSolicitud;
        private System.Windows.Forms.ToolStripButton tsbPersonal;
        private System.Windows.Forms.ToolStripButton tsbAusentesHoy;
        private System.Windows.Forms.ToolStripButton tsbReportes;
        private System.Windows.Forms.ToolStripButton tsbCambiarClave;
        private System.Windows.Forms.ToolStripButton tsbCerrarSesion;
    }
}