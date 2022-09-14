using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pasajero : Persona
    {
        int edad;
        int dni;
        int equipaje;
        string clase;

        public Pasajero(string nombre, string apellido, int edad, int dni, int equipaje, string clase) : base(nombre, apellido)
        {
            this.edad = edad;
            this.dni = dni;
            this.equipaje = equipaje;
            this.clase = clase;
        }

        public string Clase
        {
            get { return clase; }
        }

        public int Edad
        {
            get { return edad; }
        }

        public int Dni
        {
            get { return dni; }
        }

        public int Equipaje
        {
            get { return equipaje; }
        }
    }
}
