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
    public partial class FormularioBase : Form
    {
        public FormularioBase()
        {
            InitializeComponent();
        }
        // Actualiza el título de la franja azul y el de la ventana.
        public string Titulo
        {
            get { return lblTitulo.Text; }
            set
            {
                lblTitulo.Text = value;
                Text = value;
            }
        }
        // Carga los datos y configura la tabla para que sea de solo lectura.
        protected void ConfigurarTabla(DataGridView dgv, object datos)
        {
            dgv.DataSource = datos;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;

            foreach (DataGridViewColumn columna in dgv.Columns)
            {
                if (columna.Name.StartsWith("Id"))
                {
                    columna.Visible = false;
                }
            }

        }
        // Muestra una advertencia al usuario.
        protected void Advertir(string texto)
        {
            MessageBox.Show(texto, "Atención", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
        // Muestra un mensaje de error.
        protected void Fallar(string texto)
        {
            MessageBox.Show(texto, "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        // Devuelve true si el usuario responde Sí.
        protected bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes;
        }
        // Envía una confirmación a la barra inferior.
        protected void Informar(string texto)
        {
            Estado.Mostrar(texto);
        }
    }
}
