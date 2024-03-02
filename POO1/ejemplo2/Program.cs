using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 reg de prod cada producto tiene:
            // - Codigo Articulo(3 digitos no correlativos)
            // - Precio
            // - Codigo de M arca(1 a 10)
            // Segundo lote con las ventas de la sem. cada vente tiene:
            // - Codigo Articulo
            // - Cantidad
            // - Codigo Cliente (1 al 100)
            //Este lote corta con codigo de cliente cero.
            Articulo[] articulos = new Articulo[10];

            for (int i = 0; i < 3; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("INgrese los datos del producto: ");
                Console.WriteLine("Codigo:");
                articulos[i].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                articulos[i].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Marca 1 al 10");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
            }
            //cargado del vector completo con los 10
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la vneta: ");
            Console.WriteLine("Codigo de cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo de articulo");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad:");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //trabajamos...
            }
        }
    }
}
