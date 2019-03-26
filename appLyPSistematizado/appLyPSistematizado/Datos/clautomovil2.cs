using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class clautomovil2
    {
        public DataTable mtdListar()
        {
            clConexion objConeexion = new clConexion();
            DataTable dtAutomovil = new DataTable();
            string consulta = "select * from Automovil ";
            dtAutomovil = objConeexion.mtdDesconectado(consulta);
            return dtAutomovil;
        }
    }
}
