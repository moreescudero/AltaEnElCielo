using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Vuelo
    {
        bool esNacional;
        string destino;
        DateTime salida;
        DateTime llegada;
        int duracion;
        float precio;
        List<Pasajero> listaPasajeros;

        public Vuelo(bool esNacional, string destino, DateTime salida, DateTime llegada, int duracion, float precio, List<Pasajero> listaPasajeros)
        {
            this.esNacional = esNacional;
            this.destino = destino;
            this.salida = salida;
            this.llegada = llegada;
            this.duracion = duracion;
            this.precio = precio;
            this.listaPasajeros = listaPasajeros;
        }

        
    }
}
