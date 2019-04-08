using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appLyPSistematizado.Datos;

namespace appLyPSistematizado.Vista
{
    public partial class frmMensualidad : Form
    {
        public frmMensualidad()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        List<clAutomovil> ListaVerAutomovil = new List<clAutomovil>();
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clCliente objCliente = new clCliente();
            
            List<clCliente> Repetir = new List<clCliente>();
            Repetir = objCliente.mtdAutoCompletar();
            objCliente.Documento = txtDocumento.Text;
            for (int i = 0; i < Repetir.Count; i++)
            {
                if (Repetir[i].Documento == txtDocumento.Text)
                {
                    MessageBox.Show("Este Cliente Ya Esta Registrado");
                }
                else
                {
                    objCliente.Documento = txtDocumento.Text;
                    objCliente.Nombres = txtNombre.Text;
                    objCliente.Telefono = txtTelefono.Text;

                    int can = objCliente.mtdRegistrarCliente();
                    if (can > 0)
                    {
                        MessageBox.Show("Registrado");
                      
                        frmMensualidad_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("ERORRRRRRRRRR");
                    }
                }
            }
          
        

        }

       

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca.Text;
            dgvBuscar.DataSource = objAutomovil.mtdMostrar();
    

        }

        private void frmMensualidad_Load(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            DataTable dtAutomovil = new DataTable();
            dtAutomovil = objAutomovil.mtdMostrar();
            dgvBuscar.DataSource = dtAutomovil;
            clPagos objPago = new clPagos();
            DataTable dtPago = new DataTable();
            dtPago = objPago.mtdMostrar();
            dgvPagos.DataSource = dtPago;

        }

  

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clCliente objCliente = new clCliente();
            List<clCliente> ListaCliente = new List<clCliente>();
            objCliente.Documento = txtDocumento.Text;
            ListaCliente = objCliente.mtdAutoCompletar();
            for (int i = 0; i < ListaCliente.Count; i++)
            {
                if (ListaCliente[i].Documento == txtDocumento.Text)
                {
                    txtNombre.Text = ListaCliente[i].Nombres;
                    txtTelefono.Text = ListaCliente[i].Telefono;
                }

            }
        }

        private void txtPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();

            List<clAutomovil> ListaAutomovil = new List<clAutomovil>();
            objAutomovil.Placa = txtPlaca.Text;
            dgvBuscar.DataSource = objAutomovil.mtdMostrar();
            ListaAutomovil = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < ListaAutomovil.Count; i++)
            {
                if (ListaAutomovil[i].Placa == txtPlaca.Text)
                {
                   
                    cmbTipo.Text = ListaAutomovil[i].TipoV;
                    txtObservacion.Text = ListaAutomovil[i].Observaciones;
                }

            }
        }

        private void txtPlaca2_KeyPress(object sender, KeyPressEventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();

            List<clAutomovil> lista = new List<clAutomovil>();
            objAutomovil.Placa = txtPlaca2.Text;
   
            lista = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Placa == txtPlaca2.Text)
                {
                    txtPlaca3.Text = lista[i].Placa;
                    txtTipo.Text = lista[i].TipoV;
                    txtObservaciones.Text = lista[i].Observaciones;
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();
            objAutomovil.Placa = txtPlaca.Text;
            List<clAutomovil> RepetirPlaca = new List<clAutomovil>();
       
            RepetirPlaca = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < RepetirPlaca.Count; i++)
            {
                if (RepetirPlaca[i].Placa==txtPlaca.Text)
                {
                    MessageBox.Show("Este Automovil ya esta resgistrado");
                }
                else
                {
                    objAutomovil.Placa = txtPlaca.Text;
                    objAutomovil.TipoV = cmbTipo.Text;
                    objAutomovil.Observaciones = txtObservacion.Text;
                    clCliente objCliente = new clCliente();
                    int variable = objCliente.mtdAsignarVehiculo();
                    lblId.Text = variable.ToString();


                    int can = objAutomovil.mtdRegistrarAutomovil(variable);
                    if (can > 0)
                    {
                        MessageBox.Show("Registrado");
                        frmMensualidad_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("ERORRRRRRRRRR");
                    }
                }
            }
           
        }

        private void btnBuscarPlaca_Click(object sender, EventArgs e)
        {
            clAutomovil objAutomovil = new clAutomovil();

            List<clAutomovil> ListaAutomovil = new List<clAutomovil>();
            objAutomovil.Placa = txtPlaca2.Text;
            dgvBuscar.DataSource = objAutomovil.mtdMostrar();
            ListaAutomovil = objAutomovil.mtdAutoCompletarAutomovil();
            for (int i = 0; i < ListaAutomovil.Count; i++)
            {
                if (ListaAutomovil[i].Placa == txtPlaca2.Text)
                {
              
                    int variable = ListaAutomovil[i].IdAutomovil;
                    lblAutomovil.Text = variable.ToString();
                    cmbTipo.Text = ListaAutomovil[i].TipoV;
                    txtObservacion.Text = ListaAutomovil[i].Observaciones;
                }

            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text = DateTime.Now.ToString();
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            tbPagos.Show();
        }

        private void btnPago_Click(object sender, EventArgs e)
        {
            clPagos objPago = new clPagos();
            objPago.FechaPago = Convert.ToDateTime(lblTiempo.Text);
            if (txtTipo.Text == "Carro")
            {
                objPago.Valor = "50000";
            }
            else if (txtTipo.Text == "Moto")
            {
                objPago.Valor = "30000";
            }
            else if (txtTipo.Text == "Bicicleta")
            {
                objPago.Valor = "10000";
            }

            int IdAutomovil = Convert.ToInt32(lblAutomovil.Text);
            objPago.IdAutomovil = IdAutomovil;
            int can = objPago.mtdRegistrarPago(IdAutomovil);
            if (can > 0)
            {
                MessageBox.Show("Registrado");
                frmMensualidad_Load(null, null);
            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
            

        }
    }
}
