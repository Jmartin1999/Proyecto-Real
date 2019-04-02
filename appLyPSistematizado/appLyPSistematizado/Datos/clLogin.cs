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
        public string NombreP { get; set; }
        public string Direccion { get; set; }
        public string Telefono{ get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public string SueldoBasico { get; set; }

        clConexion objConexion = new clConexion();
        List<clLogin> listaUsuarios = new List<clLogin>();
        List<clLogin> listaPersona = new List<clLogin>();
        List<clLogin> listaOlvidar = new List<clLogin>();
        public int mtdRegistrar()
        {
            string consulta = "insert into Persona(Documento,NombreP,Direccion,Telefono,Correo,Contraseña,Rol,SueldoBasico) values ('" + Documento + "','" + NombreP + "','" + Direccion + "','" + Telefono + "','" + Correo + "','" + Contraseña + "','" + Rol + "','" + SueldoBasico + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdModificarContraseña()
        {
            string consulta = "Update Persona set Contraseña='" + Contraseña + "' where  Contraseña='"+Contraseña+"'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
      public List<clLogin> mtdListarSesion()
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
        public List<clLogin> mtdOlvidar(string email)
        {

            DataTable dtOlvidar = new DataTable();
            string consulta = "select  Correo,Contraseña from Persona where Correo='" + email + "'";
            dtOlvidar = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtOlvidar.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
      
                objLogin.Contraseña = dtOlvidar.Rows[i]["Correo"].ToString();
                objLogin.Contraseña = dtOlvidar.Rows[i]["Contraseña"].ToString();

                listaOlvidar.Add(objLogin);
            }
            return listaOlvidar;

        }
        public DataTable mtdListarCorreos()
        {



          DataTable dtLogin1 = new DataTable();
            string consulta = "select Correo  from Persona";
            dtLogin1 = objConexion.mtdDesconectado(consulta);
            
            return dtLogin1;

        }
        public int mtdModificarPersona()
        {
            string consulta = "Update Persona set Documento='" + Documento + "',NombreP='" + NombreP + "',Dirrecion='" + Direccion + "',Telefono='" + Telefono + "',Correo='" + Correo + "',Contraseña='" + Contraseña + "',Rol='" + Rol + "',SueldoBasico=" + SueldoBasico + " where  Documento='" + Documento + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public int EliminarPersona()
        {
            string consulta = "Delete from  Persona  where Documento '" + Documento + "'";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
        public List<clLogin> mtdListarPersona()
        {

            DataTable dtPersona = new DataTable();
            string consulta = "select * from Persona";
            dtPersona = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtPersona.Rows.Count; i++)
            {
                clLogin objLogin = new clLogin();
                objLogin.Documento = dtPersona.Rows[i]["Documento"].ToString();
                objLogin.NombreP = dtPersona.Rows[i]["NombreP"].ToString();
                objLogin.Direccion = dtPersona.Rows[i]["Direccion"].ToString();
                objLogin.Telefono = dtPersona.Rows[i]["Telefono"].ToString();
                objLogin.Correo = dtPersona.Rows[i]["Correo"].ToString();
                objLogin.Contraseña = dtPersona.Rows[i]["Contraseña"].ToString();
                objLogin.Rol = dtPersona.Rows[i]["Rol"].ToString();
                objLogin.SueldoBasico = dtPersona.Rows[i]["SueldoBasico"].ToString();
                listaPersona.Add(objLogin);
            }
            return listaPersona;

        }

    }
}
