using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Aerolinea
    {
        static List<Avion> aviones;
        static List<Vuelo> vuelos;
        static List<Pasajero> pasajeros;
        //List<Equipaje> equipajes;

        public static void InicializarAerolinea()
        {
            Hardcodeo.InicializarAviones(aviones);
            Hardcodeo.InicializarPasajeros(pasajeros);
            Hardcodeo.InicializarVuelos(aviones, vuelos, pasajeros);
        }
    }
}
