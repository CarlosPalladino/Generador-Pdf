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
                datos.setearParametro("",venta.Cantidad);
                datos.setearParametro("",venta.Fecha);
                datos.setearParametro("",venta.Precio);
                datos.setearParametro("",venta.ProductoId);


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ActualizarVenta(Venta venta)
        {
            try
            {
                datos.SetearConsultaConSorage("");
                datos.setearParametro("", venta.Cantidad);
                datos.setearParametro("", venta.Fecha);
                datos.setearParametro("", venta.Precio);
                datos.setearParametro("", venta.ProductoId);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
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
