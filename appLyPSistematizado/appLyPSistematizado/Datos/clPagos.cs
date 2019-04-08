using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class clPagos
    {
        public int IdAutomovil { get; set; }
        public DateTime FechaPago { get; set; }
        public string Valor { get; set; }
        clConexion objConexion = new clConexion();
        public int mtdRegistrarAutomovil(int IdAutomovil)
        {
            string consulta = "insert into Pago(FechaPago,Valor,IdAutomovil) values ('" + FechaPago + "','" + Valor + "','" + IdAutomovil + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
    }
}
