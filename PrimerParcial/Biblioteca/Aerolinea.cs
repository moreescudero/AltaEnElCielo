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
            //foreach(Avion avion in listaAviones)
            //{
            //    int contador = 0;
            //    for (int i = 0; i < listaVuelos.Count; i++)
            //    {
            //        if (listaVuelos[i].Salida.CompareTo(salida) > 0 || listaVuelos[i].Llegada.CompareTo(salida) < 0)
            //        {
            //            if (listaVuelos[i].MatriculaAvion == avion.Matricula && !aviones.Contains(avion))
            //            {
            //                aviones.Add(avion);
            //                break;
            //            }
            //            else if (aviones.Contains(avion))
            //            {
            //                break;
            //            }
            //            else
            //            {
            //                contador++;
            //            }
            //        }
            //    }
            //    if (contador == listaVuelos.Count) // si hay un dia en el que se usa un avion no funciona
            //    {
            //        aviones.Add(avion);
            //    }
            //}
            foreach(Avion avion in listaAviones)
            {
                aviones.Add(avion);
            }
            //en vez de hacer lo de arriba remover los que coincidan en fecha y listo mas sencillo zip zap asi lo hace un profesional niñita

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
