using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appLyPSistematizado.Datos
{
    class clTarifa
    {
        public DataTable mtdListar()
        {
            clConexion objconexion = new clConexion();
            DataTable dtTarifa = new DataTable();
            string consulta = "select * from Tarifa ";
            dtTarifa = objconexion.mtdDesconectado(consulta);
            return dtTarifa;
        }
    }
}
