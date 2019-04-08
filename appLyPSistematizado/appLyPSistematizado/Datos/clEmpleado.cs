using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appLyPSistematizado.Datos
{
    class clEmpleado
    {
        public DataTable mtdListar()
        {
            clConexion conexion = new clConexion();
            DataTable dtempleado = new DataTable();
            string consulta = "Selet *from Persona";
            dtempleado = conexion.mtdDesconectado(consulta);
            return dtempleado;
        }
    }
}
