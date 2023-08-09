using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear algunos objetos en el main de Program y probar escribirle datos y mostrar en 
                pantalla el estado del Telefono.
               
             Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.*/

            Telefono telefonoShany = new Telefono("Iphone", "Iphone 6s");
            Telefono telefonoJesus = new Telefono("Xiaomi", "Redmi note 11 pro");

            Console.Write("Introduce el numero de operador del Telefono de Shany (del 1 al 3): ");
            telefonoShany.CodigoOperador = int.Parse(Console.ReadLine());

            Console.Write("Introduce el numero de operador del telefono de Jesus (del 1 al 3): ");
            telefonoJesus.CodigoOperador = int.Parse(Console.ReadLine());

            Console.Write("Introduce el numero de telefono de Shany: ");
            telefonoShany.NumeroTelefonico = Console.ReadLine();

            Console.Write("Introduce el numero de telefono de Jesus: ");
            telefonoJesus.NumeroTelefonico = Console.ReadLine();

            string msjShany = telefonoShany.Llamar();
            string msjJesus = telefonoJesus.Llamar("Shany");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("--------Muestra de estados----------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Datos del telefono de Shany");
            Console.WriteLine("Marca del telefono de Shany: {0}", telefonoShany.Marca);
            Console.WriteLine("Modelo del telefono de Shany: {0}", telefonoShany.Modelo);
            Console.WriteLine("con numero de telefono +{0}-{1}",telefonoShany.CodigoOperador, telefonoShany.NumeroTelefonico);
            Console.WriteLine();
            Console.WriteLine(msjShany+"\n");

            Console.WriteLine("Datos del telefono de Jesus");
            Console.WriteLine("Marca del telefono de Jesus: "+telefonoJesus.Marca);
            Console.WriteLine("Modelo del telefono de Jesus: "+telefonoJesus.Modelo);
            Console.WriteLine("Con numero de telefono +{0}-{1}",telefonoJesus.CodigoOperador, telefonoJesus.NumeroTelefonico);
            Console.WriteLine(msjJesus +"\n");






            Console.ReadLine();
        }
    }
}
