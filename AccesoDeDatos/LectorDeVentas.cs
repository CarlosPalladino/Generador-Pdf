using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLases;
namespace AccesoDeDatos
{
    public class LectorDeVentas
    {

        AccesoADatos datos = new AccesoADatos();

        // falta 
        public List<Venta> listarVentar()
        {
            //// Lista Todas Las ventas de toos
            List<Venta> lista = new List<Venta>();
            try
            {
                datos.SetearConsultaConSorage("");
                while (datos.Lector.Read())
                {
                    Venta aux = new Venta();
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Fecha = (DateTime)datos.Lector["Fecha"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.ProductoId = (int)datos.Lector["ProductoId"];

                    lista.Add(aux);
                }
                return lista;



            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        public void CrearVentar( Venta venta)
        {
            try
            {
                datos.SetearConsultaConSorage("InsertVenta");
                datos.setearParametro("@ProductoId", venta.ProductoId);

                datos.setearParametro("@ProductoId",venta.ProductoId);
                datos.setearParametro("@Cantidad",venta.Cantidad);
                datos.setearParametro("@Precio",venta.Precio);
                datos.setearParametro("@Fecha",venta.Fecha);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        public void EliminarVenta(int Id)
        {

            try
            {
                datos.SetearConsultaEmbebida("Delete From Venta where Id =@Id");
                datos.setearParametro("@Id", Id);


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }










    }

}
