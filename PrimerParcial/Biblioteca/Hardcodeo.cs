using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcodeo
    {
        public static void InicializarAviones(List<Avion> aviones)
        {
            aviones.Add(new Avion("MSDK3278", 529, 11, 15027, true));
            aviones.Add(new Avion("PASD1272", 529, 11, 15027, false));
            aviones.Add(new Avion("ASDP7428", 110, 3, 2772, false));
            aviones.Add(new Avion("MKDF5728", 110, 3, 2772, true));
            aviones.Add(new Avion("UCJV1242", 110, 3, 2772, false));
            aviones.Add(new Avion("KCVK0348", 180, 4, 4536, false));
            aviones.Add(new Avion("PÑAS3554", 180, 4, 4536, true));

        }

        public static void InicializarEmpleados(List<Empleado> empleados)
        {
            empleados.Add(new Empleado("more", "escudero", "more", "123"));
            empleados.Add(new Empleado("mati", "barrozo", "mati", "123"));
            empleados.Add(new Empleado("nico", "gil", "nico", "123"));
            empleados.Add(new Empleado("luki", "gaggino", "luki", "123"));

        }

        public static void InicializarPasajeros(List<Pasajero> pasajeros)
        {
            pasajeros.Add(new Pasajero("Maria","Rodriguez",47,20149213,20,"Turista"));
            pasajeros.Add(new Pasajero("Damian","Alvarez",26,39198278,42,"Premium"));
            pasajeros.Add(new Pasajero("Lucia","Petrarca",33,32487938,35, "Premium"));
            pasajeros.Add(new Pasajero("Santiago","Perez",19,49123039,18,"Turista"));
            pasajeros.Add(new Pasajero("Mariano","Lopez",22,42983757,20,"Turista"));
            pasajeros.Add(new Pasajero("Jose","Lopez",88,8239124,38, "Premium"));
            pasajeros.Add(new Pasajero("Facundo","Zarate",46,25333298,18,"Turista"));
            pasajeros.Add(new Pasajero("Nicolas","Pezza",15,51892111,19,"Turista"));
            pasajeros.Add(new Pasajero("Luciana","Fernandez",34,31123908,41, "Premium"));
            pasajeros.Add(new Pasajero("Florencia","Garcia",61,20123843,42, "Premium"));
            pasajeros.Add(new Pasajero("Alejandra","Aguilar",60,20003124,41, "Premium"));
            pasajeros.Add(new Pasajero("Lucio","Alcorta",24,41982898,21,"Turista"));
            pasajeros.Add(new Pasajero("Lucas","Gimenez",30,38128875,21,"Turista"));
            pasajeros.Add(new Pasajero("Martina","Cespedes",57,18230499,17,"Turista"));
        }

        public static void InicializarVuelos(List<Avion> aviones, List<Vuelo> vuelos, List<Pasajero> pasajeros)
        {
            vuelos.Add(new Vuelo(aviones[0],false,Destinos.BuenosAires,Destinos.Roma,new DateTime(2022,10,4,19,30,0), new DateTime(2022, 10, 5, 5, 30, 0), 10, pasajeros));
            vuelos.Add(new Vuelo(aviones[3],true,Destinos.Mendoza,Destinos.Bariloche,new DateTime(2022,10,4,18,0,0), new DateTime(2022, 10, 4, 20, 0, 0), 2, pasajeros));
            vuelos.Add(new Vuelo(aviones[7],true,Destinos.Posadas,Destinos.PuertoMadryn,new DateTime(2022,10,4,17,15,0), new DateTime(2022, 10, 4, 21, 15, 0), 4, pasajeros));
        }
    }
}
