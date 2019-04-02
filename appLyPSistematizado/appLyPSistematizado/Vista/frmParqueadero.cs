using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appLyPSistematizado.Datos;
using System.Data;



namespace appLyPSistematizado.Vista
{
    public partial class frmParqueadero : Form
    {
        public frmParqueadero(string dato)
        {
            InitializeComponent();
            r = dato;
            label10.Text = "Parqueo";
        }
        
        clValidacion3 objvalidacion = new clValidacion3();
        string r = "";

        private void frmAutomovil_Load(object sender, EventArgs e)
        {


            clAutomovil3 objAutomovil = new clAutomovil3();
            List<clAutomovil3> listadatos2 = new List<clAutomovil3>();
            listadatos2 = objAutomovil.mtdListar();
            dgvAutomovil.DataSource = objAutomovil.mtdListar();
            for (int i = 0; i < listadatos2.Count; i++)
            {

            }
        }
            
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbt.Text) || string.IsNullOrEmpty(cmbEstado.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(txtPlaca.Text) | string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(txtObservaciones.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else
            {
                clAutomovil3 objAutomovil = new clAutomovil3();

                objAutomovil.TipoV = cmbt.Text;
                objAutomovil.Estado = cmbEstado.Text;
                objAutomovil.Placa = txtPlaca.Text;
                objAutomovil.Marca = txtMarca.Text;
                objAutomovil.Observaciones = txtObservaciones.Text;
                int cant = objAutomovil.mtdlistarregis();
                if (cant > 0)
                {
                    MessageBox.Show("Datos Registrados");
                    clAutomovil3 objVehiculo = new clAutomovil3();
                    dgvAutomovil.DataSource = objVehiculo.mtdListar();
                }
                else
                {
                    MessageBox.Show("Datos NO  Registrados");
                }
                cmbEstado.Text = "";
                cmbt.Text = "";
                txtPlaca.Clear();
                txtMarca.Clear();
                txtObservaciones.Clear();
                frmCupos objcupos = new frmCupos();
                objcupos.Show(); 

            }


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clAutomovil3 objAutomovil = new clAutomovil3();
            objAutomovil.TipoV = cmbt.Text;
            objAutomovil.Estado = cmbEstado.Text;
            objAutomovil.Placa = txtPlaca.Text;
            objAutomovil.Marca = txtMarca.Text;
            objAutomovil.Observaciones = txtObservaciones.Text;
            int cant = objAutomovil.mtdeditar();
            if (cant > 0)
            {
                MessageBox.Show("DATOS MODIFICADOS" + cant);
                frmAutomovil_Load(null, null);

            }
            else
            {
                MessageBox.Show("ERROR");
            }

            cmbEstado.Text = "";
            cmbt.Text = "";
            txtPlaca.Clear();
            txtMarca.Clear();
            txtObservaciones.Clear();
            dgvAutomovil.DataSource = objAutomovil.mtdListar();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clAutomovil3 objAutomovil = new clAutomovil3();
            objAutomovil.Placa = txtPlaca2.Text;
            dgvAutomovil.DataSource = objAutomovil.mtdbuscar();
            cmbEstado.Text = "";
            cmbt.Text = "";
            txtPlaca.Clear();
            txtMarca.Clear();
            txtObservaciones.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clAutomovil3 objAutomovil = new clAutomovil3();
            objAutomovil.Placa = txtPlaca2.Text;
            objAutomovil.mtdeliminar();
            MessageBox.Show("DATOS ELIMINADOS");
            dgvAutomovil.DataSource = objAutomovil.mtdListar();
            cmbEstado.Text = "";
            cmbt.Text = "";
            txtPlaca.Clear();
            txtMarca.Clear();
            txtObservaciones.Clear();

        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSololetras(e);
            objvalidacion.mtdSoloMayusculas(e);
        }

        

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void txtPlaca2_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void dgvAutomovil_DoubleClick(object sender, EventArgs e)
        {
            cmbt.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[0].Value);
            cmbEstado.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[1].Value);
            txtPlaca.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[2].Value);
            txtMarca.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[3].Value);
            txtObservaciones.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[4].Value);
        }

        private void dgvAutomovil_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
