using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frmPrincipal : Form
    {
        private readonly string nombreUsuario;

        public frmPrincipal() : this(null, false) { }

        public frmPrincipal(string nombre, bool esAdministrador)
        {
            InitializeComponent();
            nombreUsuario = nombre;
            administraciónToolStripMenuItem.Visible = esAdministrador;
            usuariosToolStripMenuItem.Click += (s, e) => AbrirFormulario(() => new frmUsuarios());
            bitácoraToolStripMenuItem.Click += (s, e) => AbrirFormulario(() => new frmBitacora());
            tsbCambiarClave.Click += (s, e) => AbrirFormulario(() => new frmCambiarClave());
            tsbCerrarSesion.Click += (s, e) => Close();
        }
        // Muestra un mensaje en la barra inferior.
        public void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;
            tmrMensaje.Stop();
            tmrMensaje.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmrMensaje.Stop();
            lblMensaje.Text = "Listo";
        }

        private void catálogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmmantenimientoPersonal)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de mantenimiento de catalogo
            frmmantenimientoPersonal objmantenimientoPersonal = new frmmantenimientoPersonal();

            //Establecer el MDI parent 
            objmantenimientoPersonal.MdiParent = this;


            //Acceder al formulario de mantenimiento de catalogo
            objmantenimientoPersonal.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cierra la ventana principal.
            Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Muestra el nombre y la versión del sistema.
            MessageBox.Show(
                "SIGVLP v1.0\nGestión de Vacaciones, Licencias y Permisos\nProyecto ISC-340",
                "Acerca de",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        // Abre el panel de control dentro de la ventana principal.
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            AbrirFormulario(() => new frmDashboard(nombreUsuario));
        }

        private void AbrirFormulario<T>(Func<T> crear) where T : Form
        {
            T abierto = MdiChildren.OfType<T>().FirstOrDefault();
            if (abierto != null)
            {
                abierto.Activate();
                return;
            }

            T formulario = crear();
            formulario.MdiParent = this;
            formulario.WindowState = FormWindowState.Maximized;
            formulario.Show();
        }

        private void reporteDeAusenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsbNuevaSolicitud_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmNuevaSolicitud)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de Nueva Solicitud
            frmNuevaSolicitud objNuevaSolicitud = new frmNuevaSolicitud();

            //Establecer el MDI parent 
            objNuevaSolicitud.MdiParent = this;


            //Acceder al formulario de Nueva Solicitud
            objNuevaSolicitud.Show();
        }

        private void nuevaSolicitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmNuevaSolicitud)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de Nueva Solicitud
            frmNuevaSolicitud objNuevaSolicitud = new frmNuevaSolicitud();

            //Establecer el MDI parent 
            objNuevaSolicitud.MdiParent = this;


            //Acceder al formulario de Nueva Solicitud
            objNuevaSolicitud.Show();
        }

        private void bandejaDeAprobaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmBandejaAprobacion)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de Bandeja de Aprobacion
            frmBandejaAprobacion objBandejaAprobacion = new frmBandejaAprobacion();

            //Establecer el MDI parent 
            objBandejaAprobacion.MdiParent = this;


            //Acceder al formulario de bandeja de Aprobacion
            objBandejaAprobacion.Show();
        }

        private void tsbReportes_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmReporteAusencia)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de reporte de Ausencias
            frmReporteAusencia objReporteAusencia = new frmReporteAusencia();

            //Establecer el MDI parent 
            objReporteAusencia.MdiParent = this;


            //Acceder al formulario de reporte de Ausencias
            objReporteAusencia.Show();
        }

        private void saldoDeVacacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmmantenimientocatalogo)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de reporte de Ausencias
            frmmantenimientocatalogo objmantenimientocatalogo = new frmmantenimientocatalogo();

            //Establecer el MDI parent 
            objmantenimientocatalogo.MdiParent = this;


            //Acceder al formulario de reporte de Ausencias
            objmantenimientocatalogo.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form formulario in this.MdiChildren)
            {
                if (formulario is frmReporteAusencia)
                {
                    formulario.Activate();
                    return;
                }
            }

            //Crear Objeto del formulario de reporte de Ausencias
            frmReporteAusencia objReporteAusencia = new frmReporteAusencia();

            //Establecer el MDI parent 
            objReporteAusencia.MdiParent = this;


            //Acceder al formulario de reporte de Ausencias
            objReporteAusencia.Show();
        }

        private void saldoDeVacacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
