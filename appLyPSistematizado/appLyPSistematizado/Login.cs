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
        frmRegistroUsuario objRegistrar = new frmRegistroUsuario();
        frmRecuperarContraseña objRecuperar = new frmRecuperarContraseña();
        frmServicios objServicios = new frmServicios();

        frmJefe objJefe = new frmJefe();
        private void label5_Click(object sender, EventArgs e)
        {
            objRegistrar.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            objRecuperar.Show();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

            clLogin objLogin = new clLogin();
            listaUsuario = objLogin.mtdListar();

            for (int i = 0; i < listaUsuario.Count; i++)

            {
                if (listaUsuario[i].Correo == txtUsuario.Text && listaUsuario[i].Contraseña == txtContraseña.Text && listaUsuario[i].Rol == cmbRol.Text)
                {
                    cmbRol.Text = "ADMINISTRADOR";
                    objServicios.Show();
                }
                else if (cmbRol.Text == "JEFE")
                {
                    MessageBox.Show("No puede ingresar");
                }
              
            
                else if (listaUsuario[i].Correo == txtUsuario.Text && listaUsuario[i].Contraseña == txtContraseña.Text && listaUsuario[i].Rol==cmbRol.Text)
                {
                    cmbRol.Text = "JEFE";
                    objJefe.Show();
                }


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

    }
}
        


    

