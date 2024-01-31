using AccesoDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLases
{
    public class LectorDeCompras
    {

        AccesoADatos datos = new AccesoADatos();

        //Falta

        public List<Compras> listar()
        {
            List<Compras> lista = new List<Compras>();
            try
            {


                datos.SetearConsultaConSorage("");
                datos.EjecturarLectura();


                while (datos.Lector.Read())
                {
                    Compras aux = new Compras();

                    //aux.Id = (int)datos.Lector["Id"];


                    lista.Add(aux);

                }
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public void CrearProducto()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void ModificarProducto()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }


        public void EliminarProductor()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }


    }

}

