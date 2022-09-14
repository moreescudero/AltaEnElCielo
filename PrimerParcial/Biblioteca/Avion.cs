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
        bool enVuelo;

        public Avion( string? matricula, int cantAsientos, int cantBaños, float capacidadBodega, bool enVuelo)
        {
            this.matricula = matricula;
            this.cantAsientos = cantAsientos;
            this.cantBaños = cantBaños;
            this.capacidadBodega = capacidadBodega;
            this.enVuelo = enVuelo;
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

        public bool EnVuelo
        {
            get { return enVuelo; }
        }

        public int CalcularAsientosPremium(int capacidadTotal)
        {
            return (int)(capacidadTotal * 0.2);
        }



    }
}
