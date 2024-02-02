using CLases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public class LectorDeProductos
    {
        AccesoADatos  datos = new AccesoADatos();

        public List<Productos> listar()
        {
            List<Productos> lista = new List<Productos>();
            try
            {
                datos.SetearConsultaConSorage("GetPruductosVista");
                while (datos.Lector.Read())
                {
                    Productos aux = new Productos();

                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Valor = (decimal)datos.Lector["Valor"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void UpdateProductos(Productos producto)
        {
            try
            {
                datos.SetearConsultaConSorage("UpdateProducto");

                datos.setearParametro("@Id", producto.Id);
                datos.setearParametro("@Nombre", producto.Nombre);
                datos.setearParametro("@Descripcion", producto.Descripcion);
                datos.setearParametro("@Precio", producto.Precio);
                datos.setearParametro("@Valor", producto.Valor);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CreateProducto(Productos producto)
        {
            try
            {
                datos.SetearConsultaConSorage("InsertProducto");

                datos.setearParametro("@Id", producto.Id);
                datos.setearParametro("@Nombre", producto.Nombre);
                datos.setearParametro("@Descripcion", producto.Descripcion);
                datos.setearParametro("@Precio", producto.Precio);
                datos.setearParametro("@Valor", producto.Valor);
                datos.setearParametro("@ProveeedorId", producto.ProvedoorId);



                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void DeleteProducto(int Id)
        {
            try
            {
                datos.SetearConsultaEmbebida("Delete  From Producto where Id =@Id");
                datos.setearParametro("Id", Id);
                datos.EjecturarLectura();
            }
            catch (Exception ex)
            {

                throw ex;
            }



        }

    }
}
