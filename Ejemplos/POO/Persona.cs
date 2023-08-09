using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Persona
    {
        //Persona : edad, sueldo, nombre
        //Propiedades de la clase
        private int edad;
        private float sueldo;
        private string nombre;

        // Se setea y se obtienen los valores de los atributos de la clase usando metodos 
        public void setEdad(int e) 
        {
            edad = e;
        }
        public int getEdad() 
        {
            return edad;
        }
        public void setSueldo(float s) 
        {
            sueldo = s;
        }
        public float getSueldo() 
        {
            return sueldo;
        }
        public void setNombre(string n) 
        {
            nombre = n;
        }
        public string getNombre() 
        {
            return nombre;
        }
    }
}
