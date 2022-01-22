using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoExamen
{
    public class Factura
    {
        public decimal SubTotal { get; set; }
        public decimal Descuento { get; set; }
        public decimal Total { get; set; }

        public Factura()
        {
            this.Detalle = new List<DetalleFactura>();
        }

        //Cabecera de Factura
        public CabeceraFactura Cabecera { get; set; }

        //Detalle de carrito
        //Lista de detalle de carrito (Producto y la cantidad)

        public List<DetalleFactura> Detalle { get; set; }


        public void CalcularSubtotal()
        {
            //Acumulador o sumador
            decimal subtotal = 0;
            foreach (DetalleFactura item in this.Detalle)
            {
                subtotal = subtotal + (item.Cantidad * item.ProductoCarrito.Precio);
            }

            this.SubTotal = subtotal;
        }

        public void CalcularDescuento()
        {
            if (this.SubTotal > 100)
            {
                this.Descuento = this.SubTotal * 0.05M;
            }
            else
            {
                this.Descuento = 0;
            }
        }

        public void CalcularTotal()
        {
            this.Total = this.SubTotal - this.Descuento;
        }





    }
}
