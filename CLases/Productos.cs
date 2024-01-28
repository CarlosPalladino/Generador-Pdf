using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLases
{
    public class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public int cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Valor { get; set; }
        public int ProvedoorId { get; set; }

    }
}
