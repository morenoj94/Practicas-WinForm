using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Marino
    {
        public virtual void Hablar() 
        {
            string msj = "hola...";
            Console.WriteLine(msj);
        }

        public virtual void Hablar(string msj)
        {
            Console.WriteLine(msj);
        }
    }
}
