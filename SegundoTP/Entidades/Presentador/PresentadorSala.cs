using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades.Presentador
{
    public class PresentadorSala
    {
        ISala sala;
        Partida partida;
        List<Usuario> jugadores;
        public Action delTerminarVuelta;
        int puntos;

        public PresentadorSala (ISala sala)
        {
            this.sala = sala;
            AsignarJugadoresRandom();
            partida = new Partida(jugadores, DateTime.Now);
            jugadores[0].EsMano = true;
            delTerminarVuelta = sala.LimpiarVuelta;
            delTerminarVuelta += partida.FinalizarVuelta;
            delTerminarVuelta += partida.ActivarEvento;
        }

        private void AsignarJugadoresRandom()
        {
            jugadores = new List<Usuario>();
            Random rnd = new Random();
            
            for (int i = 0; i < PresentadorMenuPrincipal.usuarios.Count(); i++)
            {
                if (jugadores.Count < 3)
                {
                    int indice = rnd.Next(0, PresentadorMenuPrincipal.usuarios.Count());
                    if (!jugadores.Contains(PresentadorMenuPrincipal.usuarios[indice]))
                    {
                        jugadores.Add(PresentadorMenuPrincipal.usuarios[indice]);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        public void JugarEnvido()
        {
            if (!jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
            {
                if (jugadores[0].EsMano)
                {
                    VerificarEnvido(0, 1);
                    if(jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido)
                    {
                        sala.ChatJug1 = "Envido";
                    }
                }
                else if (jugadores[1].EsMano)
                {
                    VerificarEnvido(1, 0);
                    if (jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
                    {
                        sala.ChatJug2 = "Envido";
                    }
                }
            }
            else if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido && sala.ChatJug2 == String.Empty)
            {
                if (partida.CantarEnvido(jugadores[1]))
                {
                    sala.ChatJug2 = "Quiero";
                }
                else
                {
                    sala.ChatJug2 = "No quiero";
                    jugadores[0].PuntosPartida++;
                    puntos = jugadores[0].PuntosPartida;
                    sala.PuntosJug1 = puntos.ToString();
                }
            }
            else if (!jugadores[0].CantoEnvido && jugadores[1].CantoEnvido && sala.ChatJug1 == String.Empty)
            {
                if (partida.CantarEnvido(jugadores[0]))
                {
                    sala.ChatJug1 = "Quiero";
                }
                else
                {
                    sala.ChatJug1 = "No quiero";
                    jugadores[1].PuntosPartida++;
                    puntos = jugadores[1].PuntosPartida;
                    sala.PuntosJug2 = puntos.ToString();
                }
            }
            if (sala.DecirEnvido)
            {
                DecirCantEnvido();
            }
            if (sala.ChatJug1 == "No quiero" || sala.ChatJug2 == "No quiero")
            {
                sala.HayEnvido = false;
            }
            else if (sala.ChatJug1 == "Quiero" || sala.ChatJug2 == "Quiero")
            {
                sala.DecirEnvido = true;
            }
        }

        private void VerificarEnvido(int indice, int indiceOtroJug)
        {
            if (partida.CantarEnvido(jugadores[indice]))
            {
                jugadores[indice].CantoEnvido = true;
            }
            else if (partida.CantarEnvido(jugadores[indiceOtroJug]))
            {
                jugadores[indiceOtroJug].CantoEnvido = true;
            }
            else
            {
                sala.HayEnvido = false;
            }
        }
        private void DecirCantEnvido()
        {
            sala.EnvidoJug1 = partida.DecirEnvido(jugadores[0]);
            sala.ChatJug1 = sala.EnvidoJug1.ToString();
            sala.EnvidoJug2 = partida.DecirEnvido(jugadores[1]);
            sala.ChatJug2 = sala.EnvidoJug2.ToString();
            sala.Ganador = partida.DeterminarGanadorEnvido(sala.EnvidoJug1, sala.EnvidoJug2);

            if (sala.Ganador == "Jugador 1 ganó envido")
            {
                jugadores[0].CantoEnvido = true;
                puntos = jugadores[0].PuntosPartida;
                sala.PuntosJug1 = puntos.ToString();
            }
            else
            {
                jugadores[1].CantoEnvido = true;
                puntos = jugadores[1].PuntosPartida;
                sala.PuntosJug2 = puntos.ToString();
            }

            sala.HayEnvido = false;

        }

        public void Jugar()
        {
            if (!sala.SeCantoTruco && !sala.SeContestoTruco || sala.SeCantoTruco && sala.SeContestoTruco)
            {
                if ((jugadores[0].ManosGanadas == 2 || jugadores[1].ManosGanadas == 2) && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count)
                {
                    if (jugadores[0].ManosGanadas == 2)
                    {
                        Ganar(0, 1, "Gano jugador 1", "Felicidades jugador 1, ganaste!");
                    }
                    else
                    {
                        Ganar(1, 0, "Gano jugador 2", "Felicidades jugador 2, ganaste!");
                    }
                    return;
                }
                else if (((jugadores[0].EsMano && !jugadores[1].EsMano && sala.PrimeraMano) || !partida.AsignarTurno() && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count || jugadores[0].Cartas.Count > jugadores[1].Cartas.Count) && jugadores[0].Cartas.Count > 0)
                {
                    if (!sala.SeCantoTruco)
                    {
                        sala.ChatJug1 = CantarTruco(jugadores[0], sala.ChatJug1);
                    }
                    Carta cartaJugada = partida.Jugar(jugadores[0], jugadores[1].CartaJugada);
                    sala.CartasJug1 += cartaJugada.Numero + " " + cartaJugada.Palo + ", ";
                }
                else if ((jugadores[1].EsMano && !jugadores[0].EsMano && sala.PrimeraMano) || jugadores[1].Cartas.Count > 0 || jugadores[0].CantoTruco && !sala.SeContestoTruco)
                {
                    if (!sala.SeCantoTruco)
                    {
                        sala.ChatJug2 = CantarTruco(jugadores[1], sala.ChatJug2);
                    }
                    Carta cartaJugada = partida.Jugar(jugadores[1], jugadores[0].CartaJugada);
                    sala.CartasJug2 += cartaJugada.Numero + " " + cartaJugada.Palo + ", ";
                }
                sala.PrimeraMano = false;
            }
            else if (sala.SeCantoTruco && !sala.SeContestoTruco)
            {
                ContestarTruco();
            }
            partida.SumarPunto();
        }

        public string? CantarTruco(Usuario jugador, string? retorno)
        {
            Random rnd = new Random();
            int decision = rnd.Next(1, 3);
            if (decision == 1)
            {
                jugador.CantoTruco = true;
                retorno = "Truco";
                sala.SeCantoTruco = true;
            }
            return retorno;
        }

        public void ContestarTruco()
        {
            sala.SeContestoTruco = true;
            if (jugadores[0].CantoTruco && !jugadores[1].CantoTruco)
            {
                sala.ChatJug2 = partida.ContestarTruco(jugadores[1]);
                if (sala.ChatJug2 == "No quiero")
                {
                    Ganar(0, 1, "Gano jugador 1", "Felicidades jugador 1, ganaste!");
                    return;
                }
            }
            else if(jugadores[1].CantoTruco && !jugadores[0].CantoTruco)
            {
                sala.ChatJug1 = partida.ContestarTruco(jugadores[0]);
                if (sala.ChatJug1 == "No quiero")
                {
                    Ganar(1, 0, "Gano jugador 2", "Felicidades jugador 2, ganaste!");
                    return;
                }
            }
        }

        public void Ganar(int indice, int indiceOtroJug, string mensajeGanador, string mensajeGanadorPartida)
        {
            //if (jugadores[indice].ManosGanadas == 2 || jugadores[indice].CantoTruco && !jugadores[indiceOtroJug].CantoTruco)
            //{
            if (jugadores[indice].CantoTruco && jugadores[indiceOtroJug].CantoTruco)
            {
                jugadores[indice].PuntosPartida += 2;
            }
            else
            {
                jugadores[indice].PuntosPartida++;
            }
            puntos = jugadores[indice].PuntosPartida;

            //}
            if (sala.DecirEnvido)
            {
                MostrarCartas();
            }
            sala.TerminoVuelta = true;
            if (indice == 0)
            {
                sala.PuntosJug1 = puntos.ToString();
            }
            else
            {
                sala.PuntosJug2 = puntos.ToString();
            }
            if (jugadores[indice].PuntosPartida >= 15)
            {
                sala.Ganador = mensajeGanadorPartida;
                sala.FrenarTimer();
            }
            else
            {
                if (jugadores[indice].EsMano && !jugadores[indiceOtroJug].EsMano)
                {
                    jugadores[indice].EsMano = false;
                    jugadores[indiceOtroJug].EsMano = true;
                }
                else
                {
                    jugadores[indice].EsMano = true;
                    jugadores[indiceOtroJug].EsMano = false;
                }
                sala.Ganador = mensajeGanador;
                delTerminarVuelta();
            }
        }

        public void MostrarCartas()
        {
            if (jugadores[0].Cartas.Count > 0)
            {
                foreach (Carta carta in jugadores[0].Cartas)
                {
                    if (!jugadores[0].CartasJugadas.Contains(carta))
                    {
                        sala.CartasJug1 += carta.Numero + " " + carta.Palo;
                    }
                }
            }
            if (jugadores[1].Cartas.Count > 0)
            {
                foreach (Carta carta in jugadores[1].Cartas)
                {
                    if (!jugadores[1].CartasJugadas.Contains(carta))
                    {
                        sala.CartasJug2 += carta.Numero + " " + carta.Palo;
                    }
                }
            }
            
        }
    }
}
