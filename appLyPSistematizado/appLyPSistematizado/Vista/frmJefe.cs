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
    }
}
