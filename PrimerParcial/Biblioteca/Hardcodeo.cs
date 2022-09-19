using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Hardcodeo
    {
        public static List<Avion> InicializarAviones(List<Avion> aviones)
        {
            aviones.Add(new Avion("MSDK3278", 529, 11, 15027));
            aviones.Add(new Avion("PASD1272", 529, 11, 15027));
            aviones.Add(new Avion("ASDP7428", 110, 3, 2772));
            aviones.Add(new Avion("MKDF5728", 110, 3, 2772));
            aviones.Add(new Avion("UCJV1242", 110, 3, 2772));
            aviones.Add(new Avion("KCVK0348", 180, 4, 4536));
            aviones.Add(new Avion("PÑAS3554", 180, 4, 4536));

            return aviones;

        }

        public static List<Empleado> InicializarEmpleados(List<Empleado> empleados)
        {
            empleados.Add(new Empleado("more", "escudero", "more", "123"));
            empleados.Add(new Empleado("mati", "barrozo", "mati", "123"));
            empleados.Add(new Empleado("nico", "gil", "nico", "123"));
            empleados.Add(new Empleado("luki", "gaggino", "luki", "123"));

            return empleados;
        }

        public static List<Pasajero> InicializarPasajeros(List<Pasajero> pasajeros)
        {
            pasajeros.Add(new Pasajero("Maria","Rodriguez",47,20149213,20,"Turista", 50));
            pasajeros.Add(new Pasajero("Damian","Alvarez",26,39198278,42,"Premium",100));
            pasajeros.Add(new Pasajero("Lucia","Petrarca",33,32487938,35, "Premium", 100));
            pasajeros.Add(new Pasajero("Santiago","Perez",19,49123039,18,"Turista", 50));
            pasajeros.Add(new Pasajero("Mariano","Lopez",22,42983757,20,"Turista", 50));
            pasajeros.Add(new Pasajero("Jose","Lopez",88,8239124,38, "Premium", 100));
            pasajeros.Add(new Pasajero("Facundo","Zarate",46,25333298,18,"Turista", 50));
            pasajeros.Add(new Pasajero("Nicolas","Pezza",15,51892111,19,"Turista", 50));
            pasajeros.Add(new Pasajero("Luciana","Fernandez",34,31123908,41, "Premium", 100));
            pasajeros.Add(new Pasajero("Florencia","Garcia",61,20123843,42, "Premium", 100));
            pasajeros.Add(new Pasajero("Alejandra","Aguilar",60,20003124,41, "Premium", 100));
            pasajeros.Add(new Pasajero("Lucio","Alcorta",24,41982898,21,"Turista", 50));
            pasajeros.Add(new Pasajero("Lucas","Gimenez",30,38128875,21,"Turista", 50));
            pasajeros.Add(new Pasajero("Martina","Cespedes",57,18230499,17,"Turista", 50));

            return pasajeros;
        }

        public static List<Vuelo> InicializarVuelos(List<Avion> aviones, List<Vuelo> vuelos, List<Pasajero> pasajeros)
        {
            vuelos.Add(new Vuelo("MNE156", aviones[0].Matricula,false,Destinos.BuenosAires,Destinos.Roma,new DateTime(2022,10,4,19,30,0), new DateTime(2022, 10, 5, 5, 30, 0), 10, true,pasajeros,0));
            vuelos.Add(new Vuelo("AMA262", aviones[0].Matricula,false,Destinos.BuenosAires,Destinos.Miami,new DateTime(2023,1,3,11,30,0), new DateTime(2023, 1, 3, 23, 30, 0), 12, true,pasajeros,59));
            vuelos.Add(new Vuelo("ROE251", aviones[5].Matricula,true,Destinos.Mendoza,Destinos.Bariloche,new DateTime(2022,10,4,18,0,0), new DateTime(2022, 10, 4, 20, 0, 0), 2, false, pasajeros,17));
            vuelos.Add(new Vuelo("MSK301", aviones[3].Matricula,true,Destinos.Córdoba,Destinos.Posadas,new DateTime(2022,12,13,4,0,0), new DateTime(2022, 12, 13, 7, 0, 0), 3, false, pasajeros,6));
            vuelos.Add(new Vuelo("LPI202", aviones[6].Matricula,true,Destinos.Posadas,Destinos.PuertoMadryn,new DateTime(2022,10,4,17,15,0), new DateTime(2022, 10, 4, 21, 15, 0), 4, false, pasajeros, 27));
            vuelos.Add(new Vuelo("TBY015", aviones[5].Matricula,true,Destinos.Jujuy,Destinos.Ushuaia,new DateTime(2023,3,4,23,45,0), new DateTime(2023, 3, 5, 3, 45, 0), 4, true, pasajeros, 80));
            vuelos.Add(new Vuelo("CHT261", aviones[6].Matricula,true,Destinos.Corrientes,Destinos.SantiagoDelEstero,new DateTime(2022,11,22,13,0,0), new DateTime(2022, 10, 4, 15, 0, 0), 2, false, pasajeros, 9));

            return vuelos;
        }
    }
}
