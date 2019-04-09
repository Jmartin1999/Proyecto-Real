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
        private void frmLavado_Load(object sender, EventArgs e)
        {
            VclLavadero lavadero = new VclLavadero();
            listadatos = lavadero.mtdListar();
            dgvDatos.DataSource = lavadero.mtdListar();

           // combos
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

        //List<VclLavadero> ListaVerAutomovil = new List<VclLavadero>();
        private void btnautomovil_Click(object sender, EventArgs e)
        {
            VclAutomovil objAutomovil = new VclAutomovil();
            List<VclAutomovil> Repetir = new List<VclAutomovil>();
            Repetir = objAutomovil.mtdAutoCompletar();
            objAutomovil.Placa = txtPlaca.Text;
            for (int i = 0; i < Repetir.Count; i++)
            {
                if (Repetir[i].Placa == txtPlaca.Text)
                {
                    MessageBox.Show("Este Cliente Ya Esta Registrado");
                }
                else
                {
                    objAutomovil.Placa = txtPlaca.Text;
                    string tipovehiculo = "";
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
                    int can = objAutomovil.mtdRegistrarCliente();
                    if (can > 0)
                    {
                        MessageBox.Show("Registrado");

                        frmLavado_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("ERORRRRRRRRRR");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VclLavadero lavadero = new VclLavadero();
            lavadero.PLACA = txtPlaca.Text;
            List<clAutomovil> RepetirPlaca = new List<clAutomovil>();

            RepetirPlaca = lavadero.mtdAutoCompletar();
            for (int i = 0; i < RepetirPlaca.Count; i++)
            {
                if (RepetirPlaca[i].Placa == txtPlaca.Text)
                {
                    MessageBox.Show("Este Automovil ya esta resgistrado");
                }
                else
                {
                    lavadero.PLACA = txtPlaca.Text;
                    string tipovehiculo = "";
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
                    lavadero.TIPOVEHICULO = tipovehiculo;
                    clCliente objCliente = new clCliente();
                    int variable = objCliente.mtdAsignarVehiculo();
                    lblId.Text = variable.ToString();


                    int can = lavadero.mtdRegistrarAutomovil(variable);
                    if (can > 0)
                    {
                        MessageBox.Show("Registrado");
                        frmLavado_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("ERORRRRRRRRRR");
                    }
                }
    }
}
