using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class VclAutomovil
    {
        
        public string Placa { get; set; }
        public string TipoV { get; set; }
        clConexion objConexion = new clConexion();
        List<clAutomovil> listAutos = new List<clAutomovil>();

        public List<clAutomovil> mtdAutoCompletar()
        {
            DataTable dtAutomovil = new DataTable();
            string consulta = "select * from Automovil where Placa='" + Placa + "'";
            dtAutomovil = objConexion.mtdDesconectado(consulta);
            for (int i = 0; i < dtAutomovil.Rows.Count; i++)
            {
                clAutomovil Automovil = new clAutomovil();
                Automovil.IdAutomovil = Convert.ToInt32(dtAutomovil.Rows[i]["IdAutomovil"]);
                Automovil.Placa = dtAutomovil.Rows[i]["Placa"].ToString();
                Automovil.TipoV = dtAutomovil.Rows[i]["TipoV"].ToString();
                listAutos.Add(Automovil);
            }
            return listAutos;
        }
        public int mtdRegistrarCliente()
        {
            string consulta = "insert into Automovil(Placa,TipoV) values ('" + Placa + "','" + TipoV + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }

    }
}
