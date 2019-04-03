using System;
using System.Drawing;
using System.Windows.Forms;

namespace appLyPSistematizado.Vista
{
    public partial class frmCupos : Form
    {
        public frmCupos()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (check1.Checked)
            {
                text1.BackColor = Color.Red;
            }
            if (check2.Checked)
            {
                text2.BackColor = Color.Red;
            }
            if (check3.Checked)
            {
                text3.BackColor = Color.Red;
            }
            if (check4.Checked)
            {
                text4.BackColor = Color.Red;
            }
            if (check5.Checked)
            {
                text5.BackColor = Color.Red;
            }
            if (check6.Checked)
            {
                text6.BackColor = Color.Red;
            }
            if (check7.Checked)
            {
                text7.BackColor = Color.Red;
            }
            if (check8.Checked)
            {
                text8.BackColor = Color.Red;
            }
            if (check9.Checked)
            {
                text9.BackColor = Color.Red;
            }
            if (check10.Checked)
            {
                text10.BackColor = Color.Red;
            }
            

            frmParqueadero objAutomovil = new frmParqueadero("");
            objAutomovil.Show();
            


        }

        private void check1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

