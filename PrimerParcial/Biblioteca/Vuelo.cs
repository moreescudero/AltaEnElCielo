using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Destinos
    {
        BuenosAires,
        SantaRosa,
        Bariloche,
        Corrientes,
        Córdoba,
        Jujuy,
        Mendoza,
        Neuquén,
        Posadas,
        Iguazú,
        Salta,
        SantiagoDelEstero,
        Trelew,
        Tucumán,
        PuertoMadryn,
        Ushuaia,
        Recife = 100,
        Roma,
        Acapulco,
        Miami
    } 

    public class Vuelo
    {
        string? codigoVuelo;
        string? matriculaAvion;
        bool esNacional;
        Destinos origen;
        Destinos destino;
        DateTime salida;
        DateTime llegada;
        int duracion;
        int asientosDisponibles;
        float recaudado; // recaudacion total por pasaje vendido
        bool hayComida;
        //atributos cosas extras ?? wifi/menu vegano, celiaco, etc/televisor ? 
        List<Pasajero> listaPasajeros;

        public Vuelo(string? codigoVuelo, string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, bool hayComida, List<Pasajero> listaPasajeros, int asientosDisponibles)
        {
            this.codigoVuelo = codigoVuelo;
            this.matriculaAvion = matriculaAvion;
            this.esNacional = esNacional;
            this.origen = origen;
            this.destino = destino;
            this.salida = salida;
            this.llegada = llegada;
            this.duracion = duracion;
            this.listaPasajeros = listaPasajeros;
            this.hayComida = hayComida;
            this.asientosDisponibles = asientosDisponibles;
        }

        public Vuelo(string? codigoVuelo, string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, float recaudado, bool hayComida, List<Pasajero> listaPasajeros, int asientosDisponibles) :this(codigoVuelo, matriculaAvion, esNacional, origen, destino, salida, llegada, duracion, hayComida, listaPasajeros, asientosDisponibles)
        {
            this.recaudado = recaudado;
        }

        public string? CodigoVuelo
        {
            get { return codigoVuelo; }
        }

        public string? MatriculaAvion
        {
            get { return matriculaAvion; }
        }

        public bool HayComida
        {
            get { return hayComida; }
        }

        public bool EsNacional
        {
            get { return esNacional; } 
        }

        public Destinos Origen
        {
            get { return origen; }
        }

        public Destinos Destino
        {
            get { return destino; }
        }

        public DateTime Llegada
        {
            get { return llegada; }
        }

        public DateTime Salida
        {
            get { return salida; }
        }

        public float Recaudado
        {
            get { return recaudado; }
            set { recaudado = value; }
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public int AsientosDisponibles
        {
            get { return asientosDisponibles; }
            set { asientosDisponibles = value; }
        }

        public static string GeneradorCodigoVuelo()
        {
            Random rnd = new Random();
            StringBuilder codigo = new StringBuilder();

            for(int i = 0; i > 6; i++)
            {
                if(i > 3)
                {
                    codigo.Insert(codigo.Length,rnd.Next(10));
                }
                else
                {
                    codigo.Insert(codigo.Length, (char)(((int)'A') + rnd.Next(26)));
                }
            }
            return codigo.ToString();
        }

        public void RestarAsientosDisponibles(int asientosOcupados)
        {
            AsientosDisponibles -= asientosOcupados;
        }

        public int AsignarDuracion()//puedo reutilizar para hacer volver a los aviones
        {
            Random random = new Random();
            int rnd;
            if (esNacional)
            {
                rnd = random.Next(2,5);
            }
            else
            {
                rnd = random.Next(8, 13);
            }

            return rnd;
        }

        public DateTime CalcularLlegada()
        {
            DateTime llegada = salida.AddHours(AsignarDuracion());
            int dia = int.Parse(salida.Day.ToString());
            int mes = int.Parse(salida.Month.ToString());

            if (int.Parse(salida.Hour.ToString()) +  int.Parse(llegada.Hour.ToString()) >= 24)
            {
                llegada.AddDays(1);
                if ((dia == 31 && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10)) || (dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 28 && mes == 2))
                {
                    llegada.AddMonths(1);
                }
                if (dia == 31 && mes == 12)
                {
                    llegada.AddYears(1);
                }
            }
            return llegada;
        }
        
    }
}
