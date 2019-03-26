using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class clLogin
    {
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string Direccion { get; set; }
        public string Telefono{ get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string Sueldo { get; set; }

        clConexion objConexion = new clConexion();
        List<clLogin> listaUsuarios = new List<clLogin>();
        List<clLogin> listaCorreo = new List<clLogin>();
        public int mtdRegistrar()
        {
            string consulta = "insert into Persona(Documento,NombreP,Direccion,Telefono,Correo,Contraseña,Rol,SueldoBasico) values ('" + Documento + "','" + Nombres + "','" + Direccion + "','" + Telefono + "','" + Correo + "','" + Contraseña + "','" + Rol + "','" + Sueldo + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdModificarContraseña()
        {
            string consulta = "Update Persona set Contraseña='" + Contraseña + "' where  Contraseña='"+Contraseña+"'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
      public List<clLogin> mtdListar()
        {

            DataTable dtLogin = new DataTable();
            string consulta = "select Correo,Contraseña,Rol from Persona";
            dtLogin = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtLogin.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
                objLogin.Correo = dtLogin.Rows[i]["Correo"].ToString();
                objLogin.Contraseña = dtLogin.Rows[i]["Contraseña"].ToString();
                objLogin.Rol = dtLogin.Rows[i]["Rol"].ToString();
                listaUsuarios.Add(objLogin);
            }
            return listaUsuarios;

        }
        public List<clLogin> mtdListarCorreos()
        {



          DataTable dtLogin1 = new DataTable();
            string consulta = "select Correo  from Persona";
            dtLogin1 = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtLogin1.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
                objLogin.Correo = dtLogin1.Rows[i]["Correo"].ToString();
                
                listaCorreo.Add(objLogin);
            }
            return listaCorreo;

        }

    }
}
