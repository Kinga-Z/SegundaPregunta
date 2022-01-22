using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoExamen
{
    public class StockProductos
    {

        public StockProductos()
        {
            this.ListaStockProductos = new List<Producto>();
        }

        public List<Producto> ListaStockProductos { get; set; }

        public void CrearProductos()
        {
            Random random = new Random();
            int numero;
            int exis;
            for (int i = 1; i <= 10; i++)
            {

                Producto producto = new Producto();
                producto.Identificador = i;
                numero = random.Next(20);
                exis = random.Next(10);
                char letra = (char)(((int)'A') + random.Next(26));
                producto.Descripcion = "PRODUCTO" + letra + numero + i;
                producto.Precio = numero;
                producto.Existencia = exis;
                this.ListaStockProductos.Add(producto);
            }
        }

        public void ImprimirStockProductos()
        {
            Console.WriteLine("Stock de Productos");
            Console.WriteLine("Identificador\tDescripción\tPrecio\tExistencia");
            List<string> item = (from summoner in ListaStockProductos
                                    orderby summoner.Precio ascending
                                   select "\t" + summoner.Identificador+ "\t" + summoner.Descripcion+ "\t" + summoner.Precio+ "\t" + summoner.Existencia).ToList();
            Console.WriteLine(string.Join("\n", item ));

        }
        public void ProductoMayor()
        {
            Console.WriteLine("");
            var itemM = ListaStockProductos.Max(x => x.Precio );
            Console.WriteLine("Producto precio mas alto: " + itemM);
        }

        public void BuscarProducto()
        {
            Console.WriteLine("Ingrese el ID del producto a buscar");
            int ID = int.Parse(Console.ReadLine());
            var search = from searchproduc in ListaStockProductos
                                       where searchproduc.Identificador == ID
                           select "Producto a buscar: " + searchproduc.Descripcion + " Precio: " + searchproduc.Precio + " Existencia: " + searchproduc.Existencia;
            Console.WriteLine(string.Join("\n", search));
        }






    }
}
