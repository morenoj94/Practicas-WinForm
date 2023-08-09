using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Primer lote con 10 registros de productos, cada producto tiene:
                - Codigo de articulo (3 digitos no correlativos)
                - Precio
                - Codigo de marca (del 1 al 10)
            Segundo lote con lasventas de la semana. Cada venta tiene: 
                - Codigo de articulo
                - Cantidad
                - Codigo de cliente
            este lote corta con codigo de cliente igual a 0*/

            //Lo primero que hare es declarar el vector de tipo producto para usar el objeto
            //producto con sus atributos cod de articulo, precio y cod de marca.

            Producto[] productos = new Producto[10];
            Venta venta1 = new Venta();//declaro tambien la variable ventas del tipo Venta


            // cargamos el vector productos pidiendole al usuario los 10 registros de productos.
            for (int i = 0; i < 10; i++)
            {
                productos[i] = new Producto();
                Console.Write("Introduce el codigo de articulo: ");
                productos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.Write("Introduce el precio: ");
                productos[i].Precio = int.Parse(Console.ReadLine());
                Console.Write("Introduce el codigo de marca (del 1 al 10): ");
                productos[i].CodMarca = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            //ahora hare la arquitectura principal para ingresar datos de las ventas
            
            Console.WriteLine("Ahora introducimos los datos de las ventas.");
            Console.Write("Introcuce el codigo de cliente: ");
            venta1.CodigoClientes = int.Parse(Console.ReadLine());
            while (venta1.CodigoClientes != 0)
            {
                Console.Write("introduce el codigo del articulo vendido: ");
                venta1.CodArtVendidos = int.Parse(Console.ReadLine());
                Console.Write("Introduce la cantidad vendida: ");
                venta1.CantidadVendida = int.Parse(Console.ReadLine());
                Console.WriteLine();





                Console.Write("Introduce el codigo de cliente: ");
                venta1.CodigoClientes = int.Parse(Console.ReadLine());
            }


        }
    }
}
