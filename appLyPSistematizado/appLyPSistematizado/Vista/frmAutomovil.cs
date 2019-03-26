using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appLyPSistematizado.Datos;


namespace appLyPSistematizado.Vista
{
    public partial class frmAutomovil : Form
    {
        public frmAutomovil()
        {
            InitializeComponent();
        }

        private void frmAutomovil_Load(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            List<clAutomovil> listadatos2 = new List<clAutomovil>();
            listadatos2 = objAutomovil.mtdListar();
            dgvAutomovil.DataSource = objAutomovil.mtdListar();
            for (int i = 0; i < listadatos2.Count; i++)
            {

            }

            //cargar combos
            clCliente3 objcliente = new clCliente3();
            DataTable dtCliente = new DataTable();
            dtCliente = objcliente.mtdListar();
            cbxIdCliente.DataSource = dtCliente;
            cbxIdCliente.DisplayMember = "Nombres";
            cbxIdCliente.ValueMember = "IdCliente";

        }
        clValidacion3 objvalidacion = new clValidacion3();
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbt.Text) || string.IsNullOrEmpty(txtEstado.Text))
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
                clAutomovil objAutomovil = new clAutomovil();

                objAutomovil.TipoV = cmbt.Text;
                objAutomovil.Estado = txtEstado.Text;
                objAutomovil.Placa = txtPlaca.Text;
                objAutomovil.Marca = txtMarca.Text;
                objAutomovil.Observaciones = txtObservaciones.Text;
                objAutomovil.idCliente = Convert.ToInt32(cbxIdCliente.SelectedValue);
                int cant = objAutomovil.mtdlistarregis();
                if (cant > 0)
                {
                    MessageBox.Show("Datos Registrados");
                    clAutomovil objVehiculo = new clAutomovil();
                    dgvAutomovil.DataSource = objVehiculo.mtdListar();
                }
                else
                {
                    MessageBox.Show("Datos NO  Registrados");
                }
                txtEstado.Clear();
                cmbt.Text = "";
                txtPlaca.Clear();
                txtMarca.Clear();
                txtObservaciones.Clear();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.TipoV = cmbt.Text;
            objAutomovil.Estado = txtEstado.Text;
            objAutomovil.Placa = txtPlaca.Text;
            objAutomovil.Marca = txtMarca.Text;
            objAutomovil.Observaciones = txtObservaciones.Text;
            objAutomovil.idCliente = Convert.ToInt32(cbxIdCliente.SelectedValue);
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
            dgvAutomovil.DataSource = objAutomovil.mtdListar();
            txtEstado.Clear();
            cmbt.Text = "";
            txtPlaca.Clear();
            txtMarca.Clear();
            txtObservaciones.Clear();
        

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca2.Text;
            dgvAutomovil.DataSource = objAutomovil.mtdbuscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca2.Text;
            objAutomovil.mtdeliminar();
            MessageBox.Show("DATOS ELIMINADOS");
            dgvAutomovil.DataSource = objAutomovil.mtdListar();
            txtEstado.Clear();
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

        private void dgvAutomovil_DoubleClick(object sender, EventArgs e)
        {
            cmbt.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[0].Value);
            txtEstado.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[1].Value);
            txtPlaca.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[2].Value);
            txtMarca.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[3].Value);
            txtObservaciones.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[4].Value);
            cbxIdCliente.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[5].Value);
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSololetras(e);
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSoloMayusculas(e);
        }
    }
}