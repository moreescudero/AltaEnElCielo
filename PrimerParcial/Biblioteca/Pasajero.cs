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
        float equipaje;
        string clase;

        public Pasajero(string nombre, string apellido, int edad, int dni, float equipaje, string clase) : base(nombre, apellido)
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

        public float Equipaje
        {
            get { return equipaje; }
        }


        public string ElegirMenu()
        {
            return "";
        }

    }
}
