using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appLyPSistematizado.Datos
{
    class clServicio
    {
        public string entrada { get; set; }
        public string salida { get; set; }
        public int IdAutomovil { get; set; }
        public int IdPersona { get; set; }
        public int IdTarifa { get; set; }
        

        clConexion objconeexion = new clConexion();

        public List<clServicio> mtdListar()
        {
            List<clServicio> listaservicios = new List<clServicio>();
            DataTable dtservicios = new DataTable();
            string consulta = "Select *From Servicio";
            dtservicios = objconeexion.mtdDesconectado(consulta);

            for (int i = 0; i < dtservicios.Rows.Count; i++)
            {
                clServicio ObjServicio = new clServicio();
                ObjServicio.entrada = dtservicios.Rows[i]["FechaHoraE"].ToString();
                ObjServicio.salida = dtservicios.Rows[i]["FechaHoraS"].ToString();
                ObjServicio.IdAutomovil = Convert.ToInt32(dtservicios.Rows[i]["IdAutomovil"]);
                ObjServicio.IdPersona = Convert.ToInt32(dtservicios.Rows[i]["IdPersona"]);
                ObjServicio.IdTarifa = Convert.ToInt32(dtservicios.Rows[i]["IdTarifa"]);
                
                listaservicios.Add(ObjServicio);

            }
            return listaservicios;

        }
        public DataTable mtdBuscar22()
        {
            DataTable dtbuscar = new DataTable();
            string consulta = "Select *from Servicio where IdAutomovil = '" + IdAutomovil + "'";
            dtbuscar = objconeexion.mtdDesconectado(consulta);
            return dtbuscar;

        }
        public int mtdRegistar22()
        {
            string consulta = "insert into Servicio (FechaHoraE, FechaHoraS, IdAutomovil,IdPersona,IdTarifa)"
                 + "values ('" + entrada + "', '" + salida + "','" + IdAutomovil + "','" + IdPersona + "','" + IdTarifa + "')";   
            int cantid = objconeexion.mtdConectado(consulta);
            return cantid;
        }
        public int mtdModificar()
        {
            string consulta = "update Servicio set FechaHoraE='" + entrada + "',FechaHoraS='" + salida + "',IdAutomovil='" + IdAutomovil + "',IdPersona='" + IdPersona + "' ,IdTarifa='" + IdTarifa + "' where IdAutomovil = '" + IdAutomovil + "' "; 
            int cannnn = objconeexion.mtdConectado(consulta);
            return cannnn;
        }
        public int mtdEliminar22()
        {
            string consulta = " delete  Servicio where IdAutomovil = '" + IdAutomovil + "' ";
            int cnnt = objconeexion.mtdConectado(consulta);
            return cnnt;
        }
        public DataTable mtdtipovehiculo(string placa)
        {
            DataTable dtbuscar = new DataTable();
            string consulta = "Select TipoV from Automovil where Placa = '" + placa + "'";
            dtbuscar = objconeexion.mtdDesconectado(consulta);
            return dtbuscar;
        }
        public DataTable mtdNomEmpleado(string doc)
        {
            DataTable dtbuscar = new DataTable();
            string consulta = "Select NombreP from Persona where Documento = '" + doc + "'";
            dtbuscar = objconeexion.mtdDesconectado(consulta);
            return dtbuscar;
        }
        
    }
}
