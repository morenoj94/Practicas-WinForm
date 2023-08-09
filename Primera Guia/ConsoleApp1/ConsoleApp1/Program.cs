using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crea una clase llamada marino con un método que sea hablar y que diga hola... 
             * Luego crea clase pulpo que herede de marino y el método hablar dirá soy un pulpo y 
             * luego creo una clase foca que hereda de marino y que tenga un atributo llamado msj 
             * que diga hola soy foca y pasar ese msj como parámetro*/

            ////creo que objeto marino
            //Marino m1 = new Marino();
            ////llamo a la clase marino y uso su metodo para ver el resultado
            //m1.Hablar();

            ////creo el objeto pulpo
            //Pulpo p1 = new Pulpo();
            ////llamo a la clase pulpo y uso su metodo para probar resultado
            //p1.Hablar();

            ////creo que objeto foca
            //Foca f1 = new Foca();
            ////llamo al metodo de marino pero con f1 y dandole el atribito de foca como parametro
            //f1.Hablar(f1.Mensaje);




            /*Crea una clase Fabrica que tenga los atributos: llanta, color y precio, luego crea dos clases que herandan de
             fabrica, Carro y Moto crea un metodo que muestre la cantidad de llanta, corlor y precio de ambos transporte
            luego crea un obj para cada clase y que muestre sus atributos*/

            ////creo los objetos moto y carro
            //Moto moto1 = new Moto("rojo", 300f);
            //Carro carro1 = new Carro("plata", 6500f);

            ////usamos el metodo mostrar caracteristicas para ver si imprime lo solicitado
            //moto1.MostrarCaracteristicas();
            //carro1.MostrarCaracteristicas();







            /*Realiza un programa en el cual se solicite 2 numeros y calcular: suma, resta, multiplicacion y division
             e imprimir cada resultado usado una clase llamada calculadora*/

            //Console.Write("Introduce un primer numero: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.Write("Introduce un segundo numero: ");
            //int n2 = int.Parse(Console.ReadLine());
            //Calculadora cal1 = new Calculadora(n1, n2);
            //Console.WriteLine(" la suma es: " + cal1.Suma());
            //Console.WriteLine(" la resta es: "+ cal1.Resta());
            //Console.WriteLine(" la multiplicacion es: " + cal1.Multiplicacion());
            //Console.WriteLine(" la division es: "+ cal1.Division());


            /*Escribe un programa que muestre por consola los números de 1 a 100 
             * (ambos incluidos y con un salto de línea entre cada impresión), sustituyendo los siguientes:
                 * - Múltiplos de 3 por la palabra "fizz".
                 * - Múltiplos de 5 por la palabra "buzz".
                 * - Múltiplos de 3 y de 5 a la vez por la palabra "fizzbuzz"
                 
            nota: solo puedes usar el operador suma.*/


            //int[] vec1 = new int[100];
            //bool div3, div5;
            //for (int i = 0; i < 100; i++)
            //{
            //    vec1[i] = i + 1;
            //}
            //for (int j = 0; j < vec1.Length; j++)
            //{
            //    div3 = false;
            //    div5 = false;

            //    for (int i = 0; i < vec1[j]; i++)
            //    {
            //        if ((i + i + i) == vec1[j]) div3 = true;
            //        else if ((i + i + i + i + i) == vec1[j]) div5 = !div5;
            //    }
            //    if (div3 && div5) Console.WriteLine("Fizzz-Fuzzz");
            //    else if (div3) Console.WriteLine("Fizzz");
            //    else if (div5) Console.WriteLine("Fuzzz");
            //    else Console.WriteLine(vec1[j]);
            //}

            /*Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Boolean) 
             * según sean o no anagramas.
             * Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
             * NO hace falta comprobar que ambas palabras existan.
             * Dos palabras exactamente iguales no son anagrama.*/



            int n, promedio, contador, acu = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                contador = 0;
                if (true)
                {
                    contador++;
                    acu += n;
                }

                Console.WriteLine("Ingrese otro número: ");
                n = int.Parse(Console.ReadLine());
            }

            promedio = acu / contador;






            string palabra1, palabra2;
            bool anagrama = false;
            Console.Write("Introduce la primera palabra: ");
            palabra1 = Console.ReadLine();            
            Console.Write("Introduce la segunda palabra: ");
            palabra2 = Console.ReadLine();

            palabra1 = palabra1.ToLower();
            palabra2 = palabra2.ToLower();
            
            if (palabra1.Length != palabra2.Length)
            {
                Console.WriteLine("No son anagramas.");
            }
            else if (palabra1 == palabra2)
            {
                Console.WriteLine("No son anagramas.");
            }
            else 
            {
                //Ordeno alfabeticamente los strings y los comparo
                //palabra1 = new string(palabra1.OrderBy(x => x).ToArray());
                //palabra2 = new string(palabra2.OrderBy(x => x).ToArray());
                //if (palabra1 == palabra2)
                //{
                //    anagrama = true;
                //}

                //convierto los string en listas
                List<char> lista1 = palabra1.ToList();
                List<char> lista2 = palabra2.ToList();

                int cont = 0;
                //recorro ambas listas comparando los caracteres de cada lista
                foreach (char caracter2 in lista2)
                {
                    for (int i = 0; i < lista1.Count; i++)
                    {
                        if (caracter2 == lista1[i])
                        {                            
                            cont++;
                            //elimino el elemento que conincidia de la lista 1 para evitar coincidencia repetidas
                            lista1.Remove(lista1[i]);
                            break;
                        }
                    }
                }
                if (cont == lista2.Count)
                {
                    Console.WriteLine("Si son anagramas");
                }
                else
                {
                    Console.WriteLine("No son anagramas");
                }
                // ordeno las listas para probar el metodo sort
                //lista1.Sort();
                //lista2.Sort();
                
            }
            


















            Console.ReadKey();
        }
    }
}
