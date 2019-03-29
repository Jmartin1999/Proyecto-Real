using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appLyPSistematizado.Datos
{
    class clCliente
    {
        public string Documento { get; set; }
        public string NombresApellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Fecha { get; set; }
        clConexion objConeexion = new clConexion();


        public List<clCliente> mtdListar()
        {
            List<clCliente> listaclientes = new List<clCliente>();
            DataTable dtCliente = new DataTable();
            string consulta = "Select *From Cliente";
            dtCliente = objConeexion.mtdDesconectado(consulta);

            for (int i = 0; i < dtCliente.Rows.Count; i++)
            {
                clCliente objcliente = new clCliente();
                objcliente.NombresApellidos = dtCliente.Rows[i]["NombresYApellidos"].ToString();
                objcliente.Documento = dtCliente.Rows[i]["Documento"].ToString();
                objcliente.Telefono = dtCliente.Rows[i]["Telefono"].ToString();
                objcliente.Direccion = dtCliente.Rows[i]["Direccion"].ToString();
                objcliente.Fecha = dtCliente.Rows[i]["Fecha"].ToString();
                listaclientes.Add(objcliente);

            }
            return listaclientes;

        }
        public int mtdRegistrar()
        {
            string consulta = "insert into Cliente (NombresYApellidos,Documento,Telefono,Direccion,Fecha)"
                + "values ('" + NombresApellidos + "','" + Documento + "','" + Telefono + "','" + Direccion + "','" + Fecha + "')";
            int cint = objConeexion.mtdConectado(consulta);
            return cint;
        }

        public DataTable mtdBuscar()
        {
            DataTable dtbuscar = new DataTable();
            string consulta = "Select  NombresYApellidos, Documento,Telefono,Direccion,Fecha from Cliente where Documento =  '" + Documento + "'";
            dtbuscar = objConeexion.mtdDesconectado(consulta);
            return dtbuscar;
        }
        public int mtdModificar()
        {
            string consulta = "update Cliente set NombresYApellidos='" + NombresApellidos + "',Documento='" + Documento + "',Telefono='" + Telefono + "',Direccion='" + Direccion + "' ,Fecha='" + Fecha + "' where Documento = '" + Documento + "' ";
            int cannnn = objConeexion.mtdConectado(consulta);
            return cannnn;
        }
        public int mtdEliminar()
        {
            string consulta = " delete  Cliente where Documento = '" + Documento + "' ";
            int cnnt = objConeexion.mtdConectado(consulta);
            return cnnt;
        }
    }
}
