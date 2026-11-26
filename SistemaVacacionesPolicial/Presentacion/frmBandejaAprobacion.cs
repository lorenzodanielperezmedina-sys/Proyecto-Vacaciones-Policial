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
    public partial class frmBandejaAprobacion : Form
    {
        public frmBandejaAprobacion()
        {
            InitializeComponent();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void frmBandejaAprobacion_Load(object sender, EventArgs e)
        {

        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitud.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una solicitud.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea aprobar esta solicitud?",
                    "Confirmar aprobación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Aquí irá la actualización en SQL Server

                    MessageBox.Show("Solicitud aprobada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al aprobar la solicitud: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRechazar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSolicitud.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Seleccione una solicitud.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                DialogResult resultado = MessageBox.Show(
                    "¿Está seguro de que desea rechazar esta solicitud?",
                    "Confirmar rechazo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (resultado == DialogResult.Yes)
                {
                    // Aquí irá la actualización en SQL Server

                    MessageBox.Show("Solicitud rechazada correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rechazar la solicitud: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
