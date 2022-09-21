using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        string menuElegido;
        float precioBoleto;

        public Pasajero(string nombre, string apellido, int edad, int dni, float equipaje, string clase, string menuElegido, float precioBoleto) : base(nombre, apellido)
        {
            this.edad = edad;
            this.dni = dni;
            this.equipaje = equipaje;
            this.clase = clase;
            this.menuElegido = menuElegido;
            this.precioBoleto = precioBoleto;
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

        public string MenuElegido
        {
            get { return menuElegido; }
        }

        public float Equipaje
        {
            get { return equipaje; }
        }

        public float PrecioBoleto
        {
            get { return precioBoleto; }
        }


        public static float CalcularPrecio(int destino, int duracion, string clase)
        {
            float precioHora;

            if (destino > 100)
            {
                precioHora = 50f;
            }
            else
            {
                precioHora = 100f;
            }
            if (clase == "Premium")
            {
                precioHora *= 1.15f;
            }
            precioHora *= duracion;

            return precioHora;
        }

    }
}
