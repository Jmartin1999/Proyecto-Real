using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace appLyPSistematizado.Datos
{
    class clConexion
    {
        SqlConnection conexion;
        SqlDataAdapter adaptador;

        public clConexion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=DESKTOP-V4R265P;Initial Catalog=proyecto;Integrated Security=True");

            }
            catch (Exception)
            {

                throw;
            }
        }
        public DataTable mtdDesconectado(string consulta)//Select
        {
            conexion.Open();
            adaptador = new SqlDataAdapter(consulta, conexion);
            DataTable dtDatos = new DataTable();
            adaptador.Fill(dtDatos);
            conexion.Close();
            return dtDatos;
        }
        public int mtdConectado(string consulta)//insert,update,delete
        {
            try
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);
                int validar = comando.ExecuteNonQuery();
                conexion.Close();
                return validar;
            }
            catch (Exception err)
            {
                string error = err.Message;
                return 0;
            }
           


        }
    }
}
