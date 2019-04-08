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
            try
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
            catch (Exception)
            {

                
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
