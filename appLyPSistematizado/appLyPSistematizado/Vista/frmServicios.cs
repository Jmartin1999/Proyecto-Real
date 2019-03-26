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
    public partial class frmServicios : Form
    {
        public frmServicios()
        {
            InitializeComponent();
        }
        frmCupos objCupos = new frmCupos();
        private void pbParqueo_Click(object sender, EventArgs e)
        {
            objCupos.Show();
        }
    }
}
