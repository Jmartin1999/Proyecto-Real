using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLyPSistematizado.Datos
{
    class clpersona2
    {
        public DataTable mtdListar()
        {
            clConexion objConeexion = new clConexion();
            DataTable dtPersona = new DataTable();
            string consulta = "select * from Persona ";
            dtPersona = objConeexion.mtdDesconectado(consulta);
            return dtPersona;
        }
    }
}
