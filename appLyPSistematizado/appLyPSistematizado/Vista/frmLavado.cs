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
    public partial class frmLavado : Form
    {
        public frmLavado()
        {
            InitializeComponent();
        }
        List<VclLavadero> listadatos = new List<VclLavadero>();
        private void FrmLavadero_Load(object sender, EventArgs e)
        {
            VclLavadero lavadero = new VclLavadero();
            listadatos = lavadero.mtdListar();
            dgvDatos.DataSource = lavadero.mtdListar();


            //combos
            clEmpleado empleado = new clEmpleado();
            DataTable dtempleado = new DataTable();
            dtempleado = empleado.mtdListar();
            cmbEmpleado.DataSource = dtempleado;
            cmbEmpleado.DisplayMember = "NombreP";
            cmbEmpleado.ValueMember = "IdPersona";

        }
        private void btnBuscar22_Click(object sender, EventArgs e)
        {
                string placa = txtPlaca.Text;
                string tipovehiculo = "";
                string valor = "";
                for (int i = 0; i < listadatos.Count; i++)
                {
                    if (listadatos[i].PLACA == placa)
                    {
                        tipovehiculo = listadatos[i].TIPOVEHICULO;
                        valor = listadatos[i].VALOR;
                    }
                }

                if (tipovehiculo == "carro")
                {
                    rbCarro.Checked = true;
                }
                else if (tipovehiculo == "moto")
                {
                    rbMoto.Checked = true;
                }
                else if (tipovehiculo == "bicicleta")
                {
                    rbBicicleta.Checked = true;
                }
                txtServicio.Text = valor;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLavado_Load(object sender, EventArgs e)
        {

        }

        private void btnautomovil_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            string tipovehiculo = "";
            string valor = "";
            clAutomovil objAutomovil = new clAutomovil();
            List<clAutomovil> RepetirPlaca = new List<clAutomovil>();
            RepetirPlaca = objAutomovil.mtdAutoCompletarAutomovil();
            objAutomovil.Placa = txtPlaca.Text;

            for (int i = 0; i < RepetirPlaca.Count; i++)
            {
                if (RepetirPlaca[i].Placa == txtPlaca.Text)
                {
                    MessageBox.Show("Este Automovil ya esta resgistrado");

                    for (int y = 0; i < listadatos.Count; i++)
                    {
                        if (listadatos[y].PLACA == placa)
                        {
                            tipovehiculo = listadatos[y].TIPOVEHICULO;
                            valor = listadatos[y].VALOR;
                        }
                    }

                    if (tipovehiculo == "carro")
                    {
                        rbCarro.Checked = true;
                    }
                    else if (tipovehiculo == "moto")
                    {
                        rbMoto.Checked = true;
                    }
                    else if (tipovehiculo == "bicicleta")
                    {
                        rbBicicleta.Checked = true;
                    }
                    txtServicio.Text = valor;
                }
                else
                {
                    objAutomovil.Placa = txtPlaca.Text;
                    if (tipovehiculo == "carro")
                    {
                        rbCarro.Checked = true;
                    }
                    else if (tipovehiculo == "moto")
                    {
                        rbMoto.Checked = true;
                    }
                    else if (tipovehiculo == "bicicleta")
                    {
                        rbBicicleta.Checked = true;
                    }
                    objAutomovil.TipoV = tipovehiculo;
                    VclLavadero objCliente = new VclLavadero();
                    int cant = objCliente.mtdAsignarVehiculo();
                    lblId.Text = cant.ToString();


                    int can = objAutomovil.mtdRegistrarAutomovil(cant);
                    if (can > 0)
                    {
                        MessageBox.Show("Registrado");
                        FrmLavadero_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("ERORRRRRRRRRR");
                    }
                }

            }

        }
    }
}
