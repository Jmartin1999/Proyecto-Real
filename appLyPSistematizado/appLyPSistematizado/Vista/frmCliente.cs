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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnguarda11_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDoc11.Text) || string.IsNullOrEmpty(txtNom11.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(txtTelf11.Text) | string.IsNullOrEmpty(txtDirec11.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(txtFecha11.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else
            {
                clCliente objcliente = new clCliente();
                

                objcliente.NombresYApellidos = txtNom11.Text;
                objcliente.Documento = txtDoc11.Text;
                objcliente.Telefono = txtTelf11.Text;
                objcliente.Direccion = txtDirec11.Text;
                objcliente.Fecha = txtFecha11.Text;
                int numm = objcliente.mtdRegistrar();
                
                if (numm > 0)
                {
                    MessageBox.Show("Datos Registrados");
                    clCliente objCliente = new clCliente();
                    dgvCliente.DataSource = objCliente.mtdListar();

                    
                }
                else
                {
                    MessageBox.Show("Datos no Registrados");
                }
                frmAutomovil objAutomovil = new frmAutomovil();
                objAutomovil.Show();

                txtNom11.Clear();
                txtDoc11.Clear();
                txtTelf11.Clear();
                txtDirec11.Clear();
                txtFecha11.Clear();
               
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            List<clCliente> listaDatos = new List<clCliente>();

            listaDatos = objCliente.mtdListar();
            dgvCliente.DataSource = objCliente.mtdListar();
            for (int i = 0; i < listaDatos.Count; i++)
            {

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            objCliente.Documento = txtDocumento11.Text;
            dgvCliente.DataSource = objCliente.mtdBuscar();
        }

        private void btnModificar11_Click(object sender, EventArgs e)
        {
            clCliente objcliente = new clCliente();
            
            objcliente.NombresYApellidos = txtNom11.Text;
            objcliente.Documento = txtDoc11.Text;
            objcliente.Telefono = txtTelf11.Text;
            objcliente.Direccion = txtDirec11.Text;
            objcliente.Fecha = txtFecha11.Text;

            int cant = objcliente.mtdModificar();
            if (cant > 0)
            {
                MessageBox.Show("Datos Modificados" + cant);

            }
            else
            {
                MessageBox.Show("Error");
            }
            dgvCliente.DataSource = objcliente.mtdListar();
           
            txtNom11.Clear();
            txtDoc11.Clear();
            txtTelf11.Clear();
            txtDirec11.Clear();
            txtFecha11.Clear();
        }

        private void txtDoc11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("digitar solo numeros");
                }
            }
        }

        private void dgvCliente_DoubleClick(object sender, EventArgs e)
        {
            
            txtNom11.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[0].Value);
            txtDoc11.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[1].Value);
            txtTelf11.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[2].Value);
            txtDirec11.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[3].Value);
            txtFecha11.Text = Convert.ToString(dgvCliente.CurrentRow.Cells[4].Value);

        }

        private void txtTelf11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("digitar solo numeros");
                }
            }
        }

        private void btnEliminar11_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            objCliente.Documento = txtDocumento11.Text;
            objCliente.mtdEliminar();
            MessageBox.Show("Datos Eliminados");
            dgvCliente.DataSource = objCliente.mtdListar();
           
            txtNom11.Clear();
            txtDoc11.Clear();
            txtTelf11.Clear();
            txtDirec11.Clear();
            txtFecha11.Clear();
        }

        private void txtNom11_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Digite solo letras");
            }

            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void txtDirec11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
