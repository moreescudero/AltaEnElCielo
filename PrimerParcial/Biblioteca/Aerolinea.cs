using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Aerolinea
    {
        public static List<Avion> listaAviones = new List<Avion>();
        public static List<Vuelo> listaVuelos = new List<Vuelo>();
        public static List<Vuelo> listaVuelosFinalizados = new List<Vuelo>();
        public static List<Pasajero> listaPasajeros = new List<Pasajero>();
        //List<Equipaje> equipajes;

        public static void InicializarAerolinea()
        {
            listaAviones = Hardcodeo.InicializarAviones(listaAviones);
            listaPasajeros = Hardcodeo.InicializarPasajeros(listaPasajeros);
            listaVuelos = Hardcodeo.InicializarVuelos(listaAviones, listaVuelos, listaPasajeros);
            listaVuelosFinalizados = Hardcodeo.InicializarHistorialVuelos(listaVuelosFinalizados, listaAviones, listaPasajeros);
        }

        public static void AgregarVuelo(Vuelo vuelo)
        {
            listaVuelos.Add(vuelo);
        }

        private static void AgregarVueloFinalizado(Vuelo vuelo)
        {
            listaVuelosFinalizados.Add(vuelo);
        }

        public static void QuitarVuelosFinalizados()
        {
            DateTime ahora = DateTime.Now;
            foreach(Vuelo vuelo in listaVuelos)
            {
                if(ahora.CompareTo(vuelo.Llegada) > 0)
                {
                    AgregarVueloFinalizado(vuelo);
                    listaVuelos.Remove(vuelo);
                }
            }
        }

        public static List<Avion> BuscarAvionesDisponibles(DateTime salida)
        {
            List<Avion> aviones = new List<Avion>();
            foreach(Vuelo vuelo in listaVuelos)
            {
                if(vuelo.Salida.CompareTo(salida) > 0 || vuelo.Llegada.CompareTo(salida) < 0)
                {
                    for(int i = 0; i < listaVuelos.Count; i++)
                    {
                        for(int j = 0; j < listaAviones.Count; j++)
                        {
                            if (listaVuelos[i].MatriculaAvion == listaAviones[j].Matricula && !aviones.Contains(listaAviones[j]))
                            {
                                aviones.Add(listaAviones[j]);
                            }
                        }
                    }
                }
            }
            return aviones;
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


        //creo que no va aca xd
        public static void AgregarRecaudacion(float ventaPasajes, Vuelo vuelo)
        {
            vuelo.Recaudado += ventaPasajes;
        }

    }
}
