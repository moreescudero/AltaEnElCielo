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
        List<Usuario> jugadores = new List<Usuario>();
        public Action delTerminarVuelta;
        public Action delTerminarPartida;
        string chatJug1 = String.Empty;
        string chatJug2 = String.Empty;
        bool gano;
        int puntos;

        public PresentadorSala (ISala sala)
        {
            this.sala = sala;
            AsignarJugadoresRandom();
            partida = new Partida(0, jugadores, DateTime.Now); // no se deberia crear acá
            jugadores[0].EsMano = true;
            delTerminarVuelta = sala.LimpiarVuelta;
            delTerminarVuelta += partida.FinalizarVuelta;
            delTerminarVuelta += partida.ActivarEventoMazo;
            delTerminarPartida = sala.FrenarTimer;
            delTerminarPartida += partida.ActivarEventoFinalizarPartida;
            delTerminarPartida += AgregarPartida;
        }

        private void AsignarJugadoresRandom()
        {
            Random rnd = new Random();
            do
            {
                int indice = rnd.Next(0, PresentadorMenuPrincipal.usuarios.Count());
                if (!jugadores.Contains(PresentadorMenuPrincipal.usuarios[indice]))
                {
                    jugadores.Add(PresentadorMenuPrincipal.usuarios[indice]);
                }
            } while (jugadores.Count < 2);
            sala.UsuarioJugador1 = jugadores[0].NombreUsuario;
            sala.UsuarioJugador2 = jugadores[1].NombreUsuario;
        }

        public void JugarEnvido()
        {
            if (!jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
            {
                if (jugadores[0].EsMano)
                {
                    VerificarEnvido(0, 1);
                    //if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido)
                    //{
                    //    sala.Chat += jugadores[0].NombreUsuario + ": Envido\n";
                    //    chatJug1 = "Envido";
                    //}
                    //else if (jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
                    //{
                    //    sala.Chat += jugadores[1].NombreUsuario + ": Envido\n";
                    //}
                }
                else if (jugadores[1].EsMano)
                {
                    VerificarEnvido(1, 0);
                    //if (jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
                    //{
                    //    sala.Chat += jugadores[1].NombreUsuario + ": Envido\n";
                    //    chatJug2 = "Envido";
                    //}
                    //else if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido)
                    //{
                    //    sala.Chat += jugadores[0].NombreUsuario + ": Envido\n";
                    //}
                }
                if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido)
                {
                    sala.Chat += jugadores[0].NombreUsuario + ": Envido\n";
                    chatJug1 = "Envido";
                }
                else if (jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
                {
                    sala.Chat += jugadores[1].NombreUsuario + ": Envido\n";
                }
            }
            else if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido && chatJug2 == String.Empty)
            {
                if (partida.CantarEnvido(jugadores[1]))
                {
                    sala.Chat += jugadores[1].NombreUsuario + ": Quiero \n";
                    chatJug2 = "Quiero";
                }
                else
                {
                    sala.Chat += jugadores[1].NombreUsuario + ": No quiero \n";
                    chatJug2 = "No quiero";
                    jugadores[0].PuntosPartida++;
                    puntos = jugadores[0].PuntosPartida;
                    sala.PuntosJug1 = puntos.ToString();
                }
            }
            else if (!jugadores[0].CantoEnvido && jugadores[1].CantoEnvido && chatJug1 == String.Empty)
            {
                if (partida.CantarEnvido(jugadores[0]))
                {
                    sala.Chat += jugadores[0].NombreUsuario + ": Quiero \n";
                    chatJug1 = "Quiero";
                }
                else
                {
                    sala.Chat += jugadores[0].NombreUsuario + ": No quiero \n";
                    chatJug1 = "No quiero";
                    jugadores[1].PuntosPartida++;
                    puntos = jugadores[1].PuntosPartida;
                    sala.PuntosJug2 = puntos.ToString();
                }
            }
            if (sala.DecirEnvido)
            {
                DecirCantEnvido();
            }
            else
            {
                if (chatJug1 == "No quiero" || chatJug2 == "No quiero")
                {
                    sala.HayEnvido = false;
                }
                else if (chatJug1 == "Quiero" || chatJug2 == "Quiero")
                {
                    sala.DecirEnvido = true;
                }
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
            sala.Chat += jugadores[0].NombreUsuario + ": " + sala.EnvidoJug1.ToString() + "\n";
            sala.EnvidoJug2 = partida.DecirEnvido(jugadores[1]);
            sala.Chat += jugadores[1].NombreUsuario + ": " + sala.EnvidoJug2.ToString() + "\n";
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
            if (!gano)
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
                            chatJug1 = CantarTruco(jugadores[0]);
                            if (chatJug1 != String.Empty)
                            {
                                sala.Chat += jugadores[0].NombreUsuario + ": " + chatJug1 +"\n";
                            }
                        }
                        Carta cartaJugada = partida.Jugar(jugadores[0], jugadores[1].CartaJugada);
                        sala.CartasJug1 += cartaJugada.Numero + " " + cartaJugada.Palo + " - ";
                    }
                    else if ((jugadores[1].EsMano && !jugadores[0].EsMano && sala.PrimeraMano) || jugadores[1].Cartas.Count > 0 || jugadores[0].CantoTruco && !sala.SeContestoTruco)
                    {
                        if (!sala.SeCantoTruco)
                        {
                            chatJug2 = CantarTruco(jugadores[1]);
                            if (chatJug2 != String.Empty)
                            {
                                sala.Chat += jugadores[1].NombreUsuario + ": " + chatJug2 + "\n";
                            }
                        }
                        Carta cartaJugada = partida.Jugar(jugadores[1], jugadores[0].CartaJugada);
                        sala.CartasJug2 += cartaJugada.Numero + " " + cartaJugada.Palo + " - ";
                    }
                    sala.PrimeraMano = false;
                }
                else if (sala.SeCantoTruco && !sala.SeContestoTruco)
                {
                    ContestarTruco();
                }
                if (jugadores[0].Cartas.Count == jugadores[1].Cartas.Count && !gano)
                {
                    partida.SumarPunto();
                }
            }
            else
            {
                delTerminarVuelta();
                gano = false;
            }
        }

        public string? CantarTruco(Usuario jugador)
        {
            string? retorno = String.Empty;
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
                chatJug2 = partida.ContestarTruco(jugadores[1]);
                sala.Chat += jugadores[1].NombreUsuario + ": " + chatJug2  + "\n";
                if (chatJug2 == "No quiero")
                {
                    Ganar(0, 1, "Gano jugador 1", "Felicidades jugador 1, ganaste!");
                    return;
                }
            }
            else if(jugadores[1].CantoTruco && !jugadores[0].CantoTruco)
            {
                chatJug1 = partida.ContestarTruco(jugadores[0]);
                sala.Chat += jugadores[0].NombreUsuario + ": " + chatJug1 + "\n";
                if (chatJug1 == "No quiero")
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
                delTerminarPartida();
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
                chatJug1 = String.Empty;
                chatJug2 = String.Empty;
                sala.Ganador = mensajeGanador;
                sala.Chat += "\n\n";
                gano = true;
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
                        sala.CartasJug1 += carta.Numero + " " + carta.Palo + " ";
                    }
                }
            }
            if (jugadores[1].Cartas.Count > 0)
            {
                foreach (Carta carta in jugadores[1].Cartas)
                {
                    if (!jugadores[1].CartasJugadas.Contains(carta))
                    {
                        sala.CartasJug2 += carta.Numero + " " + carta.Palo + " ";
                    }
                }
            }
            
        }

        private void AgregarPartida()
        {
            try
            {
                ConexionPartidas.AgregarPartida(partida);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
