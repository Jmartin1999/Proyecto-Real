using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appLyPSistematizado.Vista
{
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();
        }
        frmMensualidad objMensualidad = new frmMensualidad();
        private void pbMensualidad_Click(object sender, EventArgs e)
        {
            objMensualidad.Show();
            frmLavado lavado = new frmLavado();
            lavado.Show();
            this.Hide();
        }

        private void pbProceso_Click(object sender, EventArgs e)
        {
            frmParqueo parque = new frmParqueo();
            parque.Show();
            this.Hide();
        }

        private void pbLavado_Click(object sender, EventArgs e)
        {
            frmLavado lavado = new frmLavado();
            lavado.Show();
            this.Hide();
        }
    }
}
