using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class VclLavadero
    {
        public int IdAutomovil { get; set; }
        public string PLACA { get; set; }
        public string TIPOVEHICULO { get; set; }
        public string SERVICIO { get; set; }
        public string VALOR { get; set; }
        public int EMPLEADO { get; set; }

        clConexion conexion = new clConexion();

        public List<VclLavadero> mtdListar()
        {
            List<VclAutomovil> listalavado = new List<VclAutomovil>();

            DataTable dtLavado = new DataTable();
            string consulta = "select Placa,TipoV,Tipo,Valor from Automovil inner join Servicio on (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on  (Servicio.IdTipo = Tarifa.IdTipo) where Tipo= 'LAVADO1' or Tipo = 'LAVADO2' or Tipo='LAVADO3'";
            dtLavado = conexion.mtdDesconectado(consulta);

            for (int i = 0; i < dtLavado.Rows.Count; i++)
            {
                VclLavadero objLavado = new VclLavadero();
                objLavado.PLACA = dtLavado.Rows[i]["Placa"].ToString();
                objLavado.TIPOVEHICULO = dtLavado.Rows[i]["TipoV"].ToString();
                objLavado.SERVICIO = dtLavado.Rows[i]["Tipo"].ToString();
                objLavado.VALOR = dtLavado.Rows[i]["Valor"].ToString();
                listalavado.Add(objLavado);
            }
            return listalavado;

        }
        public DataTable mtdVehiculo()
        {
            DataTable dtvehiculo = new DataTable();
            string consulta = "Select from Automovil where TipoV= 'LAVADO1' or TipoV = 'LAVADO2' or TipoV='LAVADO3' ";
            dtvehiculo = conexion.mtdDesconectado(consulta);
            return dtvehiculo;
        }
        public int mtdRegistrarAutomovil(int IdCliente)
        {
            string consulta = "insert into Automovil(Servicicio, IdAutomovil) values ('" + PLACA + "','" + TIPOVEHICULO + "','" + Observaciones + "','" + IdCliente + "')";
            int cantidad = conexion.mtdConectado(consulta);
            return cantidad;
        }
        public int mtdregistrar()
        {
            string consulta = "insert into Servicio (TotalP, IdAutomovil,IdPersona,IdTarifa)"
                 + "values ('" + VALOR + "', '" + PLACA + "', '" + EMPLEADO + "','" + SERVICIO + "')";
            int cantid = conexion.mtdConectado(consulta);
            return cantid;
        }
        public int mtdAsignarVehiculo()
        {
            DataTable dtCliente = new DataTable();
            string consulta = "select max (IdAutomovil) from Automovil ";
            dtCliente = conexion.mtdDesconectado(consulta);
            int encontro = int.Parse(dtCliente.Rows[0][0].ToString());
            return encontro;
        }
    }
}
