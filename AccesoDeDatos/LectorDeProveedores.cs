using CLases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class LectorDeProveedores
    {
        AccesoADatos datos = new AccesoADatos();


        public List<Provedores> listar()
        {
            List<Provedores> lista = new List<Provedores>();
            try
            {
                datos.SetearConsultaConSorage("");
                while (datos.Lector.Read())
                {
                    Provedores aux = new Provedores();

                }


                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void UpdateProveedor(Provedores provedores)
        {
            try
            {
                datos.SetearConsultaConSorage("");
            }
            catch (Exception ex)
            {

                throw ex; 
            }
        }
        public void InsertProveedor()
        {
            try
            {

                return 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeletreProveedor()
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
