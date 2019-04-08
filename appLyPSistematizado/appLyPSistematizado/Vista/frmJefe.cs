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
    public partial class frmJefe : Form
    {
        public frmJefe()
        {
            InitializeComponent();
        }
        frmRegistroPersonal objRegistroPersonal = new frmRegistroPersonal();
     

        private void pbRegistro_Click(object sender, EventArgs e)
        {
            objRegistroPersonal.Show();
        }

        private void pbProceso_Click(object sender, EventArgs e)
        {
            
        }

        private void pbTipo_Click(object sender, EventArgs e)
        {
            frmTarifa tarifa = new frmTarifa();
            tarifa.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmMensualidad mensualidad = new frmMensualidad();
            mensualidad.Show();
        }

        private void pbLavado_Click(object sender, EventArgs e)
        {
            frmLavado lavado = new frmLavado();
            lavado.Show();
            this.Hide();
        }
    }
}
