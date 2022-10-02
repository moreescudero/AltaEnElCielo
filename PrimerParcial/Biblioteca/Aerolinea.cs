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
        public static List<Pasajero> listaPasajerosFrecuentes = new List<Pasajero>();
        public static Dictionary<int, Empleado> diccEmpleados = new Dictionary<int, Empleado>();
        public static float gananciaEfectivo;
        public static float gananciaCredito;
        public static float gananciaDebito;

        //List<Equipaje> equipajes;

        public static void InicializarAerolinea()
        {
            Hardcodeo.InicializarEmpleados(diccEmpleados);
            Hardcodeo.InicializarAviones(listaAviones);
            Hardcodeo.InicializarPasajeros(listaPasajeros, diccEmpleados);
            Hardcodeo.InicializarVuelos(listaAviones, listaVuelos, listaPasajeros);
            Hardcodeo.InicializarHistorialVuelos(listaVuelosFinalizados, listaAviones, listaPasajeros);
            listaPasajerosFrecuentes = CrearListaClientes();
        }

        private static void AgregarVueloFinalizado(Vuelo vuelo)
        {
            vuelo.Disponible = "Finalizado";
            listaVuelosFinalizados.Add(vuelo);
        }

        public static void QuitarVuelosFinalizados()
        {
            DateTime ahora = DateTime.Now;
            foreach (Vuelo vuelo in listaVuelos)
            {
                if (ahora.CompareTo(vuelo.Llegada) > 0)
                {
                    AgregarVueloFinalizado(vuelo);
                }
            }
            for(int i = 0; i < listaVuelos.Count; i++)
            {
                if(listaVuelos is not null)
                {
                    if (listaVuelos[i].Disponible == "Finalizado")
                    {
                        listaVuelos.RemoveAt(i);
                        i--;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public static List<Avion> BuscarAvionesDisponibles(DateTime salida)
        {
            List<Avion> aviones = new List<Avion>();

            foreach (Avion avion in listaAviones)
            {
                aviones.Add(avion);
                for (int i = 0; i < listaVuelos.Count; i++)
                {
                    if (listaVuelos[i].Salida.CompareTo(salida) < 0 && listaVuelos[i].Llegada.CompareTo(salida) > 0 && listaVuelos[i].Equals(avion))
                    {
                        aviones.Remove(avion);
                        break;
                    }
                }
            }
            return aviones;
        }

        public static List<Vuelo> FiltrarVuelos(EDestinos origen, EDestinos llegada, int cantPasajeros, string clase)
        {
            List<Vuelo> filtro = new List<Vuelo>();
            for (int i = 0; i < listaVuelos.Count; i++)
            {
                if (origen.CompareTo(listaVuelos[i].Origen) == 0 && llegada.CompareTo(listaVuelos[i].Destino) == 0 && listaVuelos[i].BodegaDisponible > 0 && ((clase == "Turista" && listaVuelos[i].AsientosTuristaDisponibles >= cantPasajeros) || (clase == "Premium" && listaVuelos[i].AsientosPremiumDisponibles >= cantPasajeros)))
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

        public static float CalcularRecaudado(List<Pasajero> lista)
        {
            float recaudacion = 0;

            foreach (Pasajero pasajero in lista)
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

        private static int Comparar(string destino, Vuelo vuelo)
        {
            if (vuelo.Destino.ToString() == destino)
            {
                return vuelo.ListaPasajeros.Count();
            }
            return 0;
        }

        private static int BuscarDestino(string destino)
        {
            int contador = 0;
            //int cantidad = 0;
            foreach (Vuelo vuelo in listaVuelos)
            {
                contador += Comparar(destino, vuelo);
                //if(destino == vuelo.Destino.ToString())
                //{
                //    contador+= vuelo.ListaPasajeros.Count();
                //}
            }
            foreach (Vuelo vuelo in listaVuelosFinalizados)
            {
                contador += Comparar(destino, vuelo);
                //if (destino == vuelo.Destino.ToString())
                //{
                //    contador += vuelo.ListaPasajeros.Count();
                //}
            }
            return contador;
        }

        public static string? BuscarDestinoMasPopular()
        {
            int contador;
            int maximo = -1;
            string? destinoPopular = "";
            foreach (string? destino in Enum.GetNames(typeof(EDestinos)))
            {
                contador = BuscarDestino(destino);
                if (contador > maximo)
                {
                    maximo = contador;
                    destinoPopular = destino;
                }
                else if(contador == maximo)
                {
                    destinoPopular += ", " + destino;
                }

            }
            return destinoPopular;
        }

        private static float SumarGanancia(string destino, Vuelo vuelo)
        {
            if (vuelo.Destino.ToString() == destino)
            {
                return vuelo.Recaudado;
            }
            return 0;
        }

        public static float BuscarRecaudacionPorDestino(string destino)
        {
            float recaudacion = 0;

            foreach (Vuelo vuelo in listaVuelos)
            {
                recaudacion += SumarGanancia(destino, vuelo);
            }
            foreach (Vuelo vuelo in listaVuelosFinalizados)
            {
                recaudacion += SumarGanancia(destino, vuelo);
            }
            return recaudacion;
        }


        public static float CalcularGanancia()
        {
            return CalcularGanancia(true) + CalcularGanancia(false);
        }

        private static void SumarVuelosAPasajero(Pasajero pasajero, Vuelo vuelo)
        {
            foreach (Pasajero pasajero1 in vuelo.ListaPasajeros)
            {
                if (pasajero1.Equals(pasajero)) //uso equals
                {
                    pasajero.CantidadDeVuelos++;
                }
                break;
            }
        }

        public static List<Pasajero> CrearListaClientesPlatino()
        {
            List<Pasajero> pasajeroRetorno = new List<Pasajero>();
            int maximo = -1;

            foreach (Pasajero pasajero in listaPasajerosFrecuentes)
            {
                if (pasajero.CantidadDeVuelos > maximo)
                {
                    maximo = pasajero.CantidadDeVuelos;
                }
            }
            foreach (Pasajero pasajero in listaPasajerosFrecuentes)
            {
                if (pasajero.CantidadDeVuelos >= maximo)
                {
                    pasajeroRetorno.Add(pasajero);
                }
            }

            return pasajeroRetorno;
        }

        private static List<Pasajero> CrearListaClientes()
        {
            List<Pasajero> pasajerosClientes = new List<Pasajero>();

            foreach (Pasajero pasajero in listaPasajeros)
            {
                foreach (Vuelo vuelo in listaVuelos)
                {
                    SumarVuelosAPasajero(pasajero, vuelo);
                }
                foreach (Vuelo vuelo in listaVuelosFinalizados)
                {
                    SumarVuelosAPasajero(pasajero, vuelo);
                }
                if(pasajero.CantidadDeVuelos >= 3)
                {
                    pasajerosClientes.Add(pasajero);
                }
            }

            return pasajerosClientes;
        }

        public static List<Vuelo> BuscarVueloMayorRecaudacion()
        {
            List<Vuelo> vuelos = new List<Vuelo>();
            float maximo = -1;

            foreach(Vuelo vuelo in listaVuelos)
            {
                if(vuelo.Recaudado > maximo)
                {
                    maximo = vuelo.Recaudado;
                    vuelos.Add(vuelo);
                }
            }
            foreach(Vuelo vuelo in listaVuelosFinalizados)
            {
                if (vuelo.Recaudado > maximo)
                {
                    maximo = vuelo.Recaudado;
                    vuelos.Add(vuelo);
                }
            }

            return vuelos;
        }
    }
}
