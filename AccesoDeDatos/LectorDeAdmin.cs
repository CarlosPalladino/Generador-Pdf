using CLases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDeDatos
{
    public  class LectorDeAdmin
    {
        AccesoADatos datos = new AccesoADatos();

        public bool Ingesar(Admin admin)
        {
            AccesoADatos datos = new AccesoADatos();
            try
            {
                datos.SetearConsultaEmbebida("Select Nombre, Contrasena From Admin Where Nomree=@nombre and Contrasena =@contra");
                datos.setearParametro("@nombre", admin.Nombre);
                datos.setearParametro("@contrasena", admin.Contrasena);
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }






    }
}
