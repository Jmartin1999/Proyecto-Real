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
        frmServicios objServicios = new frmServicios();

        private void pbRegistro_Click(object sender, EventArgs e)
        {
            objRegistroPersonal.Show();
        }

        private void pbProceso_Click(object sender, EventArgs e)
        {
            objServicios.Show();
        }

        private void pbTipo_Click(object sender, EventArgs e)
        {
            frmTarifa tarifa = new frmTarifa();
            tarifa.Show();

        }
    }
}
