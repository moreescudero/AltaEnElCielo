using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public class Partida
    {
        int id;
        bool activa = true;
        List<Usuario> jugadores = new List<Usuario>();
        DateTime fecha;
        string? ganador;
        public event Action<List<Carta>> eventoMazo; 
        public event Action eventoFinalizarPartida; 

        public Partida (int id)
        {
            this.id = id;
            activa = true;
            eventoMazo = Barajar;
            eventoMazo += Repartir;
            eventoFinalizarPartida = FinalizarVuelta;
            eventoFinalizarPartida += AsignarPuntos;
            eventoFinalizarPartida += FinalizarPartida;
        }

        public Partida(int id,  string ganador, DateTime fecha) : this (id)
        {
            activa = false;
            this.ganador = ganador;
            this.fecha = fecha;
        }
        public Partida(int id, List<Usuario> jugadores, DateTime fecha) : this(id)
        {
            this.jugadores = jugadores;
            this.fecha = fecha;
        }

        public List<Usuario> Jugadores
        {
            get { return jugadores; }
        }

        public string? Ganador
        {
            get { return ganador; }
            set { ganador = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string? JugadorUno
        {
            get { return jugadores[0].NombreUsuario; }
        }
        
        public string? JugadorDos
        {
            get { return jugadores[1].NombreUsuario; }
        }

        public bool Activa
        {
            get { return activa; }
            set { activa = value; }
        }

        public void ActivarEventoMazo()
        {
            Mazo mazoAux = Serializador<Mazo>.LeerJSon("mazo.json");
            List<Carta> mazo = mazoAux.Mazos;
            eventoMazo(mazo);
            
        }

        public void ActivarEventoFinalizarPartida()
        {
            eventoFinalizarPartida();
        }

        public void Barajar(List<Carta> mazo)
        {
            List<Carta> mazoMezclado = new List<Carta>();
            Random rnd = new Random();
            int indice;

            for (int i = 0; i < 6; i++)
            {
                indice = rnd.Next(0, mazo.Count());
                mazoMezclado.Add(mazo[indice]);
                mazo.RemoveAt(indice);
            }
            mazo.Clear();
            for (int i = 0; i < 6; i++)
            {
                mazo.Add(mazoMezclado[i]);
            }
        }

        public void Repartir(List<Carta> mazo)
        {
            //bool exito = false;
            //do
            //{
            //    try
            //    {
            for (int i = 0; i < mazo.Count; i++)
            {
                if (i < 3)
                {
                    jugadores[0].Cartas.Add(mazo[i]);
                }
                else
                {
                    jugadores[1].Cartas.Add(mazo[i]);
                }
            }
                    //exito = true;
            //    }
            //    catch (ArgumentOutOfRangeException)
            //    { 
            //        jugadores[1].Cartas = new List<Carta>();
            //        exito = false;
            //    }
            //} while (!exito);
        }

        private Carta? TirarCarta(Usuario jugador, Carta cartaContrincante)
        {
            Carta? cartaElegida = null;
            bool gana = false;
            if(jugadores[0].Cartas.Count == jugadores[1].Cartas.Count)
            {
                cartaContrincante = null;
            }
            if (cartaContrincante is not null)
            {
                for (int i = 0; i < jugador.Cartas.Count; i++)
                {
                    if (cartaContrincante.Valor > jugador.Cartas[i].Valor)
                    {
                        gana = true;
                        break;
                    }
                }
            }
            for (int i = 0; i < jugador.Cartas.Count; i++)
            {
                if (cartaContrincante is null || cartaElegida is null || (cartaContrincante is not null && gana))
                {
                    if (cartaElegida is null || cartaElegida.Valor > jugador.Cartas[i].Valor)
                    {
                        cartaElegida = jugador.Cartas[i];
                        if (cartaContrincante is not null && cartaElegida.Valor < cartaContrincante.Valor)
                        {
                            break;
                        }
                    }
                }
                else if (cartaContrincante is not null && !gana)
                {
                    if (cartaElegida.Valor < jugador.Cartas[i].Valor)
                    {
                        cartaElegida = jugador.Cartas[i];
                    }
                }
            }
            return cartaElegida;
        }

        public Carta Jugar(Usuario jugador, Carta cartaContrincante)
        {
            jugador.CartaJugada = TirarCarta(jugador, cartaContrincante);
            jugador.Cartas.Remove(jugador.CartaJugada);
            jugador.CartasJugadas.Add(jugador.CartaJugada);
            return jugador.CartaJugada;
        }

        public void SumarPunto()
        {
            if (jugadores[0].CartaJugada is not null && jugadores[1].CartaJugada is not null)
            {
                if (jugadores[0].CartaJugada.Valor < jugadores[1].CartaJugada.Valor)
                {
                    jugadores[0].ManosGanadas++;
                }
                else if (jugadores[0].CartaJugada.Valor > jugadores[1].CartaJugada.Valor)
                {
                    jugadores[1].ManosGanadas++;
                }
                else
                {
                    if (jugadores[0].CartasJugadas.Count > 0 && jugadores[1].CartasJugadas.Count > 0)
                    {
                        if (jugadores[0].CartasJugadas[0].Valor < jugadores[1].CartasJugadas[0].Valor)
                        {
                            jugadores[0].ManosGanadas++;
                        }
                        else
                        {
                            jugadores[1].ManosGanadas++;
                        }
                    }
                    else
                    {
                        jugadores[0].ManosGanadas++;
                        jugadores[1].ManosGanadas++;
                    }
                }
            }
        }

        public bool CantarEnvido(Usuario jugador)
        {
            for (int i = 0; i < jugador.Cartas.Count; i++)
            {
                for (int j = i + 1; j < jugador.Cartas.Count; j++)
                {
                    if (jugador.Cartas[i].Palo == jugador.Cartas[j].Palo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public int DecirEnvido(Usuario jugador)
        {
            int envido = 0;
            for (int i = 0; i < jugador.Cartas.Count; i++)
            {
                for (int j = i + 1; j < jugador.Cartas.Count; j++)
                {
                    if (jugador.Cartas[i].Palo == jugador.Cartas[j].Palo)
                    {
                        int numeroUno = jugador.Cartas[i].Numero;
                        int numeroDos = jugador.Cartas[j].Numero;
                        if (numeroUno >= 10)
                        {
                            numeroUno = 20;
                        }
                        if (numeroDos >= 10)
                        {
                            numeroDos = 20;
                        }
                        if (numeroUno == 20 || numeroDos == 20)
                        {
                            if (numeroUno == 20 && numeroDos == 20)
                            {
                                envido = 20;
                            }
                            else
                            {
                                envido = numeroUno + numeroDos;
                            }
                        }
                        else
                        {
                            envido = numeroUno + numeroDos + 20;
                        }

                        break;
                    }
                }
            }
            return envido;
        }

        public string? DeterminarGanadorEnvido(int jugadorUno, int jugadorDos)
        {
            string retorno = "";
            if (jugadorUno > jugadorDos || (jugadores[0].EsMano && jugadorUno == jugadorDos))
            {
                jugadores[0].PuntosPartida += 2;
                retorno = "Jugador 1 ganó envido";
            }
            else if (jugadorUno < jugadorDos || (jugadores[1].EsMano && jugadorUno == jugadorDos))
            {
                jugadores[1].PuntosPartida += 2;
                retorno = "Jugador 2 ganó envido";
            }
            return retorno;
        }

        public string? CantarTruco(Usuario jugador, string? mensaje)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 3);
            //foreach (Carta item in jugador.Cartas)
            //{
            if (random == 1)
            {
                jugador.CantoTruco = true;
            }
            //}
            return mensaje;
        }

        public string ContestarTruco(Usuario jugador)
        {
            string mensaje = "";
            List<Carta> cartasTotales = new List<Carta>();
            foreach (Carta item in jugador.Cartas)
            {
                cartasTotales.Add(item);
            }
            foreach (Carta item in jugador.CartasJugadas)
            {
                cartasTotales.Add(item);
            }

            foreach (Carta item in cartasTotales)
            {
                if ((int)item.Valor < 6)
                {
                    mensaje = "Quiero";
                    jugador.CantoTruco = true;
                    break;
                }
                else
                {
                    mensaje = "No quiero";
                }
            }
            return mensaje;
        }

        public bool AsignarTurno()
        {
            if (jugadores[1].CartaJugada is not null && jugadores[0].CartaJugada is not null)
            {
                if (jugadores[0].CartaJugada.Valor < jugadores[1].CartaJugada.Valor)
                {
                    return false;
                }
                return true;
            }
            else if (jugadores[1].CartaJugada is null)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        private void AsignarPuntos()
        {
            if (jugadores[0].PuntosPartida > jugadores[1].PuntosPartida)
            {
                jugadores[0].PartidasGanadas++;
                ganador = jugadores[0].NombreUsuario;
            }
            else
            {
                jugadores[1].PartidasGanadas++;
                ganador = jugadores[1].NombreUsuario;
            }
        }

        public void FinalizarVuelta()
        {
            jugadores.ForEach((x) => x.TerminarVuelta());
        }

        public void FinalizarPartida()
        {
            //FinalizarVuelta();
            //AsignarPuntos();
            jugadores.ForEach((x) => x.TerminarPartida());
        }
    }
}
