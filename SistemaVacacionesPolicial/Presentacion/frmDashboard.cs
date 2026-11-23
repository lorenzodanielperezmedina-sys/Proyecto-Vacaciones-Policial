using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Presentacion
{
    public partial class frmDashboard : Form
    {
        public frmDashboard() : this(null) { }

        public frmDashboard(string nombre)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(nombre))
                lblBienvenida.Text = "Te damos la bienvenida, " + nombre;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
