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

        //pasajeros pero hacer otra lista que sea pasajeros en vuelo
        public static List<Pasajero> InicializarPasajeros(List<Pasajero> pasajeros)
        {
            pasajeros.Add(new Pasajero("Maria","Rodriguez",47,20149213,20,"Turista", "Comun", 50));
            pasajeros.Add(new Pasajero("Damian","Alvarez",26,39198278,42,"Premium", "Comun", 100));
            pasajeros.Add(new Pasajero("Lucia","Petrarca",33,32487938,35, "Premium", "Celiaco", 100));
            pasajeros.Add(new Pasajero("Santiago","Perez",19,49123039,18,"Turista", "Vegetariano", 50));
            pasajeros.Add(new Pasajero("Mariano","Lopez",22,42983757,20,"Turista", "Celiaco", 50));
            pasajeros.Add(new Pasajero("Jose","Lopez",88,8239124,38, "Premium", "Vegano", 100));
            pasajeros.Add(new Pasajero("Facundo","Zarate",46,25333298,18,"Turista", "Comun", 50));
            pasajeros.Add(new Pasajero("Nicolas","Pezza",15,51892111,19,"Turista", "Vegetariano", 50));
            pasajeros.Add(new Pasajero("Luciana","Fernandez",34,31123908,41, "Premium", "Comun", 100));
            pasajeros.Add(new Pasajero("Florencia","Garcia",61,20123843,42, "Premium", "Comun", 100));
            pasajeros.Add(new Pasajero("Alejandra","Aguilar",60,20003124,41, "Premium", "Celiaco", 100));
            pasajeros.Add(new Pasajero("Lucio","Alcorta",24,41982898,21,"Turista", "Celiaco", 50));
            pasajeros.Add(new Pasajero("Lucas","Gimenez",30,38128875,21,"Turista", "Comun", 50));
            pasajeros.Add(new Pasajero("Martina","Cespedes",57,18230499,17,"Turista", "Vegetariano", 50));

            return pasajeros;
        }

        public static List<Vuelo> InicializarVuelos(List<Avion> aviones, List<Vuelo> vuelos, List<Pasajero> pasajeros)
        {
            vuelos.Add(new Vuelo("MNE156", aviones[0].Matricula,false,Destinos.BuenosAires,Destinos.Roma,new DateTime(2022, 10, 4, 19, 30, 0), new DateTime(2022, 10, 5, 5, 30, 0), 10, true,pasajeros,0));
            vuelos.Add(new Vuelo("AMA262", aviones[0].Matricula,false,Destinos.BuenosAires,Destinos.Miami,new DateTime(2023, 1, 3, 11, 30, 0), new DateTime(2023, 1, 3, 23, 30, 0), 12, true,pasajeros,59));
            vuelos.Add(new Vuelo("ROE251", aviones[5].Matricula,true,Destinos.Mendoza,Destinos.Bariloche,new DateTime(2022, 10, 4, 18, 0, 0), new DateTime(2022, 10, 4, 20, 0, 0), 2, false, pasajeros,17));
            vuelos.Add(new Vuelo("MSK301", aviones[3].Matricula,true,Destinos.Córdoba,Destinos.Posadas,new DateTime(2022, 12, 13, 4, 0, 0), new DateTime(2022, 12, 13, 7, 0, 0), 3, false, pasajeros,6));
            vuelos.Add(new Vuelo("LPI202", aviones[6].Matricula,true,Destinos.Posadas,Destinos.PuertoMadryn,new DateTime(2022, 10, 4, 17, 15, 0), new DateTime(2022, 10, 4, 21, 15, 0), 4, false, pasajeros, 27));
            vuelos.Add(new Vuelo("TBY015", aviones[5].Matricula,true,Destinos.Jujuy,Destinos.Ushuaia,new DateTime(2023, 3, 4, 23, 45, 0), new DateTime(2023, 3, 5, 3, 45, 0), 4, true, pasajeros, 80));
            vuelos.Add(new Vuelo("CHT261", aviones[6].Matricula,true,Destinos.Corrientes,Destinos.SantiagoDelEstero,new DateTime(2022, 11, 22, 13, 0, 0), new DateTime(2022, 10, 4, 15, 0, 0), 2, false, pasajeros, 9));

            return vuelos;
        }

        public static List<Vuelo> InicializarHistorialVuelos(List<Vuelo> vuelos, List<Avion> aviones, List<Pasajero> pasajeros)
        {
            vuelos.Add(new Vuelo("PDR928", aviones[4].Matricula, true, Destinos.Corrientes, Destinos.Bariloche, new DateTime(2021, 6, 15, 13, 30, 0), new DateTime(2021, 6, 15, 17, 30, 0), 4, true, pasajeros, 3));
            vuelos.Add(new Vuelo("GSL348", aviones[2].Matricula, true, Destinos.Mendoza, Destinos.Salta, new DateTime(2022, 2, 26, 18, 0, 0), new DateTime(2022, 2, 26, 21, 0, 0), 3, true, pasajeros, 10));
            vuelos.Add(new Vuelo("AOS153", aviones[3].Matricula, false, Destinos.BuenosAires, Destinos.Recife, new DateTime(2022, 5, 20, 10, 0, 0), new DateTime(2022, 5, 20, 18, 0, 0), 8, true, pasajeros, 12));
            vuelos.Add(new Vuelo("WUQ012", aviones[3].Matricula, true, Destinos.Ushuaia, Destinos.PuertoMadryn, new DateTime(2022, 3, 4, 23, 30, 0), new DateTime(2022, 3, 5, 2, 30, 0), 3, false, pasajeros, 4));
            vuelos.Add(new Vuelo("MVN479", aviones[5].Matricula, true, Destinos.Iguazú, Destinos.Córdoba, new DateTime(2021, 9, 19, 0, 30, 0), new DateTime(2021, 9, 19, 2, 30, 0), 2, false, pasajeros, 9));
            vuelos.Add(new Vuelo("USJ463", aviones[1].Matricula, false, Destinos.Roma, Destinos.Recife, new DateTime(2022, 7, 20, 16, 45, 0), new DateTime(2022, 7, 21, 4, 45, 0), 12, true, pasajeros, 8));
            vuelos.Add(new Vuelo("DSI663", aviones[0].Matricula, false, Destinos.BuenosAires, Destinos.Acapulco, new DateTime(2022, 4, 17, 8, 30 , 0), new DateTime(2022, 4, 17, 12, 30, 0), 4, true, pasajeros, 0));
            vuelos.Add(new Vuelo("NCU671", aviones[4].Matricula, true, Destinos.Córdoba, Destinos.Trelew, new DateTime(2021, 12, 23, 10, 15, 0), new DateTime(2021, 12, 23, 14, 15, 0), 4, false, pasajeros, 0));
            vuelos.Add(new Vuelo("KAS342", aviones[0].Matricula, false, Destinos.BuenosAires, Destinos.Miami, new DateTime(2021, 11, 30, 17, 0, 0), new DateTime(2021, 12, 1, 3, 0, 0), 10, true, pasajeros, 4));
            vuelos.Add(new Vuelo("UJW333", aviones[6].Matricula, true, Destinos.SantaRosa, Destinos.Jujuy, new DateTime(2022, 8, 13, 19, 0, 0), new DateTime(2022, 8, 13, 23, 0, 0), 3, false, pasajeros, 2));
            vuelos.Add(new Vuelo("MKV844", aviones[2].Matricula, true, Destinos.PuertoMadryn, Destinos.Posadas, new DateTime(2021, 8, 30, 5, 30, 0), new DateTime(2021, 8, 30, 7, 30, 0), 2, false, pasajeros, 0));
            vuelos.Add(new Vuelo("DSO023", aviones[4].Matricula, false, Destinos.Roma, Destinos.Miami, new DateTime(2022, 1, 20, 16, 0, 0), new DateTime(2022, 1, 21, 3, 0, 0), 11, true, pasajeros, 0));

            return vuelos;
        }
    }
}
