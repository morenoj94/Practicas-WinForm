using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculadora
    {
        public int n1 { get; set; }
        public int n2 { get; set; }

        public Calculadora(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int Suma() { return n1 + n2; }
        public int Resta() { return n1 - n2; }
        public int Multiplicacion() { return n1 * n2; }
        public int Division() { return n1 / n2; }
    }
}
