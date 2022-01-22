using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimoExamen
{
    public class Impresora
    {
        public Impresora()
        {
        }

        public void ImprimirDatosCliente(Cliente cliente)
        {

            Console.WriteLine(cliente.Apellidos + cliente.Nombres);

            //return cliente.Nombres + " " + cliente.Apellidos;
        }
    }
}
