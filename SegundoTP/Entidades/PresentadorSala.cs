﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PresentadorSala
    {
        ISala sala;
        Partida partida;
        List<Usuario> jugadores;
        int puntos;

        public PresentadorSala (ISala sala)
        {
            this.sala = sala;
            partida = new Partida(Conexion.ObtenerUsuarios(),DateTime.Now);
            jugadores = partida.Jugadores;
        }

        public void AbarajarYRepartir()
        {
            Mazo mazoAux = Serializador<Mazo>.LeerJSon("mazo.json");
            List<Carta>  mazo = mazoAux.Mazos;
            //mazo = sala.Partidita.Abarajar(mazo);
            //sala.Partidita.Repartir(mazo);            
            mazo = partida.Abarajar(mazo);
            partida.Repartir(mazo);
        }


        public void JugarEnvido()
        {
            if (!jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
            {
                VerificarEnvido();
            }
            else if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido)
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
            else if (!jugadores[0].CantoEnvido && jugadores[1].CantoEnvido)
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
            else if(sala.ChatJug1 == "Quiero" || sala.ChatJug2 == "Quiero")
            {
                sala.DecirEnvido = true;
            }
        }

        private void VerificarEnvido()
        {
            if (partida.CantarEnvido(jugadores[0]))
            {
                jugadores[0].CantoEnvido = true;
                sala.ChatJug1 = "Envido";
            }
            else if (partida.CantarEnvido(jugadores[1]))
            {
                jugadores[1].CantoEnvido = true;
                sala.ChatJug2 = "Envido";
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
            if (!sala.SeCantoTruco && !sala.SeContestoTruco || (sala.SeCantoTruco && sala.SeContestoTruco))
            {
                if ((jugadores[0].ManosGanadas == 2 || jugadores[1].ManosGanadas == 2) && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count)
                {
                    if(jugadores[0].ManosGanadas == 2)
                    {
                        Ganar(0, 1, "Gano jugador 1", "Felicidades jugador 1, ganaste!");
                    }
                    else
                    {
                        Ganar(1, 0, "Gano jugador 2", "Felicidades jugador 2, ganaste!");
                    }

                }
                else if ((sala.PrimeraMano || (!partida.AsignarTurno() && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count) || jugadores[0].Cartas.Count > jugadores[1].Cartas.Count) && jugadores[0].Cartas.Count > 0)
                {
                    if (!sala.SeCantoTruco)
                    {
                        sala.ChatJug1 = CantarTruco(jugadores[0], sala.ChatJug1);
                    }
                    Carta cartaJugada = partida.Jugar(jugadores[0], jugadores[1].CartaJugada);
                    sala.CartasJug1 += cartaJugada.Numero + " " + cartaJugada.Palo + ", ";
                }
                else if (jugadores[1].Cartas.Count > 0 || (jugadores[0].CantoTruco && !sala.SeContestoTruco))
                {
                    if (!sala.SeCantoTruco)
                    {
                        sala.ChatJug2 = CantarTruco(jugadores[1], sala.ChatJug2);
                    }
                    Carta cartaJugada = partida.Jugar(jugadores[1], jugadores[0].CartaJugada);
                    sala.CartasJug2 += cartaJugada.Numero + " " + cartaJugada.Palo + ", ";
                }
            }
            else if (sala.SeCantoTruco && !sala.SeContestoTruco)
            {
                ContestarTruco();
                sala.SeContestoTruco = true;
            }
            partida.SumarPunto();
            sala.PrimeraMano = false;
        }

        public string? CantarTruco(Usuario jugador, string? retorno)
        {
            Random rnd = new Random();
            int decision = rnd.Next(1, 3);
            if (decision == 1)
            {
                retorno = partida.CantarTruco(jugador, "Truco");
                sala.SeCantoTruco = true;
            }
            return retorno;
        }

        public void ContestarTruco()
        {
            if (jugadores[0].CantoTruco)
            {
                sala.ChatJug2 = partida.ContestarTruco(jugadores[1]);
            }
            else
            {
                sala.ChatJug1 = partida.ContestarTruco(jugadores[0]);
            }
            if (sala.ChatJug1 == "No quiero")
            {
                Ganar(1, 0, "Gano jugador 2", "Felicidades jugador 2, ganaste!");
            }
            else if(sala.ChatJug2 == "No quiero")
            {
                Ganar(0, 1, "Gano jugador 1", "Felicidades jugador 1, ganaste!");
            }
        }

        public void Ganar(int indice, int indiceOtroJug, string mensajeGanador, string mensajeGanadorPartida)
        {
            if(jugadores[indice].ManosGanadas == 2 || (jugadores[indice].CantoTruco && !jugadores[indiceOtroJug].CantoTruco))
            {
                sala.Ganador = mensajeGanador;
                if (jugadores[indice].CantoTruco && jugadores[indiceOtroJug].CantoTruco)
                {
                    jugadores[indice].PuntosPartida += 2;
                    puntos = jugadores[indice].PuntosPartida;
                }
                else
                {
                    jugadores[indice].PuntosPartida++;
                    puntos = jugadores[indice].PuntosPartida;
                }
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
                partida.FinalizarVuelta();
            }

            MostrarCartas();
        }

        //public void Ganar()
        //{
        //    if (jugadores[0].ManosGanadas == 2 || (jugadores[0].CantoTruco && !jugadores[1].CantoTruco))
        //    {
        //        sala.Ganador = "Gano jugador 1";
        //        if (jugadores[0].CantoTruco && jugadores[1].CantoTruco)
        //        {
        //            jugadores[0].PuntosPartida += 2;
        //            puntos = jugadores[0].PuntosPartida;
        //        }
        //        else
        //        {
        //            jugadores[0].PuntosPartida++;
        //            puntos = jugadores[0].PuntosPartida;
        //        }
        //        sala.PuntosJug1 = puntos.ToString();
        //    }
        //    else if (jugadores[1].ManosGanadas == 2 || (jugadores[1].CantoTruco && !jugadores[0].CantoTruco))
        //    {
        //        sala.Ganador = "Gano jugador 2";
        //        if (jugadores[0].CantoTruco && jugadores[1].CantoTruco)
        //        {
        //            jugadores[1].PuntosPartida += 2;
        //            puntos = jugadores[1].PuntosPartida;
        //        }
        //        else
        //        {
        //            jugadores[1].PuntosPartida++;
        //            puntos = jugadores[1].PuntosPartida;
        //        }

        //        sala.PuntosJug2 = puntos.ToString();
        //    }
        //    sala.TerminoVuelta = true;
        //    if (jugadores[0].PuntosPartida >= 15 || jugadores[1].PuntosPartida >= 15)
        //    {
        //        puntos = jugadores[0].PuntosPartida;
        //        sala.PuntosJug1 = puntos.ToString();
        //        puntos = jugadores[1].PuntosPartida;
        //        sala.PuntosJug2 = puntos.ToString();

        //        if (jugadores[0].PuntosPartida >= 15)
        //        {
        //            sala.Ganador = "Felicidades jugador 1, ganaste!";
        //        }
        //        else
        //        {
        //            sala.Ganador = "Felicidades jugador 2, ganaste!";
        //        }
        //        sala.FrenarTimer();
        //    }
        //    MostrarCartas();
        //}

        public void MostrarCartas()
        {
            if (sala.DecirEnvido)
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
}