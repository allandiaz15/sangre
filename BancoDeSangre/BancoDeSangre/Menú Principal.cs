using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDeSangre
{
    public partial class Menú_Principal : Form
    {
        public Menú_Principal()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new Form1();
            formLogin.ShowDialog();
        }

        private void agregarDonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formAgregarDonante = new FormAgregarDonantes();
            formAgregarDonante.MdiParent = this;
            formAgregarDonante.Show();
        }

        private void eliminarDonantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEliminarDonante = new FormEliminarDonates();
            formEliminarDonante.MdiParent = this;
            formEliminarDonante.Show();
        }

        private void compraDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCompra = new FormCompra();
            formCompra.MdiParent = this;
            formCompra.Show();
        }

        private void ventaDeSangreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formVenta = new FormVenta();
            formVenta.MdiParent = this;
            formVenta.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteCliente = new FormReporteCliente();
            formReporteCliente.MdiParent = this;
            formReporteCliente.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteVenta = new FormReporteVenta();
            formReporteVenta.MdiParent = this;
            formReporteVenta.Show();
        }

        private void Menú_Principal_Load(object sender, EventArgs e)
        {
            Login();
        }
    }
}
