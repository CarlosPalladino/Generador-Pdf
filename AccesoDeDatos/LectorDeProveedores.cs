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

        //Falta

        public List<Provedores> listar()
        {
            List<Provedores> lista = new List<Provedores>();
            try
            {
                datos.SetearConsultaConSorage("GetAll");
                while (datos.Lector.Read())
                {
                    Provedores aux = new Provedores();
                    aux.Nombre = (string)datos.Lector["Nombre"];
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
                datos.SetearConsultaConSorage("UpdateProveedor");
                datos.setearParametro("", provedores.Nombre);
                datos.setearParametro("", provedores.Apellido);
                datos.setearParametro("", provedores.Contacto);


                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void InsertProveedor(Provedores provedores)
        {
            try
            {
                datos.SetearConsultaConSorage("InsertProveedor");
                datos.setearParametro("", provedores.Nombre);
                datos.setearParametro("", provedores.Apellido);
                datos.setearParametro("", provedores.Contacto);



                Provedores aux = new Provedores();



                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeletreProveedor(int Id)
        {
            try
            {
                datos.SetearConsultaEmbebida("Delete From Proveedores where Id = @Id");
                datos.setearParametro("@Id", Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }



    }
}
