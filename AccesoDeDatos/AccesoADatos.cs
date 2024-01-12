using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class AccesoADatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;

        public SqlDataReader Lector
        {
            get
            {
                return Lector;

            }
        }


        public AccesoADatos()
        {
            conexion = new SqlConnection("Data Source=Carllosspc\\SQLEXPRESS;Initial Catalog=FacturasPdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            comando = new SqlCommand("");

        }
        public void SetearConsultaConSorage(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;


        }
        public void EjecturarLectura()
        {
            comando.Connection = conexion;

            try
            {
                conexion.OpenAsync();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw new Exception("");
            }

        }



        public void cerrarLectura()
        {
            if (lector != null)
            {
                lector.Close();
                conexion.Close();
            }

        }

        public void ejecutarAccion()
        {
            comando.Connection = conexion;
            try
            { 
                EjecturarLectura();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void setearParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }


    }
}
