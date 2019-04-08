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
        public string PLACA { get; set; }
        public string TIPOVEHICULO { get; set; }
        public string SERVICIO { get; set; }
        public string VALOR { get; set; }

        public int EMPLEADO { get; set; }

        clConexion objConeexion = new clConexion();

        public List<VclLavadero> mtdListar()
        {
            List<VclLavadero> listalavado = new List<VclLavadero>();
            DataTable dtLavado = new DataTable();
            string consulta = "select Placa,TipoV,Tipo,Valor from Automovil inner join Servicio on (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on  (Servicio.IdTarifa = Tarifa.IdTipo) where Tipo= 'LAVADO1' or Tipo = 'LAVADO2' or Tipo='LAVADO3'";
            dtLavado = objConeexion.mtdDesconectado(consulta);

            for (int i = 0; i < dtLavado.Rows.Count; i++)
            {
                VclLavadero objLavado = new VclLavadero();
                objLavado.PLACA = dtLavado.Rows[i]["Placa"].ToString();
                objLavado.TIPOVEHICULO = dtLavado.Rows[i]["TipoV"].ToString();
                objLavado.SERVICIO = dtLavado.Rows[i]["Tipo"].ToString();
                ; objLavado.VALOR = dtLavado.Rows[i]["Valor"].ToString();
                listalavado.Add(objLavado);
            }
            return listalavado;

        }
        public DataTable mtdVehiculo()
        {
            DataTable dtvehiculo = new DataTable();
            string consulta = "Select *from Automovil where Tipo= 'LAVADO1' or Tipo = 'LAVADO2' or Tipo='LAVADO3'or as Ultimo ";
            dtvehiculo = objConeexion.mtdDesconectado(consulta);
            return dtvehiculo;
        }
        public int mtdregistrar()
        {
            string consulta = "insert into Servicio (TotalP, IdAutomovil,IdPersona,IdTarifa)"
                 + "values ('" + VALOR + "', '" + PLACA + "',, '" + EMPLEADO + "''" + SERVICIO + "')";
            int cantid = objConeexion.mtdConectado(consulta);
            return cantid;
        }
    }
}
