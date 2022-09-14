using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Destinos
    {
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
        Avion unAvion;
        bool esNacional;
        Destinos origen;
        Destinos destino;
        DateTime salida;
        DateTime llegada;
        int duracion;
        float precio;
        List<Pasajero> listaPasajeros;

        public Vuelo(Avion unAvion,bool esNacional, Destinos origen, Destinos destino, DateTime salida, DateTime llegada, int duracion, float precio, List<Pasajero> listaPasajeros)
        {
            this.unAvion = unAvion;
            this.esNacional = esNacional;
            this.origen = origen;
            this.destino = destino;
            this.salida = salida;
            this.llegada = llegada;
            this.duracion = duracion;
            this.precio = precio;
            this.listaPasajeros = listaPasajeros;
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

        public float Precio
        {
            get { return precio; }
        }

        public int Duracion
        {
            get { return duracion; }
        }

        public int AsignarDuracion()
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

        private float CalcularHoraSegunClase(string clase, float precio)
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

            precioTotal = CalcularHoraSegunClase(clase, precioHora);
            precioTotal *= duracion;

            return precioTotal;
        }
        
    }
}
