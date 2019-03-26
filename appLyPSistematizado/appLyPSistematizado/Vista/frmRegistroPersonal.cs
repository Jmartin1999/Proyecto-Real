using appLyPSistematizado.Datos;
using System;
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clLogin objLogin = new clLogin();
            objLogin.Documento = txtDocumento.Text;
            objLogin.Nombres = txtNombres.Text;
            objLogin.Direccion = txtDireccion.Text;
            objLogin.Telefono = txtTelefono.Text;
            objLogin.Correo = txtCorreo.Text;
            objLogin.Contraseña = txtContraseña.Text;
            objLogin.Rol = cmbRol.Text;
            objLogin.Sueldo = txtSueldo.Text;
            int can = objLogin.mtdRegistrar();
            if (can > 0)
            {
                MessageBox.Show("Registrado" + can);

            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
            mtdEnviar();

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
    }
}

