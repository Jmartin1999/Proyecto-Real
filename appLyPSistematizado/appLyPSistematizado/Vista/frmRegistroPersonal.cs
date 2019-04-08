using appLyPSistematizado.Datos;
using System;
using System.Collections.Generic;
using System.Data;
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

        List<clRegistroPersonal> listaPersonal = new List<clRegistroPersonal>();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            bool incorrecto = true;
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            objRegistro.NombreP = txtNombres.Text;
            objRegistro.Direccion = txtDireccion.Text;
            objRegistro.Telefono = txtTelefono.Text;
            objRegistro.Correo = txtCorreo.Text;
            objRegistro.Contraseña = txtContraseña.Text;
            objRegistro.Rol = cmbRol.Text;
            List<clRegistroPersonal> Repetido = new List<clRegistroPersonal>();
            Repetido = objRegistro.mtdListarPersona();
            for (int i = 0; i < Repetido.Count; i++)
            {
                if(Repetido[i].Correo ==txtCorreo.Text)
                {
                    MessageBox.Show("Este Empleado Ya esta registrado");
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

                int can = objRegistro.mtdRegistrar();
                if (can > 0)
                {
                    MessageBox.Show("Registrado" + can);

                }
                else
                {
                    MessageBox.Show("ERORRRRRRRRRR");

                }
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
            objMensaje.Body = "Documento" + "=" + txtDocumento.Text + "Nombres" + "=" + txtNombres.Text + "Direccion" + "=" + txtDireccion.Text + "Telefono" + "=" + txtTelefono.Text + "Correo" + "=" + txtCorreo.Text + "Contraseña" + "=" + txtContraseña.Text + "Rol" + "=" + cmbRol.Text;
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
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            objRegistro.NombreP = txtNombres.Text;
            objRegistro.Direccion = txtDireccion.Text;
            objRegistro.Telefono = txtTelefono.Text;
            objRegistro.Correo = txtCorreo.Text;
            objRegistro.Contraseña = txtContraseña.Text;
            objRegistro.Rol = cmbRol.Text;
         
            int can = objRegistro.mtdModificarPersona();
            if (can > 0)
            {
                MessageBox.Show("Filas Afectadas" + can);
               
            }
            else
            {
                MessageBox.Show("ERORRRRRRRRRR");
            }
        }

        private void frmRegistroPersonal_Load(object sender, EventArgs e)
        {
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            List<clRegistroPersonal> listapersonal = new List<clRegistroPersonal>();
            listapersonal = objRegistro.mtdListarPersona();
            dgvPersonal.DataSource = listapersonal;

  
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            objRegistro.NombreP = txtNombres.Text;
            objRegistro.Direccion = txtDireccion.Text;
            objRegistro.Telefono = txtTelefono.Text;
            objRegistro.Correo = txtCorreo.Text;
            objRegistro.Contraseña = txtContraseña.Text;
            objRegistro.Rol = cmbRol.Text;
       
            int can = objRegistro.EliminarPersona();
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

  
        clValidacion3 objvalidacion = new clValidacion3();

        private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtContraseña.Visible = false;
            objvalidacion.mtdSolNumeros(e);
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            objRegistro.Documento = txtDocumento.Text;
            List<clRegistroPersonal> MostrarDatos = new List<clRegistroPersonal>();
            MostrarDatos = objRegistro.mtdListarPersona();
            for (int i = 0; i < MostrarDatos.Count; i++)
            {
                if (MostrarDatos[i].Documento== txtDocumento.Text)
                {

                    txtNombres.Text = MostrarDatos[i].NombreP;
                    txtDireccion.Text = MostrarDatos[i].Direccion;
                    txtTelefono.Text = MostrarDatos[i].Telefono;
                    txtCorreo.Text = MostrarDatos[i].Correo;
                    txtContraseña.Text = MostrarDatos[i].Contraseña;
                    cmbRol.Text = MostrarDatos[i].Rol;
                }
                
            }
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
            clRegistroPersonal objRegistro = new clRegistroPersonal();
            List<clRegistroPersonal> listapersonal = new List<clRegistroPersonal>();
            listapersonal = objRegistro.mtdListarPersona();
            dgvPersonal.DataSource = listapersonal;

        }

        private void cmbRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

