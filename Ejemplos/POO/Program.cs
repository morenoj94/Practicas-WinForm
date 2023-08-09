using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Persona : edad, sueldo, nombre
            //int algo;
            //string nombrePerro;
            
            ////Se crea el objeto de tipo persona llamada p1
            //Persona pe = new Persona();
            
            ////Se pide el valor de p1 para asignarlo a p1
            //Console.Write("Escribe a edad de p1: ");
            //pe.setEdad(int.Parse(Console.ReadLine())); // se asigno p1 con el metodo setEdad
            //algo = pe.getEdad(); //Se guarda la edad en la variable algo usando el metodo getEdad
            //Console.WriteLine(algo);
            //Console.ReadKey();

            ////Ahora probamos el objeto perro usando propiedades del objeto o clase
            //Perro pitbul = new Perro(); // creo el objeto pitbul de tipo perro
            //Console.Write("Escribe el nombre de tu perro: ");
            //pitbul.Nombre = Console.ReadLine();//Seteo el atributo nombre usando la propiedad get
            //nombrePerro = pitbul.Nombre;
            //Console.WriteLine("El nombre del perro es: " + nombrePerro);

            Botella Squirt = new Botella("Amarillo", "Aluminio");
            Console.WriteLine("La capacidad es: "+Squirt.Capacidad);
            Console.WriteLine("La capacidad acutual es: "+Squirt.CantidadActual);
            Console.Write("Cuanto quieres recargar la botella: ");
            float monto = Squirt.recargar(int.Parse(Console.ReadLine()));
            Console.WriteLine("La capacidad antual luego de la recarga es de: " + Squirt.CantidadActual);
            Console.WriteLine("El monto a pagar es: {0} dolares", monto);






            Console.ReadKey();

        }
    }
}
