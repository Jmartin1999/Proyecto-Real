using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appLyPSistematizado.Datos
{
    class clServicio
    {
        public DataTable mtdListar()
        {
            clConexion objconexion = new clConexion();
            DataTable dtServicio = new DataTable();
            string consulta = "select * from Servicio ";
            dtServicio = objconexion.mtdDesconectado(consulta);
            return dtServicio;
        }
    }
}
