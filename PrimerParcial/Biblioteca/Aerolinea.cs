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
            
            foreach(Avion avion in listaAviones)
            {
                aviones.Add(avion);
                for (int i = 0; i < listaVuelos.Count; i++)
                {
                    if (listaVuelos[i].Salida.CompareTo(salida) < 0 && listaVuelos[i].Llegada.CompareTo(salida) > 0 && listaVuelos[i].MatriculaAvion == avion.Matricula)
                    {
                        aviones.Remove(avion);
                        break;
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

        public static void SumarHorasEnVuelo(string matricula, int duracion)
        {
            foreach (Avion avion in listaAviones)
            {
                if (avion.Matricula == matricula)
                {
                    avion.HorasEnVuelo += duracion;
                    break;
                }
            }
        }

        public static float CalcularRecaudado()
        {
            float recaudacion = 0;

            foreach (Pasajero pasajero in listaPasajeros)
            {
                recaudacion += pasajero.PrecioBoleto;
            }

            return recaudacion;
        }

        private static float SumarGanancia(bool esNacional, Vuelo vuelo)
        {
            if (vuelo.EsNacional == esNacional)
            {
                return vuelo.Recaudado;
            }
            return 0;
        }

        public static float CalcularGanancia(bool esNacional)
        {
            float total = 0;

            foreach (Vuelo vuelo in listaVuelos)
            {
                total += SumarGanancia(esNacional, vuelo);
            }

            foreach (Vuelo vuelo in listaVuelosFinalizados)
            {
                total += SumarGanancia(esNacional, vuelo);
            }

            return total;
        }

        //public static string? BuscarDestinoMasPopular()
        //{
        //    string? destino;

        //    for(int i = 0; i < listaVuelosFinalizados.Count(); i++)
        //    {
        //        for(int j = i + 1; j < listaVuelosFinalizados.Count(); j++)
        //        {

        //        }
        //    }

        //    return destino;
        //}

        //public static string BuscarRecaudacionPorDestino(string destino)
        //{

        //}


        public static float CalcularGanancia()
        {
            return CalcularGanancia(true) + CalcularGanancia(false);
        }

    }
}
