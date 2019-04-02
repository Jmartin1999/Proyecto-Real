using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using appLyPSistematizado.Datos;

namespace appLyPSistematizado.Vista
{
    public partial class frmLavado : Form
    {
        public frmLavado()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void btnguarda22_Click(object sender, EventArgs e)
        {
            clServicio objservicio = new clServicio();
            objservicio.entrada = txtEntrada22.Text;
            objservicio.salida = txtSalida22.Text;
            objservicio.IdAutomovil = Convert.ToInt32(cmbAutomovil22.SelectedValue);
            objservicio.IdPersona = Convert.ToInt32(cmbempleado22.SelectedValue);
            objservicio.IdTarifa = Convert.ToInt32(cmbTarifa22.SelectedValue);
            
            int canttt = objservicio.mtdRegistar22();
            if (canttt > 0)
            {
                MessageBox.Show("Datos Registrados");
                clServicio Objservicio = new clServicio();
                dgvServicio.DataSource = Objservicio.mtdListar();
            }
            else
            {
                MessageBox.Show("Datos no Registrados");
            }
        }

        DateTime entradaV = DateTime.Now;
        DateTime SalidaV = DateTime.Now;

        private void frmServicio_Load(object sender, EventArgs e)
        {
            clServicio Objservicio = new clServicio();
            List<clServicio> listadatos = new List<clServicio>();

            listadatos = Objservicio.mtdListar();
            dgvServicio.DataSource = Objservicio.mtdListar();
            for (int i = 0; i < listadatos.Count; i++)
            {

            }


            //combos

            clautomovil2 objautomovil = new clautomovil2();
            DataTable dtautomovil = new DataTable();
            dtautomovil = objautomovil.mtdListar();
            cmbAutomovil22.DataSource = dtautomovil;
            cmbAutomovil22.DisplayMember = "Placa";
            cmbAutomovil22.ValueMember = "IdAutomovil";

            clpersona2 objpersona = new clpersona2();
            DataTable dtpersona = new DataTable();
            dtpersona = objpersona.mtdListar();
            cmbempleado22.DataSource = dtpersona;
            cmbempleado22.DisplayMember = "Documento";
            cmbempleado22.ValueMember = "IdPersona";

            cltarifa2 objtarifa = new cltarifa2();
            DataTable dttarifa = new DataTable();
            dttarifa = objtarifa.mtdListar();
            cmbTarifa22.DataSource = dttarifa;
            cmbTarifa22.DisplayMember = "Tipo";
            cmbTarifa22.ValueMember = "IdTarifa";


            //fecha y hora 
            txtEntrada22.Text = entradaV.ToString("dd/MM/yyyy hh:mm:ss");
            //dd=dias  //MM=meses  //yyyy=año  //hh=hora  //mm=minuto  //ss=segundos

        }

        private void btnModificar22_Click(object sender, EventArgs e)
        {
            clServicio objservicio = new clServicio();
            objservicio.entrada = txtEntrada22.Text;
            objservicio.salida = txtSalida22.Text;
            objservicio.IdAutomovil = Convert.ToInt32(cmbAutomovil22.Text);
            objservicio.IdPersona = Convert.ToInt32(cmbempleado22.Text);
            objservicio.IdTarifa = Convert.ToInt32(cmbTarifa22.Text);
            
            int cant = objservicio.mtdModificar();
            if (cant > 0)
            {
                MessageBox.Show("Datos Modificados" + cant);

            }
            else
            {
                MessageBox.Show("Error");
            }
            dgvServicio.DataSource = objservicio.mtdListar();
        }

        private void dgvServicio_DoubleClick(object sender, EventArgs e)
        {
            txtEntrada22.Text = Convert.ToString(dgvServicio.CurrentRow.Cells[0].Value);
            txtSalida22.Text = Convert.ToString(dgvServicio.CurrentRow.Cells[1].Value);
            cmbAutomovil22.Text = Convert.ToString(dgvServicio.CurrentRow.Cells[2].Value);
            cmbempleado22.Text = Convert.ToString(dgvServicio.CurrentRow.Cells[3].Value);
            cmbTarifa22.Text = Convert.ToString(dgvServicio.CurrentRow.Cells[4].Value);
            
        }

        private void cmbAutomovil22_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable objtabla = new DataTable();
            clServicio objservicio = new clServicio();
            objtabla = objservicio.mtdtipovehiculo(cmbAutomovil22.Text);
            if (objtabla.Rows.Count > 0)
            {
                txtTipoa.Text = objtabla.Rows[0]["TipoV"].ToString();
            }
        }

        private void cmbempleado22_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable objEmpleado = new DataTable();
            clServicio objservicio = new clServicio();
            objEmpleado = objservicio.mtdNomEmpleado(cmbempleado22.Text);
            if (objEmpleado.Rows.Count > 0)
            {
                txtnombre11.Text = objEmpleado.Rows[0]["NombreP"].ToString();
            }
        }

        private void btnEliminar22_Click(object sender, EventArgs e)
        {
            //clServicio Objservicio = new clServicio();
            //Objservicio.IdAutomovil = txtBuscar22.Text;
            //Objservicio.mtdEliminar22();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label10.Text = DateTime.Now.ToString();

        }

        private void chbsalida_CheckedChanged(object sender, EventArgs e)
        {
            string respuesta;

            if (chbsalida.Checked)
            {
                respuesta = txtSalida22.Text = SalidaV.ToString(@"dd/MM/yyyy hh:mm:ss");
            }
            else
            {
                respuesta = "";
            }
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            //frmTotalPagar pagar = new frmTotalPagar();
            //pagar.Show();
            
            TimeSpan tiempoDiferencia = DateTime.Now - entradaV;
            string tiempo = tiempoDiferencia.ToString();
            MessageBox.Show(tiempo );








        }
    }
}
