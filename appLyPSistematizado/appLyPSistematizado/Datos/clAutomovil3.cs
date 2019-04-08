using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using appLyPSistematizado.Datos;

namespace appLyPSistematizado.Datos
{
    class clAutomovil3
    {
        public string Placa { get; set; }
        public string TipoV { get; set; }
        public string FechaE { get; set; }
        public string FechaS { get; set; }
        public string Tipo { get; set; }
        public string Valor { get; set; }



        clConexion objconexion = new clConexion();


        public List<clAutomovil3> mtdListar()
        {
            List<clAutomovil3> listaAutomovil = new List<clAutomovil3>();
            DataTable dtparqueo = new DataTable();

            //string consulta = "select Placa,TipoV from Automovil ";

            string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,Tipo,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTipo=Servicio.IdServicio)";
            //string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,Tipo,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTipo=Servicio.IdServicio) where	Tipo='PARQUEO1'  or	Tipo='PARQUEO2' or 	Tipo='PARQUEO3'";
            dtparqueo = objconexion.mtdDesconectado(consulta);


            for (int i = 0; i < dtparqueo.Rows.Count; i++)
            {
                clAutomovil3 objAutomovil = new clAutomovil3();


                objAutomovil.Placa = dtparqueo.Rows[i]["Placa"].ToString();
                objAutomovil.TipoV = dtparqueo.Rows[i]["TipoV"].ToString();
                //objAutomovil.FechaE = dtparqueo.Rows[i]["FechaHoraE"].ToString();
                //objAutomovil.FechaS = dtparqueo.Rows[i]["FechaHoraS"].ToString();
                //objAutomovil.Tipo = dtparqueo.Rows[i]["Tipo"].ToString();
                //objAutomovil.Valor = dtparqueo.Rows[i]["Valor"].ToString();

                listaAutomovil.Add(objAutomovil);

            }
            return listaAutomovil;
        }
        public int mtdlistarregis()
        {

            String consulta = "insert into Automovil (Placa,TipoV)" +
                              " values('" + Placa + "','" + TipoV + "')";

            //DataTable dtServicio = new DataTable();
            //String consulta5 = "select max (IdAutomovil) from Automovil AS Ultimo  ";
            //dtServicio = objconexion.mtdDesconectado(consulta5);
            //int encontro = int.Parse(dtServicio.Rows[0][0].ToString());
            //return encontro;


            String consulta2 = "insert into Servicio (FechaHoraE)" +
                              " values('" + FechaE + "')";
            String consulta3 = "insert into Servicio (FechaHoraS)" +
                             " values('" + FechaS + "')";
            string consulta4 = "insert into Servicio (Tipo,Valor)" +
                              " values('" + Tipo + "','" + Valor + "')";



            int usure = objconexion.mtdConectado(consulta);
            return usure;
        }
        public DataTable mtdbuscar()
        {
            DataTable dtbuscar = new DataTable();
            string consulta = "select Placa,TipoV,FechaHoraE,FechaHoraS,Tipo,Valor FROM Automovil inner join Servicio on  (Servicio.IdAutomovil=Automovil.IdAutomovil) inner join Tarifa on (Tarifa.IdTipo=Servicio.IdServicio)where	Tipo='PARQUEO1'  or	Tipo='PARQUEO2' or 	Tipo='PARQUEO3' and Placa ='" + Placa + "'";
            dtbuscar = objconexion.mtdDesconectado(consulta);
            return dtbuscar;
        }
        public int mtdeditar()
        {
            string consulta = "update Automovil set Placa='" + Placa + "',TipoV='" + TipoV + "' WHERE Placa= '" + Placa + "'";
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

