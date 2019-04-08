using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appLyPSistematizado.Vista;
using appLyPSistematizado.Datos;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Net;

namespace appLyPSistematizado
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        List<clLogin> listaUsuario = new List<clLogin>();
        List<clLogin> listaCorreo = new List<clLogin>();
        List<clLogin> listaOlvidar = new List<clLogin>();
        frmRegistroPersonal objRegistrar = new frmRegistroPersonal();
        frmAdministrador objAdministrador = new frmAdministrador();
        frmJefe objJefe = new frmJefe();
        
        
 
        private void label5_Click(object sender, EventArgs e)
        {
            objRegistrar.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
 
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            clLogin objLogin = new clLogin();
            listaUsuario = objLogin.mtdListarSesion();
            bool incorrecto = true;
            for (int i = 0; i < listaUsuario.Count; i++)

            {
                if (listaUsuario[i].Correo == txtUsuario.Text && listaUsuario[i].Contraseña == txtContraseña.Text && listaUsuario[i].Rol == cmbRol.Text)
                {
                    if (cmbRol.Text=="Administrador")
                    {
                        objAdministrador.Show();
                      
                    }
                    else if(cmbRol.Text == "Jefe")
                   {
                        objJefe.Show();
                    }
                }
                else
                {
                    incorrecto = false;
                }

            }
            if (incorrecto==true)
            {
                incorrecto = false;
            }
            else
            {
                MessageBox.Show("Datos Ingresados Incorrectos ");
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {

            if (validaremail(txtUsuario.Text))
            {

            }
            else
            {
                MessageBox.Show("Direccion de correo electronico no valida,el correo debe tener el formato : dominio@gmail.com," +
                    "porfavor seleccione un correo valido", "Validacion de correo electronico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.SelectAll();
                txtUsuario.Focus();
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

        private void Login_Load(object sender, EventArgs e)
        {
            if (chkContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void chkContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chkContraseña.Checked)
            {
                txtContraseña.UseSystemPasswordChar = false;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
       
   
        
        public void mtdEnviar()
        {

            MailMessage objMensaje = new MailMessage();
            objMensaje.To.Add(txtUsuario.Text);
            objMensaje.From = new MailAddress("jonathan200045@gmail.com", "", System.Text.Encoding.UTF8);
            objMensaje.Subject = "Recordar Contraseña";
            objMensaje.SubjectEncoding = System.Text.Encoding.UTF8;
            objMensaje.Body = "Su Contraseña es "+ contraseñarecuperada;
            objMensaje.BodyEncoding = System.Text.Encoding.UTF8;
            objMensaje.IsBodyHtml = false;

            SmtpClient objCliente = new SmtpClient();
            objCliente.Credentials = new NetworkCredential("jonathan200045@gmail.com", "velandia1999");
            objCliente.Port = 587;
            objCliente.Host = "smtp.gmail.com";
            objCliente.EnableSsl = true;
            objCliente.Send(objMensaje);
        }
        string contraseñarecuperada = "";
        private void lnlContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                clLogin objLogin = new clLogin();
                string email = txtUsuario.Text;
                listaOlvidar = objLogin.mtdOlvidar(email);


                contraseñarecuperada = listaOlvidar[0].Contraseña.ToString();


                mtdEnviar();
                MessageBox.Show("Se ha enviado un Correo de recuperacion a su cuenta de correo electronico " + txtUsuario);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay conexion a internet" + ex.ToString());

            }
        }

      
 

        private void cmbRol_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

        


    

