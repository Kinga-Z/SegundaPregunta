using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoExamen
{
    public class DetalleFactura
    {
        public DetalleFactura()
        {
        }

        public Producto ProductoCarrito { get; set; }

        public int Cantidad { get; set; }

    }
}
