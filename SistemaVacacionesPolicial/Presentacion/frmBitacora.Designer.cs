using System.Drawing;
using System.Windows.Forms;

namespace Presentacion
{
    partial class frmBitacora
    {
        private Label lblEncabezado;
        private Label lblEstado;
        private DataGridView dgvBitacora;
        private DataGridViewTextBoxColumn colFecha;
        private DataGridViewTextBoxColumn colUsuario;
        private DataGridViewTextBoxColumn colAccion;

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.lblEncabezado = new Label();
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Location = new Point(0, 0);
            this.lblEncabezado.Size = new Size(720, 46);
            this.lblEncabezado.Text = "Bitácora";
            this.lblEncabezado.BackColor = Color.FromArgb(31, 58, 95);
            this.lblEncabezado.ForeColor = Color.White;
            this.lblEncabezado.Dock = DockStyle.Top;
            this.lblEncabezado.Padding = new Padding(18, 0, 0, 0);
            this.lblEncabezado.TextAlign = ContentAlignment.MiddleLeft;
            this.lblEncabezado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblEstado = new Label();
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Location = new Point(24, 62);
            this.lblEstado.Size = new Size(664, 24);
            this.lblEstado.Text = "Consulta de eventos pendiente de conexión.";
            this.dgvBitacora = new DataGridView();
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.Location = new Point(24, 100);
            this.dgvBitacora.Size = new Size(672, 300);
            this.dgvBitacora.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBitacora.BackgroundColor = Color.White;
            this.dgvBitacora.ReadOnly = true;
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.RowHeadersVisible = false;
            this.dgvBitacora.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.colFecha = new DataGridViewTextBoxColumn();
            this.colFecha.Name = "colFecha";
            this.colFecha.HeaderText = "Fecha y hora";
            this.colUsuario = new DataGridViewTextBoxColumn();
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.HeaderText = "Usuario";
            this.colAccion = new DataGridViewTextBoxColumn();
            this.colAccion.Name = "colAccion";
            this.colAccion.HeaderText = "Acción";
            this.dgvBitacora.Columns.AddRange(new DataGridViewColumn[] { this.colFecha, this.colUsuario, this.colAccion });
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEncabezado);
            this.Text = "Bitácora";
            this.Name = "frmBitacora";
            this.ClientSize = new Size(720, 430);
            this.Font = new Font("Segoe UI", 10F);
            this.BackColor = Color.FromArgb(244, 246, 248);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
