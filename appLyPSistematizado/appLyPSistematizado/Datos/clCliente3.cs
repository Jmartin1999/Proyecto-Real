using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appLyPSistematizado.Datos
{
    class clCliente3
    {
        public DataTable mtdListar()
        {
            clConexion objconexion = new clConexion();
            DataTable dtCliente = new DataTable();
            string consulta = "select*from Cliente";
            dtCliente = objconexion.mtdDesconectado(consulta);
            return dtCliente;
        }
    }
}
