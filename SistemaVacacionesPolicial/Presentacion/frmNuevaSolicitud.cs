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
    public partial class frmNuevaSolicitud : Form
    {
        public frmNuevaSolicitud()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Limpiar errores anteriores
            errorProvider1.Clear();

            try
            {
                bool hayError = false;

                // Validar miembro
                //if (cmbMiembro.SelectedIndex == -1)
                //{
                    //errorProvider1.SetError(
                    //    cmbMiembro,
                    //    "Debe seleccionar un miembro.");

                   // hayError = true;
               // }

                // Validar tipo de ausencia
                if (cmbTipoAusencia.SelectedIndex == -1)
                {
                    errorProvider1.SetError(
                        cmbTipoAusencia,
                        "Debe seleccionar el tipo de ausencia.");

                    hayError = true;
                }

                // Validar fechas
                if (dtpFechaFin.Value.Date < dtpFechaInicio.Value.Date)
                {
                    errorProvider1.SetError(
                        dtpFechaFin,
                        "La fecha final no puede ser anterior a la inicial.");

                    hayError = true;
                }

                // Validar motivo
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    errorProvider1.SetError(
                        txtMotivo,
                        "Debe escribir el motivo de la solicitud.");

                    hayError = true;
                }

                // Si hay errores, detener el registro
                if (hayError)
                {
                    MessageBox.Show(
                        "Revise los campos marcados antes de continuar.",
                        "Error de validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Aqui debe guardar la solicitud en la base de datos.

                MessageBox.Show(
                    "Solicitud registrada correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al registrar la solicitud:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar los campos de selección
            cmbMiembro.SelectedIndex = -1;
            cmbTipoAusencia.SelectedIndex = -1;

            // Restablecer las fechas
            dtpFechaInicio.Value = DateTime.Today;
            dtpFechaFin.Value = DateTime.Today;

            
            txtMotivo.Clear();

            // Restablecer el resumen
            lbl.Text = "0";
            lbl3.Text = "0";
            lbl2.Text = "0";
            lbl1.Text = "0";
            lbl.Text = "";

            
            cmbMiembro.Focus();
        }
    }
    
}
