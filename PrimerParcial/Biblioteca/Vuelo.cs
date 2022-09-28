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
        string? disponible;
        int asientosPremiumDisponibles;
        int asientosTuristaDisponibles;
        float recaudado; // recaudacion total por pasaje vendido
        bool hayComida;
        float bodegaDisponible; 
        List<Pasajero> listaPasajeros;

        public Vuelo(string? codigoVuelo, string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, bool hayComida, int asientosDisponibles, float bodegaDisponible)
        {
            this.codigoVuelo = codigoVuelo;
            this.matriculaAvion = matriculaAvion;
            this.esNacional = esNacional;
            this.origen = origen;
            this.destino = destino;
            this.salida = salida;
            this.hayComida = hayComida;
            this.asientosDisponibles = asientosDisponibles;
            this.asientosPremiumDisponibles = CalcularAsientosPremium();
            this.asientosTuristaDisponibles = CalcularAsientosTurista();
            this.duracion = AsignarDuracion();
            this.llegada = CalcularLlegada();
            listaPasajeros = new List<Pasajero>();
            this.disponible = "disponible";
            this.bodegaDisponible = bodegaDisponible;
        }

        public Vuelo(string? codigoVuelo, string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, bool hayComida, List<Pasajero> listaPasajeros, int asientosDisponibles, int asientosPremiumDisponibles, int asientosTuristaDisponibles, string? disponible, float bodegaDisponible) : this(codigoVuelo, matriculaAvion, esNacional, origen, destino, salida, hayComida, asientosDisponibles, bodegaDisponible)
        {
            this.listaPasajeros = listaPasajeros;
            this.llegada = llegada;
            this.duracion = duracion;
            this.recaudado = Aerolinea.CalcularRecaudado();
            this.asientosTuristaDisponibles = asientosTuristaDisponibles;
            this.asientosPremiumDisponibles = asientosPremiumDisponibles;
            this.disponible = disponible;
        }

        //public Vuelo(string? codigoVuelo, string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, float recaudado, bool hayComida, List<Pasajero> listaPasajeros, int asientosDisponibles) :this(codigoVuelo, matriculaAvion, esNacional, origen, destino, salida, llegada, duracion, hayComida, listaPasajeros, asientosDisponibles)
        //{
        //    this.recaudado = recaudado;
        //    this.asientosDisponibles = RestarAsientosDisponibles();
        //}

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
            //set { recaudado = value; }
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public List<Pasajero> ListaPasajeros
        {
            get { return listaPasajeros; }
            set { listaPasajeros = value; }
        }

        public int AsientosDisponibles
        {
            get { return asientosDisponibles; }
        }

        public string? Disponible
        {
            get { return disponible; }
            set { disponible = value; }
        }

        public int AsientosPremiumDisponibles
        {
            get { return asientosPremiumDisponibles; }
        }

        public int AsientosTuristaDisponibles
        {
            get { return asientosTuristaDisponibles; }
        }

        public float BodegaDisponible
        {
            get { return bodegaDisponible; }
        }

        public override bool Equals(object? obj)
        {
            Vuelo vuelo = obj as Vuelo;
            if(vuelo is not null) 
            {
                return vuelo.codigoVuelo == this.codigoVuelo;
            }
            return false;
        }
        public override string ToString()
        {
            return "Codigo de Vuelo: " + this.codigoVuelo + "  Matricula avion: " + this.matriculaAvion + "  Recaudado: " + this.recaudado + " Destino: " + this.destino;
        }

        public void RestarAsientosYBodega(string clase, float equipaje)
        {
            if(clase == "Premium")
            {
                asientosPremiumDisponibles--;
            }
            else
            {
                asientosTuristaDisponibles--;
            }
            asientosDisponibles--;

            bodegaDisponible -= equipaje;
        }

        public static string GeneradorCodigoVuelo()
        {
            Random rnd = new Random();
            StringBuilder codigo = new StringBuilder();

            for(int i = 0; i < 6; i++)
            {
                if(i > 2)
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


        private int AsignarDuracion()
        {
            Random random = new Random();
            int rnd;
            if (esNacional)
            {
                rnd = random.Next(2, 5);
            }
            else
            {
                rnd = random.Next(8, 13);
            }

            Aerolinea.SumarHorasEnVuelo(matriculaAvion, rnd);

            return rnd;
        }

        private int CalcularAsientosPremium()
        {
            return (int)(asientosDisponibles * 0.2);
        }

        private int CalcularAsientosTurista()
        {
            return (int)(asientosDisponibles * 0.8);
        }

        public void CambiarANoDisponible()
        {
            if(asientosDisponibles == 0)
            {
                disponible = "Lleno";
            }
            if(salida.CompareTo(DateTime.Now) == 0 || salida.CompareTo(DateTime.Now) > 0)
            {
                disponible = "En Vuelo";
            }
        }

        public void SumarRecaudacion(float ganancia)
        {
            if (ganancia > 0)
            {
                recaudado += ganancia;
            }
        }

        private DateTime CalcularLlegada()
        {
            DateTime llegada = salida.AddHours(duracion);
            int dia = int.Parse(salida.Day.ToString());
            int mes = int.Parse(salida.Month.ToString());

            if (int.Parse(salida.Hour.ToString()) +  int.Parse(llegada.Hour.ToString()) >= 24)
            {
                llegada.AddDays(1);
                if ((dia == 31 && (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10)) || (dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11)) || (dia == 28 && mes == 2))
                {
                    llegada.AddMonths(1);
                }
                else if (dia == 31 && mes == 12)
                {
                    llegada.AddYears(1);
                }
            }
            return llegada;
        }
        
    }
}
