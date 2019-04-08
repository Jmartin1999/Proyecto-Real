using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class clTipo
    {
        public string TipoServicio { get; set; }
        public string TipoVehiculo { get; set; }
        public string Valor { get; set; }

        clConexion objConexion = new clConexion();


        public List<clTipo> mtdListar()
        {
            List<clTipo> ListaTipo = new List<clTipo>();
            DataTable dtTipo = new DataTable();
            string Consulta = "select * from Tarifa";
            dtTipo = objConexion.mtdDesconectado(Consulta);
            for (int i = 0; i < dtTipo.Rows.Count; i++)
            {
                clTipo objTipo = new clTipo();
                objTipo.TipoServicio = dtTipo.Rows[i]["TipoServicio"].ToString();
                objTipo.TipoVehiculo = dtTipo.Rows[i]["Categoria"].ToString();
                objTipo.Valor = dtTipo.Rows[i]["Valor"].ToString();
                ListaTipo.Add(objTipo);

            }
            return ListaTipo;
        }
        public int mtdRegistro()

        {
            string Consulta = "Insert into Tarifa(TipoServicio,TipoVehiculo,ValorTarifa) values ('" + TipoServicio + "','" + TipoVehiculo + "','" + Valor + "')";
            int dtRegistro = objConexion.mtdConectado(Consulta);
            return dtRegistro;
        }
        public DataTable mtdBuscar()
        {
            DataTable dtBuscar = new DataTable();
            string Consulta = "select * from Tarifa where TipoServicio='" + TipoServicio + "'  ";
            dtBuscar = objConexion.mtdDesconectado(Consulta);
            return dtBuscar;
        }
        public int mtdModificar()
        {
            string Consulta = "update Tarifa set TipoServicio='" + TipoServicio + "' , TipoVehiculo='" + TipoVehiculo + "',ValorTarifa='" + Valor + "'where TipoServicio='" + TipoServicio + "'  ";
            int Cant = objConexion.mtdConectado(Consulta);
            return Cant;

        }
        public int mtdEliminar()
        {
            string Consulta = "Delete Tarifa where TipoServicio='" + TipoServicio + "'";
            int Canti = objConexion.mtdConectado(Consulta);
            return Canti;



        }
    }
}
