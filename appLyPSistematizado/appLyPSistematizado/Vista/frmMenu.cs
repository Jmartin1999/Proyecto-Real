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
    public partial class frmMenu : Form
    {
        public frmMenu()
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
    }
}
