using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace appLyPSistematizado.Datos
{
    class clAutomovil3
    {
        public string TipoV { get; set; }
        public string Estado { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Observaciones { get; set; }
        public int idCliente { get; set; }

        List<clAutomovil3> listaAutomovil = new List<clAutomovil3>();
        clConexion objconexion = new clConexion();

        public List<clAutomovil3> mtdListar()
        {

            DataTable dtAutomovil = new DataTable();
            string consulta = "select*from Automovil";
            dtAutomovil = objconexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtAutomovil.Rows.Count; i++)
            {
                clAutomovil3 objAutomovil = new clAutomovil3();
                objAutomovil.TipoV = dtAutomovil.Rows[i]["TipoV"].ToString();
                objAutomovil.Estado = dtAutomovil.Rows[i]["Estado"].ToString();
                objAutomovil.Placa = dtAutomovil.Rows[i]["Placa"].ToString();
                objAutomovil.Marca = dtAutomovil.Rows[i]["Marca"].ToString();
                objAutomovil.Observaciones = dtAutomovil.Rows[i]["Observaciones"].ToString();
                objAutomovil.idCliente = Convert.ToInt32(dtAutomovil.Rows[i]["IdCliente"]);
                listaAutomovil.Add(objAutomovil);

            }
            return listaAutomovil;
        }
        public int mtdlistarregis()
        {

            String consulta = "insert into Automovil (TipoV,Estado,Placa,Marca,Observaciones,Idcliente)" +
                              " values('" + TipoV + "','" + Estado + "','" + Placa + "', '" + Marca + "','" + Observaciones + "', '" + idCliente + "')";


            int usure = objconexion.mtdConectado(consulta);
            return usure;
        }
        public DataTable mtdbuscar()
        {
            DataTable dtbuscar = new DataTable();
            string consulta = "select TipoV,Estado,Placa,Marca,Observaciones,IdCliente from Automovil where Placa='" + Placa + "'";
            dtbuscar = objconexion.mtdDesconectado(consulta);
            return dtbuscar;
        }
        public int mtdeditar()
        {
            string consulta = "update Automovil set TipoV='" + TipoV + "',Estado='" + Estado + "',Placa='" + Placa + "', Marca='" + Marca + "',Observaciones='" + Observaciones + "' WHERE Placa= '" + Placa + "'";
            int canedi = objconexion.mtdConectado(consulta);
            return canedi;
        }
        public int mtdeliminar()
        {
            string consulta = "delete Automovil where Placa='" + Placa + "'";
            int cont = objconexion.mtdConectado(consulta);
            return cont;
        }
    }
}
