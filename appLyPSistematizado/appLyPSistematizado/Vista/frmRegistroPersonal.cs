using appLyPSistematizado.Datos;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace appLyPSistematizado.Vista
{
    public partial class frmRegistroPersonal : Form
    {
        public frmRegistroPersonal()
        {
            InitializeComponent();
        }

        List<clLogin> listaPersonal = new List<clLogin>();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clLogin objLogin = new clLogin();
            objLogin.Documento = txtDocumento.Text;
            objLogin.NombreP = txtNombres.Text;
            objLogin.Direccion = txtDireccion.Text;
            objLogin.Telefono = txtTelefono.Text;
            objLogin.Correo = txtCorreo.Text;
            objLogin.Contraseña = txtContraseña.Text;
            objLogin.Rol = cmbRol.Text;
            objLogin.SueldoBasico = txtSueldo.Text;
            int can = objLogin.mtdRegistrar();
            if (can > 0)
            {
                MessageBox.Show("Registrado" + can);

            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
    

        }
        public static bool validaremail(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtCorreo_Leave(object sender, EventArgs e)
        {
            if (validaremail(txtCorreo.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida,el correo debe tener el formato : dominio@gmail.com," +
                    "porfavor seleccione un correo valido", "Validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCorreo.SelectAll();
                txtCorreo.Focus();
            }
        }
        public void mtdEnviar()
        {

            MailMessage objMensaje = new MailMessage();
            objMensaje.To.Add(txtCorreo.Text);
            objMensaje.From = new MailAddress("jonathan200045@gmail.com", "", System.Text.Encoding.UTF8);
            objMensaje.Subject = "Bienvenido Registro Exitoso";
            objMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            objMensaje.Body = "Documento" + "=" + txtDocumento.Text + "Nombres" + "=" + txtNombres.Text + "Direccion" + "=" + txtDireccion.Text + "Telefono" + "=" + txtTelefono.Text + "Correo" + "=" + txtCorreo.Text + "Contraseña" + "=" + txtContraseña.Text + "Rol" + "=" + cmbRol.Text + "Sueldo" + "=" + txtSueldo.Text;
            objMensaje.BodyEncoding = System.Text.Encoding.UTF8;
            objMensaje.IsBodyHtml = false;

            SmtpClient objCliente = new SmtpClient();
            objCliente.Credentials = new NetworkCredential("jonathan200045@gmail.com", "velandia1999");
            objCliente.Port = 587;
            objCliente.Host = "smtp.gmail.com";
            objCliente.EnableSsl = true;
            objCliente.Send(objMensaje);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            clLogin objLogin = new clLogin();
            objLogin.Documento = txtDocumento.Text;
            objLogin.NombreP = txtNombres.Text;
            objLogin.Direccion = txtDireccion.Text;
            objLogin.Telefono = txtTelefono.Text;
            objLogin.Correo = txtCorreo.Text;
            objLogin.Contraseña = txtContraseña.Text;
            objLogin.Rol = cmbRol.Text;
            objLogin.SueldoBasico = txtSueldo.Text;
            int can = objLogin.mtdModificarPersona();
            if (can > 0)
            {
                MessageBox.Show("Filas Afectadas" + can);
               frmRegistroPersonal_Load(null, null);
            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
        }

        private void frmRegistroPersonal_Load(object sender, EventArgs e)
        {
            clLogin objLogin = new clLogin();
            List<clLogin> listapersonal = new List<clLogin>();
            listapersonal = objLogin.mtdListarPersona();
            dgvPersonal.DataSource = listapersonal;

            for (int i = 0; i < listapersonal.Count; i++)
            {
                if (listapersonal[i].Documento == "1055315950")
                {
                    MessageBox.Show(listapersonal[i].Rol);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clLogin objLogin = new clLogin();
            objLogin.Documento = txtDocumento.Text;
            objLogin.NombreP = txtNombres.Text;
            objLogin.Direccion = txtDireccion.Text;
            objLogin.Telefono = txtTelefono.Text;
            objLogin.Correo = txtCorreo.Text;
            objLogin.Contraseña = txtContraseña.Text;
            objLogin.Rol = cmbRol.Text;
            objLogin.SueldoBasico = txtSueldo.Text;
            int can = objLogin.EliminarPersona();
            if (can > 0)
            {
                MessageBox.Show("Filas Afectadas" + can);
                frmRegistroPersonal_Load(null, null);
            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
        }

        private void dgvPersonal_DoubleClick(object sender, EventArgs e)
        {
            txtDocumento.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[0].Value);
            txtNombres.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[1].Value);
            txtDireccion.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[2].Value);
           txtTelefono.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[3].Value);
            txtCorreo.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[4].Value);
            txtContraseña.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[5].Value);
            cmbRol.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[6].Value);
           txtSueldo.Text = Convert.ToString(dgvPersonal.CurrentRow.Cells[7].Value);

        }
        clValidacion3 objvalidacion = new clValidacion3();

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSolNumeros(e);
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSololetras(e);
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSolNumeros(e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            objvalidacion.mtdSoloMayusculas(e);
        }

        private void btnListarPersonal_Click(object sender, EventArgs e)
        {
         

        }
    }
}

