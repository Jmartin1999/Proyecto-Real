using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class clPagos
    {
        public int mtdRegistrarAutomovil(int IdCliente)
        {
            string consulta = "insert into Automovil(Placa,TipoV,Observaciones,IdCliente) values ('" + Placa + "','" + TipoV + "','" + Observaciones + "','" + IdCliente + "')";
            int cantidad = objConexion.mtdConectado(consulta);
            return cantidad;
        }
    }
}
