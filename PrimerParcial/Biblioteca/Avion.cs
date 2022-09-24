using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Avion
    {
        string? matricula;
        int cantAsientos;
        int cantBaños;
        float capacidadBodega;
        int horasEnVuelo;

        public Avion( string? matricula, int cantAsientos, int cantBaños, float capacidadBodega)
        {
            this.matricula = matricula;
            this.cantAsientos = cantAsientos;
            this.cantBaños = cantBaños;
            this.capacidadBodega = capacidadBodega;
            this.horasEnVuelo = 0;
        }

        public string? Matricula
        {
            get { return matricula; }
        }
        public int CantAsientos
        {
            get { return cantAsientos; }
        }

        public int CantBaños
        {
            get { return cantBaños; }
        }

        public float CapacidadBodega
        {
            get { return capacidadBodega; }
        }

        public int HorasEnVuelo
        {
            get { return horasEnVuelo; }
            set { horasEnVuelo = value; }
        }

        public int CalcularAsientosPremium()
        {
            return (int)(cantAsientos * 0.2);
        }

        public int CalcularAsientosTurista()
        {
            return (int)(cantAsientos * 0.8);
        }

        public int DescontarAsientosDisponibles(int asientosPremium, int asientosTurista, string clase)
        {
            if(clase == "Premium")
            {
                return asientosPremium--;
            }
            return asientosTurista--;
        }
    }
}
