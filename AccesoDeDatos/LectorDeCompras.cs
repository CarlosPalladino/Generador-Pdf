using AccesoDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLases
{
    //Compras que hace el proveedor 
    public class LectorDeCompras
    {
        AccesoADatos datos = new AccesoADatos();
        public void CrearCompra(Compras compra)
        {
            try
            {
                datos.SetearConsultaConSorage("InsertCompra");
                datos.setearParametro("@Íd", compra.Id);
                datos.setearParametro("@Proveedorid", compra.PoveedorId);
                datos.setearParametro("@ProductoId", compra.ProductoId);
                datos.setearParametro("@Cantidad", compra.Cantidad);
                datos.setearParametro("@Fecha", compra.Fecha);
                datos.setearParametro("@Precio", compra.Precio);

                datos.ejecutarAccion();



            }
            catch (Exception)
            {

                throw;
            }
        }
        public void EliminarProductor(int Id)
        {
            try
            {
                datos.SetearConsultaEmbebida("Delete From Compra where Id =@Id");

                datos.setearParametro("@id", Id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }

}

