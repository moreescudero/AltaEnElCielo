using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Usuario
    {
        int id;
        string? nombreUsuario;
        string? contraseña;
        List<Carta> cartas;
        List<Carta> cartasJugadas;
        Carta cartaJugada;
        bool cantoEnvido = false;
        bool cantoTruco = false;
        bool cantoRetruco = false;
        bool cantoQuieroVale4 = false;
        int puntosPartida;
        int manosGanadas;
        int partidasGanadas;
        int partidasPerdidas;

        public Usuario(int id, string? nombreUsuario, string? contraseña)
        {
            this.id = id;
            this.contraseña = contraseña;
            this.nombreUsuario = nombreUsuario;
            cartas = new List<Carta>();
            cartasJugadas = new List<Carta>();
        }

        public string? NombreUsuario
        {
            get { return nombreUsuario; }
        }

        public int Id
        {
            get { return id; }
        }

        public bool CantoEnvido
        {
            get { return cantoEnvido; }
            set { cantoEnvido = value; }
        }

        public bool CantoTruco
        {
            get { return cantoTruco; }
            set { cantoTruco = value; }
        }

        public bool CantoRetruco
        {
            get { return cantoRetruco; }
            set { cantoRetruco = value; }
        }

        public bool CantoQuieroVale4
        {
            get { return cantoQuieroVale4; }
            set { cantoQuieroVale4 = value; }
        }

        public List<Carta> Cartas
        {
            get { return cartas; }
            set { cartas = value; }
        }

        public List<Carta> CartasJugadas
        {
            get { return cartasJugadas; }
            set { cartasJugadas = value; }
        }

        public Carta CartaJugada
        {
            get { return cartaJugada; }
            set { cartaJugada = value; }
        }

        public int ManosGanadas
        {
            get { return manosGanadas; }
            set { manosGanadas = value; }
        }

        public int PuntosPartida
        {
            get { return puntosPartida; }
            set { puntosPartida = value; }
        }

        public int PartidasGanadas
        {
            get { return partidasGanadas; }
            set { partidasGanadas = value; }
        }

        public int PartidasPerdidas
        {
            get { return partidasPerdidas; }
            set { partidasPerdidas = value; }
        }

        public bool ComprobarContraseña(string? contraseñaIngresada)
        {
            if (contraseña == contraseñaIngresada)
            {
                return true;
            }
            return false;
        }

    }
}
