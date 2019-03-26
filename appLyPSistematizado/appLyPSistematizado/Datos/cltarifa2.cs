using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class cltarifa2
    {
        public DataTable mtdListar()
        {
            clConexion objConeexion = new clConexion();
            DataTable dtTarifa = new DataTable();
            string consulta = "select * from Tarifa ";
            dtTarifa = objConeexion.mtdDesconectado(consulta);
            return dtTarifa;
        }
    }
}
