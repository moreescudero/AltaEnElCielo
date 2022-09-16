using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Aerolinea
    {
        static List<Avion> listaAviones;
        static List<Vuelo> listaVuelos;
        static List<Pasajero> listaPasajeros;
        //List<Equipaje> equipajes;

        public static void InicializarAerolinea(List<Avion> aviones, List<Vuelo> vuelos, List<Pasajero> pasajeros)
        {
            listaAviones = Hardcodeo.InicializarAviones(aviones);
            listaPasajeros = Hardcodeo.InicializarPasajeros(pasajeros);
            listaVuelos = Hardcodeo.InicializarVuelos(aviones, vuelos, pasajeros);
        }

        public static void AgregarVuelo(Vuelo vuelo)
        {
            listaVuelos.Add(vuelo);
        }

        public static List<Vuelo> FiltrarVuelos(Destinos origen, Destinos llegada, int cantPasajeros)
        {
            List<Vuelo> filtro = new List<Vuelo>();
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                if (origen.CompareTo(listaVuelos[i].Origen) == 0 && llegada.CompareTo(listaVuelos[i].Destino) == 0 && listaVuelos[i].AsientosDisponibles >= cantPasajeros)
                {
                    filtro.Add(listaVuelos[i]);
                }
            }
            return filtro;
        }

    }
}
