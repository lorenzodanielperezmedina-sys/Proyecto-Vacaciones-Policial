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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Limpiar errores anteriores
            errorProvider1.Clear();

            try
            {
                bool hayError = false;

                // Si no se selecciona un miembro muestra error.
                if (cmbMiembro.SelectedIndex == -1)
                {
                    errorProvider1.SetError(
                        cmbMiembro,
                        "Debe seleccionar un miembro.");

                    hayError = true;
                }

                // Sino pone el tipo de ausencia muestra error.
                if (cmbTipoAusencia.SelectedIndex == -1)
                {
                    errorProvider1.SetError(
                        cmbTipoAusencia,
                        "Debe seleccionar el tipo de ausencia.");

                    hayError = true;
                }

                // Esto es para validar las fechas sino muestra error.
                if (dtpFinal.Value.Date < dtpInicio.Value.Date)
                {
                    errorProvider1.SetError(
                        dtpFinal,
                        "La fecha final no puede ser anterior a la inicial.");

                    hayError = true;
                }

                // Esto es para que el usuario escriba el motivo necesariamente.
                if (string.IsNullOrWhiteSpace(txtMotivo.Text))
                {
                    errorProvider1.SetError(
                        txtMotivo,
                        "Debe escribir el motivo de la solicitud.");

                    hayError = true;
                }

                // Si hay errores esto detiene el registro y muestra un mensaje al usuario.
                if (hayError)
                {
                    MessageBox.Show(
                        "Revise los campos marcados antes de continuar.",
                        "Error de validación",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                // Actualizar el resumen de la solicitud
                CalcularResumen();

                MessageBox.Show(
                    "Solicitud registrada correctamente.",
                    "Registro exitoso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrio un error al registrar la solicitud:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CalcularResumen()
        {
            DateTime inicio = dtpInicio.Value.Date;
            DateTime final = dtpFinal.Value.Date;

            // Dias calendario
            int diasCalendario = (final - inicio).Days + 1;

            // Dias habiles (lunes a viernes)
            int diasHabiles = 0;

            for (DateTime fecha = inicio; fecha <= final; fecha = fecha.AddDays(1))
            {
                if (fecha.DayOfWeek != DayOfWeek.Saturday &&
                    fecha.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasHabiles++;
                }
            }

            // Mostrar resultados
            lblDiasHabiles.Text = diasHabiles.ToString();
            lblDiasCalendario.Text = diasCalendario.ToString();

            // Obtener los dias disponibles del miembro
            int diasDisponibles = 30; // Temporal, luego se obtiene de la base de datos

            // Calcular dias restantes
            int diasRestantes = diasDisponibles - diasHabiles;

            // Mostrar resultados
            lblDiasdisponible.Text = diasDisponibles.ToString();
            lblDiasrestante.Text = diasRestantes.ToString();

            // Día de reincorporacion
            DateTime reincorporacion = final.AddDays(1);

            while (reincorporacion.DayOfWeek == DayOfWeek.Saturday ||
                   reincorporacion.DayOfWeek == DayOfWeek.Sunday)
            {
                reincorporacion = reincorporacion.AddDays(1);
            }

            lblreincorporacion.Text = reincorporacion.ToString("dd/MM/yyyy");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

            // Limpiar los campos de selección
            cmbMiembro.SelectedIndex = -1;
            cmbTipoAusencia.SelectedIndex = -1;

            // Restablecer las fechas
            dtpInicio.Value = DateTime.Today;
            dtpFinal.Value = DateTime.Today;

            // Limpiar el motivo
            txtMotivo.Clear();

            // Restablecer el resumen
            lblDiasHabiles.Text = "0";
            lblDiasCalendario.Text = "0";
            lblDiasdisponible.Text = "0";
            lblDiasrestante.Text = "0";
            lblreincorporacion.Text = "";

            // Colocar el cursor en el primer campo
            cmbMiembro.Focus();
        }
    }
}
