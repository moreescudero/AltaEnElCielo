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

        public Avion( string? matricula, int cantAsientos, int cantBaños, float capacidadBodega)
        {
            this.matricula = matricula;
            this.cantAsientos = cantAsientos;
            this.cantBaños = cantBaños;
            this.capacidadBodega = capacidadBodega;
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
