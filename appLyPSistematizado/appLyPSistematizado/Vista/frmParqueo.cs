using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using appLyPSistematizado.Vista;
using appLyPSistematizado.Datos;



namespace appLyPSistematizado.Vista
{
    public partial class frmParqueo : Form
    {
        public frmParqueo()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
        }


        DateTime entradav = DateTime.Now;
        DateTime salidav = DateTime.Now;
        List<clAutomovil3> listadatos = new List<clAutomovil3>();


        private void btnRegistro_Click(object sender, EventArgs e)
        {

            txt22.Text = "PLACA";

            if (string.IsNullOrEmpty(cmbt.Text) || string.IsNullOrEmpty(txtPlaca.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(txtPlaca.Text) | string.IsNullOrEmpty(cmbt.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else if (string.IsNullOrEmpty(cmbt.Text))
            {
                MessageBox.Show("debe ingresar la informacion completa");
            }
            else
            {
                clAutomovil3 objparqueo = new clAutomovil3();
                txt22.Text = "PLACA";
                label2.Enabled = false;
                objparqueo.Placa = txtPlaca.Text;
                objparqueo.TipoV = cmbt.Text;
                //objparqueo.FechaE = txtFecha1.Text;
                //objparqueo.FechaS = txtTiempo1.Text;
                //objparqueo.Tipo = label5.Text;

               

                int cant = objparqueo.mtdlistarregis();
                if (cant > 0)
                {

                    MessageBox.Show("Datos Registrados");
                    gb22.Enabled = true;
                    txtPlaca3.Text = txtPlaca.Text;


                    clAutomovil3 objVehiculo = new clAutomovil3();
                    dgvAutomovil.DataSource = objVehiculo.mtdListar();


                    txtPlaca3.Enabled = true;


                }
                else
                {
                    MessageBox.Show("Datos NO  Registrados");
                }
                label5.Text = null;
                cmbt.Text = null;
                txtPlaca.Clear();


                txtFecha1.Text = entradav.ToString("dddd dd MMMM yyyy   hh:mm:ss");
                //txtFecha1.Text = entradav.ToString("dddd dd MMMM yyyy  hh:mm:ss");}



            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clAutomovil3 objparqueo = new clAutomovil3();
            

            objparqueo.Placa = txtPlaca.Text;
            objparqueo.TipoV = cmbt.Text;
           

            int cant = objparqueo.mtdeditar();
            if (cant > 0)
            {
                dgvAutomovil.DataSource = objparqueo.mtdListar();
                MessageBox.Show("DATOS MODIFICADOS" + cant);

                frmParqueo_Load(null, null);

            }
            else
            {
                MessageBox.Show("ERROR");
            }


            txtPlaca.Clear();
            cmbt.Text = null;




        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            clAutomovil3 objparqueo = new clAutomovil3();
            objparqueo.Placa = txtPlaca2.Text;
            dgvAutomovil.DataSource = objparqueo.mtdbuscar();

            gb22.Enabled = true;
            cmbt.Text = null;
            txtPlaca2.Clear();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            clAutomovil3 objparqueo = new clAutomovil3();
            objparqueo.Placa = txtPlaca2.Text;
            objparqueo.TipoV = txtPlaca.Text;

            objparqueo.mtdeliminar();
            MessageBox.Show("DATOS ELIMINADOS");
            cmbt.Text = null;
            txtPlaca2.Clear();
            txtPlaca.Clear();
            dgvAutomovil.DataSource = objparqueo.mtdListar();
        }

        private void frmParqueo_Load(object sender, EventArgs e)
        {
            label5.Enabled = false;
            clAutomovil3 parqueo = new clAutomovil3();
            listadatos = parqueo.mtdListar();
            dgvAutomovil.DataSource = parqueo.mtdListar();

        }

        private void dgvAutomovil_DoubleClick(object sender, EventArgs e)
        {
            txtPlaca.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[0].Value);
            cmbt.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[1].Value);
            txtFecha1.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[2].Value);
            txtTiempo1.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[3].Value);
            label5.Text = Convert.ToString(dgvAutomovil.CurrentRow.Cells[4].Value);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            txtTiempo1.Text = DateTime.Now.ToString("dddd dd MMMM yyyy  hh:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeSpan tiempoDiferencia = DateTime.Now - entradav;
            string tiempo = tiempoDiferencia.ToString();
            MessageBox.Show(tiempo);

            clAutomovil3 parqueo = new clAutomovil3();
            listadatos = parqueo.mtdListar();
            dgvAutomovil.DataSource = parqueo.mtdListar();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            for (int i = 0; i < listadatos.Count; i++)
            {
                if (listadatos[i].Placa == placa)
                {
                    placa = listadatos[i].Placa;


                }

            }
        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {
            txt22.Text = "PLACA";
        }

        private void cmbt_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbt.Text == "CARRO")
            {
                label5.Text = "PARQUEO1";
            }

            else if (cmbt.Text == "BICICLETA")
            {
                label5.Text = "PARQUEO3";
            }
            else
            {
                label5.Text = "PARQUEO2";
            }

        }
    }
}

