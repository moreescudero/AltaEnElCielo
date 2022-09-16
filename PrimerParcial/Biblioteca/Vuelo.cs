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
        string? matriculaAvion;
        bool esNacional;
        Destinos origen;
        Destinos destino;
        DateTime salida;
        DateTime llegada;
        int duracion;
        int asientosDisponibles;
        float recaudado; // recaudacion por pasaje vendido
        bool hayComida;
        //atributos cosas extras ?? wifi/menu vegano, celiaco, etc/televisor ? 
        List<Pasajero> listaPasajeros;

        public Vuelo(string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, bool hayComida, List<Pasajero> listaPasajeros, int asientosDisponibles)
        {
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

        public Vuelo(string? matriculaAvion, bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, float recaudado, bool hayComida, List<Pasajero> listaPasajeros, int asientosDisponibles) :this(matriculaAvion, esNacional, origen, destino, salida, llegada, duracion, hayComida, listaPasajeros, asientosDisponibles)
        {
            this.recaudado = recaudado;
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
            get { return esNacional; } //si es internacional origen solo puede ser bs as
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

        public void RestarAsientosDisponibles(int asientosOcupados)
        {
            AsientosDisponibles -= asientosOcupados;
        }

        public int AsignarDuracion()//puedo reutilizar para hacer volver a los aviones
        {
            Random random = new Random();
            int rnd;
            if (((int)destino) > 100)
            {
                rnd = random.Next(1,5);
            }
            else
            {
                rnd = random.Next(7, 13);
            }

            return rnd;
        }

        public DateTime CalcularLlegada()
        {
            return salida.AddHours(AsignarDuracion());
        }

        private float CalcularPrecioSegunClase(string clase, float precio)
        {
            if(clase == "Premium")
            {
                precio *= 1.15f;
            }
            return precio;
        }

        public float CalcularPrecio(string clase)
        {
            float precioTotal;
            float precioHora;
            
            if(((int)destino) > 100)
            {
                precioHora = 50f;
            }
            else
            {
                precioHora = 100f;
            }

            precioTotal = CalcularPrecioSegunClase(clase, precioHora);
            precioTotal *= duracion;

            return precioTotal;
        }

        public float CalcularRecaudacion(float unPasaje)
        {
            return recaudado += unPasaje;
        }
        
    }
}
