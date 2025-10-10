using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    internal class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get { return lector; }
        }
        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            comando.ExecuteNonQuery();
        }

        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }

        public void cerrarConexion()
        {
            if (lector != null)
                lector.Close();
            conexion.Close();
        }
        public int ejecutarAccionconreturn()
        {
            try
            {
                comando.Connection = conexion;
                return int.Parse(comando.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void limpiarParametros()
        {
            comando.Parameters.Clear();
        }
        public void abrirConexion()
        {
            if (conexion.State != System.Data.ConnectionState.Open)
                conexion.Open();
        }
        public void ejecutarMasAcciones()
        {
            try
            {
                comando.Connection = conexion;
                abrirConexion();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cerrarConexion();
            }
        }
    }
}
