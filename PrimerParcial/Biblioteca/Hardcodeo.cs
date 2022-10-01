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

        public static void InicializarEmpleados(Dictionary<int, Empleado> empleados)
        {
            empleados.Add(1, new Empleado("more", "escudero", "more", "123"));
            empleados.Add(2, new Empleado("mati", "barrozo", "mati", "123"));
            empleados.Add(3, new Empleado("nico", "gil", "nico", "123"));
            empleados.Add(4, new Empleado("luki", "gaggino", "luki", "123"));
        }

        //pasajeros pero hacer otra lista que sea pasajeros en vuelo

        //lista pasajeros totales aerolinea
        public static List<Pasajero> InicializarPasajeros(List<Pasajero> pasajeros, Dictionary<int, Empleado> empleados)
        {
            pasajeros.Add(new Pasajero("Maria","Rodriguez",47,20149213,20,"Turista", "Comun", 50, true, empleados[1]));
            pasajeros.Add(new Pasajero("Damian","Alvarez",26,39198278,42,"Premium", "Comun", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Lucia","Petrarca",33,32487938,35, "Premium", "Celiaco", 100, true, empleados[2]));
            pasajeros.Add(new Pasajero("Santiago","Perez",19,49123039,18,"Turista", "Vegetariano", 50, false, empleados[4]));
            pasajeros.Add(new Pasajero("Mariano","Lopez",22,42983757,20,"Turista", "Celiaco", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Jose","Lopez",88,5239124,38, "Premium", "Vegano", 100, true, empleados[4]));
            pasajeros.Add(new Pasajero("Facundo","Zarate",46,25333298,18,"Turista", "Comun", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Nicolas","Pezza",15,50892111,19,"Turista", "Vegetariano", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Luciana","Fernandez",34,31123908,41, "Premium", "Comun", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Florencia","Garcia",61,16123843,42, "Premium", "Comun", 100, true, empleados[4]));
            pasajeros.Add(new Pasajero("Alejandra","Aguilar",60,17003124,41, "Premium", "Celiaco", 100, true, empleados[4]));
            pasajeros.Add(new Pasajero("Lucio","Alcorta",24,41982898,21,"Turista", "Celiaco", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Lucas","Gimenez",30,35955034,21,"Turista", "Comun", 50, true, empleados[1]));
            pasajeros.Add(new Pasajero("Martina","Cespedes",57,18230499,17,"Turista", "Vegetariano", 50, true, empleados[1]));
            pasajeros.Add(new Pasajero("Lucila","Hernandez",27,38129385,20,"Turista", "Comun", 50, true, empleados[3]));
            pasajeros.Add(new Pasajero("Victoria","Andreani",30,35624999,42,"Premium", "Comun", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Lucia","Petrarca",70,6487938,35, "Premium", "Celiaco", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Santino","Juarez",18,50126739,18,"Turista", "Vegetariano", 50, false, empleados[4]));
            pasajeros.Add(new Pasajero("German","Lopez",20,46903427,20,"Turista", "Celiaco", 50, false, empleados[3]));
            pasajeros.Add(new Pasajero("Maximiliano","Brusoti",55,20299114,38, "Premium", "Vegano", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Tomas","Perez",10,54964842,18,"Turista", "Comun", 50, false, empleados[3]));
            pasajeros.Add(new Pasajero("Lautaro","Acosta",13,5281671,19,"Turista", "Vegetariano", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Camila","Quintans",29,35472886,41, "Premium", "Comun", 100, true, empleados[4]));
            pasajeros.Add(new Pasajero("Mayra","Dimasi",29,35152007,42, "Premium", "Comun", 100, true, empleados[2]));
            pasajeros.Add(new Pasajero("Micaela","Vallejos",60,16935724,41, "Premium", "Celiaco", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Agustina","Altieri",26,39050002,21,"Turista", "Celiaco", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Julieta","Orsenigo",40,31896371,21,"Turista", "Comun", 50, true, empleados[1]));
            pasajeros.Add(new Pasajero("Jazmin","Grosano",23,41997597,17,"Turista", "Vegetariano", 50, true, empleados[3]));
            pasajeros.Add(new Pasajero("Ludmila","Ojeda",36,32964712,20,"Turista", "Comun", 50, true, empleados[3]));
            pasajeros.Add(new Pasajero("Ivan","Gendlin",38,31079884,42,"Premium", "Comun", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Francesco","Canteros",33,36759947,35, "Premium", "Celiaco", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Jana","Galli",19,49886039,18,"Turista", "Vegetariano", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Tomas","Alcoba",20,44073757,20,"Turista", "Celiaco", 50, false, empleados[2]));
            pasajeros.Add(new Pasajero("Nicolas","Davila",71,6977612,38, "Premium", "Vegano", 100, true, empleados[4]));
            pasajeros.Add(new Pasajero("Alejo","Altamira",21,43918299,18,"Turista", "Comun", 50, false, empleados[4]));
            pasajeros.Add(new Pasajero("Lucas","ALtamirano",69,9892111,19,"Turista", "Vegetariano", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Pablo","Muñoz",34,31123908,41, "Premium", "Comun", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Luciano","Buttafuoco",61,16243843,42, "Premium", "Comun", 100, true, empleados[2]));
            pasajeros.Add(new Pasajero("Joaquin","Sampini",60,17461124,41, "Premium", "Celiaco", 100, true, empleados[4]));
            pasajeros.Add(new Pasajero("Julian","Martos",24,41902668,21,"Turista", "Celiaco", 50, false, empleados[4]));
            pasajeros.Add(new Pasajero("Pilar","Tomzuck",30,35974875,21,"Turista", "Comun", 50, true, empleados[3]));
            pasajeros.Add(new Pasajero("Ariel","Molina",52,18947209,17,"Turista", "Vegetariano", 50, true, empleados[1]));
            pasajeros.Add(new Pasajero("Paola","Chavez",46,25122213,20,"Turista", "Comun", 50, true, empleados[4]));
            pasajeros.Add(new Pasajero("Francisca","Merello",42,23190578,42,"Premium", "Comun", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Alex","Russel",33,32005838,35, "Premium", "Celiaco", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Aldana","Gardel",18,49188470,18,"Turista", "Vegetariano", 50, false, empleados[4]));
            pasajeros.Add(new Pasajero("Estefania","Albornoz",51,19678004,20,"Turista", "Celiaco", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Nahuel","Seib",82,4967124,38, "Premium", "Vegano", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Rocio","Lavalle",60,17395498,18,"Turista", "Comun", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Martin","Alvarez",39,32805111,19,"Turista", "Vegetariano", 50, false, empleados[2]));
            pasajeros.Add(new Pasajero("Ludovica","Gutierrez",37,32193408,41, "Premium", "Comun", 100, true, empleados[2]));
            pasajeros.Add(new Pasajero("Gimena","Ripolles",41,22102743,42, "Premium", "Comun", 100, true, empleados[1]));
            pasajeros.Add(new Pasajero("Soledad","Ansoar",32,31993104,41, "Premium", "Celiaco", 100, true, empleados[3]));
            pasajeros.Add(new Pasajero("Federico","Vera",28,35989998,21,"Turista", "Celiaco", 50, false, empleados[1]));
            pasajeros.Add(new Pasajero("Carlo","Ortiz",17,50120175,21,"Turista", "Comun", 50, true, empleados[1]));
            pasajeros.Add(new Pasajero("Fernanda","Zorzol",57,18288109,17,"Turista", "Vegetariano", 50, true, empleados[1]));


            return pasajeros;
        }

        public static List<Vuelo> InicializarVuelos(List<Avion> aviones, List<Vuelo> vuelos, List<Pasajero> pasajeros)
        {
            vuelos.Add(new Vuelo("MNE156", aviones[0].Matricula,false,EDestinos.BuenosAires,EDestinos.Roma,new DateTime(2022, 9, 26, 19, 30, 0), new DateTime(2022, 9, 27, 5, 30, 0), 10, true,CargarPasajerosAUnVuelo(pasajeros, false, 10), 0, 0, 0, "Lleno", 0));
            vuelos.Add(new Vuelo("AMA262", aviones[0].Matricula,false,EDestinos.BuenosAires,EDestinos.Miami,new DateTime(2023, 1, 3, 11, 30, 0), new DateTime(2023, 1, 3, 23, 30, 0), 12, true,CargarPasajerosAUnVuelo(pasajeros, false, 12), 59, 10, 49, "Disponible",1645));
            vuelos.Add(new Vuelo("ROE251", aviones[5].Matricula,true,EDestinos.Mendoza,EDestinos.Bariloche,new DateTime(2022, 10, 4, 18, 0, 0), new DateTime(2022, 10, 4, 20, 0, 0), 2, false, CargarPasajerosAUnVuelo(pasajeros, true, 2), 17, 6, 11, "Disponible", 527));
            vuelos.Add(new Vuelo("MSK301", aviones[3].Matricula,true,EDestinos.Córdoba,EDestinos.Posadas,new DateTime(2022, 12, 13, 4, 0, 0), new DateTime(2022, 12, 13, 7, 0, 0), 3, false, CargarPasajerosAUnVuelo(pasajeros, true, 3), 6, 1, 5, "Disponible", 167));
            vuelos.Add(new Vuelo("LPI202", aviones[6].Matricula,true,EDestinos.Posadas,EDestinos.PuertoMadryn,new DateTime(2022, 12, 28, 17, 15, 0), new DateTime(2022, 12, 28, 21, 15, 0), 4, false, CargarPasajerosAUnVuelo(pasajeros, true, 4), 27, 15, 12, "Disponible", 930));
            vuelos.Add(new Vuelo("TBY015", aviones[5].Matricula,true,EDestinos.Jujuy,EDestinos.Ushuaia,new DateTime(2023, 3, 4, 23, 45, 0), new DateTime(2023, 3, 5, 3, 45, 0), 4, true, CargarPasajerosAUnVuelo(pasajeros, true, 4), 80, 39, 41, "Disponible", 2663));
            vuelos.Add(new Vuelo("CHT261", aviones[6].Matricula,true,EDestinos.Corrientes,EDestinos.SantiagoDelEstero,new DateTime(2022, 11, 22, 13, 0, 0), new DateTime(2022, 11, 22, 15, 0, 0), 2, false, CargarPasajerosAUnVuelo(pasajeros, true, 2), 9, 9, 0, "Disponible", 378));

            return vuelos;
        }

        private static List<Pasajero> CargarPasajerosAUnVuelo(List<Pasajero> pasajeros, bool esNacional, int duracion)
        {
            Random rnd = new Random();
            int index = rnd.Next(0, pasajeros.Count());
            List<Pasajero> lista = new List<Pasajero>();
            lista = pasajeros.GetRange(index, rnd.Next(1, pasajeros.Count() - index));

            foreach (Pasajero pasajero in lista)    
            {
                pasajero.PrecioBoleto = Pasajero.CalcularPrecio(esNacional,duracion, pasajero.Clase);
                pasajero.Calcular(pasajero.PrecioBoleto);
            }

            return lista;
        }

        public static List<Vuelo> InicializarHistorialVuelos(List<Vuelo> vuelos, List<Avion> aviones, List<Pasajero> pasajeros)
        {
            vuelos.Add(new Vuelo("PDR928", aviones[4].Matricula, true, EDestinos.Corrientes, EDestinos.Bariloche, new DateTime(2021, 6, 15, 13, 30, 0), new DateTime(2021, 6, 15, 17, 30, 0), 4, true, CargarPasajerosAUnVuelo(pasajeros, true, 4), 3, 0, 3, "Finalizado", 75));
            vuelos.Add(new Vuelo("GSL348", aviones[2].Matricula, true, EDestinos.Mendoza, EDestinos.Salta, new DateTime(2022, 2, 26, 18, 0, 0), new DateTime(2022, 2, 26, 21, 0, 0), 3, true, CargarPasajerosAUnVuelo(pasajeros, true, 3), 10, 4, 6, "Finalizado", 318));
            vuelos.Add(new Vuelo("AOS153", aviones[3].Matricula, false, EDestinos.BuenosAires, EDestinos.Recife, new DateTime(2022, 5, 20, 10, 0, 0), new DateTime(2022, 5, 20, 18, 0, 0), 8, true, CargarPasajerosAUnVuelo(pasajeros, false, 8), 12, 2, 10, "Finalizado", 334));
            vuelos.Add(new Vuelo("WUQ012", aviones[3].Matricula, true, EDestinos.Ushuaia, EDestinos.PuertoMadryn, new DateTime(2022, 3, 4, 23, 30, 0), new DateTime(2022, 3, 5, 2, 30, 0), 3, false, CargarPasajerosAUnVuelo(pasajeros, true, 3), 4, 1, 3, "Finalizado", 117));
            vuelos.Add(new Vuelo("MVN479", aviones[5].Matricula, true, EDestinos.Iguazú, EDestinos.Córdoba, new DateTime(2021, 9, 19, 0, 30, 0), new DateTime(2021, 9, 19, 2, 30, 0), 2, false, CargarPasajerosAUnVuelo(pasajeros, true, 2), 9, 0, 9, "Finalizado", 225));
            vuelos.Add(new Vuelo("USJ463", aviones[1].Matricula, false, EDestinos.Roma, EDestinos.Recife, new DateTime(2022, 7, 20, 16, 45, 0), new DateTime(2022, 7, 21, 4, 45, 0), 12, true, CargarPasajerosAUnVuelo(pasajeros, false, 12), 8, 1, 7, "Finalizado", 217));
            vuelos.Add(new Vuelo("DSI663", aviones[0].Matricula, false, EDestinos.BuenosAires, EDestinos.Acapulco, new DateTime(2022, 4, 17, 8, 30 , 0), new DateTime(2022, 4, 17, 12, 30, 0), 4, true, CargarPasajerosAUnVuelo(pasajeros, true, 4), 0, 0, 0, "Finalizado", 0));
            vuelos.Add(new Vuelo("NCU671", aviones[4].Matricula, true, EDestinos.Córdoba, EDestinos.Trelew, new DateTime(2021, 12, 23, 10, 15, 0), new DateTime(2021, 12, 23, 14, 15, 0), 4, false, CargarPasajerosAUnVuelo(pasajeros, true, 4), 0, 0, 0, "Finalizado", 0));
            vuelos.Add(new Vuelo("KAS342", aviones[0].Matricula, false, EDestinos.BuenosAires, EDestinos.Miami, new DateTime(2021, 11, 30, 17, 0, 0), new DateTime(2021, 12, 1, 3, 0, 0), 10, true, CargarPasajerosAUnVuelo(pasajeros, false, 10), 4, 0, 4, "Finalizado", 100));
            vuelos.Add(new Vuelo("UJW333", aviones[6].Matricula, true, EDestinos.SantaRosa, EDestinos.Jujuy, new DateTime(2022, 8, 13, 19, 0, 0), new DateTime(2022, 8, 13, 23, 0, 0), 3, false, CargarPasajerosAUnVuelo(pasajeros, true, 3), 2, 0, 2, "Finalizado", 50));
            vuelos.Add(new Vuelo("MKV844", aviones[2].Matricula, true, EDestinos.PuertoMadryn, EDestinos.Posadas, new DateTime(2021, 8, 30, 5, 30, 0), new DateTime(2021, 8, 30, 7, 30, 0), 2, false, CargarPasajerosAUnVuelo(pasajeros, true, 2), 0, 0, 0, "Finalizado", 0));
            vuelos.Add(new Vuelo("DSO023", aviones[4].Matricula, false, EDestinos.Roma, EDestinos.Miami, new DateTime(2022, 1, 20, 16, 0, 0), new DateTime(2022, 1, 21, 3, 0, 0), 11, true, CargarPasajerosAUnVuelo(pasajeros, false, 11), 0, 0, 0, "Finalizado", 0));

            return vuelos;
        }
    }
}
