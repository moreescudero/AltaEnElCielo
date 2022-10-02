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
        float costoTotalEnBoletos = 0;
        bool bolsoMano;
        int cantidadDeVuelos;
        string medioDePago;
        //Empleado usuarioVendedor;

        public Pasajero(string nombre, string apellido, int edad, int dni, float equipaje, string clase, string menuElegido, float precioBoleto, bool bolsoMano, Empleado usuarioVendedor) : base(nombre, apellido)
        {
            this.edad = edad;
            this.dni = dni;
            this.equipaje = equipaje;
            this.clase = clase;
            this.menuElegido = menuElegido;
            this.precioBoleto = precioBoleto;
            this.bolsoMano = bolsoMano;
            usuarioVendedor.Calcular(precioBoleto);
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
            set { precioBoleto = value; }
        }

        public bool BolsoMano
        {
            get { return bolsoMano; }
        }

        public int CantidadDeVuelos
        {
            get { return cantidadDeVuelos; }
            set { cantidadDeVuelos = value; }
        }

        public string MedioDePago
        {
            set { medioDePago = value; }
        }

        public override bool Equals(object? obj)
        {
            Pasajero? pasajero = obj as Pasajero;
            if(pasajero is not null)
            {
                return this.dni == pasajero.GetHashCode();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return this.dni;
        }

        //hacer el calculo de todo lo que haya gastado un pasajero en boletos
        public override void Calcular(float precio)
        {
            this.costoTotalEnBoletos += precio;
        }

        public override string ToString()
        {
            return "Nombre completo: " + base.ToString() + "  Cantidad de vuelos: " + this.cantidadDeVuelos + " Gasto total en boletos: $" + this.costoTotalEnBoletos;
        }

        public static float CalcularPrecio(bool esNacional, int duracion, string clase)
        {
            float costoPasaje;

            if (esNacional)
            {
                costoPasaje = 50f;
            }
            else
            {
                costoPasaje = 100f;
            }
            if (clase == "Premium")
            {
                costoPasaje *= 1.15f;
            }
            if(duracion > 0)
                costoPasaje *= duracion;


            return costoPasaje;
        }

    }
}
