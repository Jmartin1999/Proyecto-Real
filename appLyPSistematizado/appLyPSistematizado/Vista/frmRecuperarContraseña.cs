using appLyPSistematizado.Datos;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace appLyPSistematizado.Vista
{
    public partial class frmRecuperarContraseña : Form
    {
        public frmRecuperarContraseña()
        {
            InitializeComponent();
        }
        List<clLogin> ListaUsuario = new List<clLogin>();

        private void btnRestablecer_Click(object sender, EventArgs e)
        {

            clLogin objLogin = new clLogin();
            bool incorrecto = false;
            ListaUsuario = objLogin.mtdListar();
            for (int i = 0; i < ListaUsuario.Count; i++)
            {
                if (ListaUsuario[i].Correo == txtCorreo.Text)
                {
                    objLogin.Contraseña = txtContraseña.Text;
                    int can = objLogin.mtdModificarContraseña();
                    if (can > 0)
                    {
                        incorrecto = true;

                    }
                }
                else
                {
                    incorrecto = false;
                }
                if (incorrecto == true)
                {
                    MessageBox.Show("Modificacion Correcta");
                }

            }
            mtdEnviar();

        }
        public void mtdEnviar()
        {

            MailMessage objMensaje = new MailMessage();
            objMensaje.To.Add(txtCorreo.Text);
            objMensaje.From = new MailAddress("jonathan200045@gmail.com", "", System.Text.Encoding.UTF8);
            objMensaje.Subject = "SOLICITUD CAMBIO DE CONTRASEÑA";
            objMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            objMensaje.Body = "Su contraseña se modifico a" + "=" + txtContraseña.Text;
            objMensaje.BodyEncoding = System.Text.Encoding.UTF8;
            objMensaje.IsBodyHtml = false;

            SmtpClient objCliente = new SmtpClient();
            objCliente.Credentials = new NetworkCredential("jonathan200045@gmail.com", "velandia1999");
            objCliente.Port = 587;
            objCliente.Host = "smtp.gmail.com";
            objCliente.EnableSsl = true;
            objCliente.Send(objMensaje);
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
    }
}
