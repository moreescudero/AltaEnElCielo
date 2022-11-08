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
        bool contesto;
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
            delTerminarPartida += sala.GuardarPartida;
        }

        /// <summary>
        /// asigna 2 jugadores random disponibles a excepción del usuario activo
        /// </summary>
        private void AsignarJugadoresRandom()
        {
            Random rnd = new Random();
            do
            {
                int indice = rnd.Next(0, PresentadorMenuPrincipal.usuarios.Count());
                if (!jugadores.Contains(PresentadorMenuPrincipal.usuarios[indice]) && PresentadorMenuPrincipal.usuarios[indice] != PresentadorMenuPrincipal.usuarioActivo)
                {
                    jugadores.Add(PresentadorMenuPrincipal.usuarios[indice]);
                }
            } while (jugadores.Count < 2);
            sala.UsuarioJugador1 = jugadores[0].NombreUsuario;
            sala.UsuarioJugador2 = jugadores[1].NombreUsuario;
        }

        /// <summary>
        /// los jugadores cantan envido si es que pueden hacerlo, si es así se responden si quieren o no
        /// </summary>
        public void JugarEnvido()
        {
            if (!jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
            {
                if (jugadores[0].EsMano)
                {
                    VerificarEnvido(0, 1);
                }
                else if (jugadores[1].EsMano)
                {
                    VerificarEnvido(1, 0);
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

        /// <summary>
        /// si del método partida.CantarEnvido vuelve un true el jugador indicado canta envido, sino dejarán pasar
        /// el turno para que el otro jugador decida si cantarlo o no
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="indiceOtroJug"></param>
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

        /// <summary>
        /// se llama al método que suma la cantidad de envido de cada jugador y luego al que los compara, 
        /// se muestran los puntos sumados 
        /// </summary>
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

        /// <summary>
        /// los jugadores deciden si cantar truco o no (de cantarlo el otro jugador debe contestarle), tiran
        /// cartas en la mesa y se suman los puntos en cada mano para determinar cuándo un jugador gana, luego 
        /// de cada vuelta se invoca un delegado que setee los atributos necesarios para continuar jugando 
        /// </summary>
        public void Jugar()
        {
            contesto = false;
            if (!gano)
            {
                if (!sala.SeCantoTruco && !sala.SeContestoTruco || sala.SeCantoTruco && sala.SeContestoTruco)
                {
                    if ((jugadores[0].ManosGanadas == 2 || jugadores[1].ManosGanadas == 2) && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count)
                    {
                        if (jugadores[0].ManosGanadas == 2)
                        {
                            Ganar(0, 1);
                        }
                        else
                        {
                            Ganar(1, 0);
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
                        sala.CartasJug1 += cartaJugada.Numero + " " + cartaJugada.Palo + "  ";
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
                        sala.CartasJug2 += cartaJugada.Numero + " " + cartaJugada.Palo + "  ";
                    }
                    sala.PrimeraMano = false;
                }
                else if (sala.SeCantoTruco && !sala.SeContestoTruco)
                {
                    contesto = true;
                    ContestarTruco();
                }
                if (jugadores[0].Cartas.Count == jugadores[1].Cartas.Count && !contesto)
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

        /// <summary>
        /// determina aleatoriamente si el jugador va a cantar truco o no
        /// </summary>
        /// <param name="jugador"></param>
        /// <returns></returns>
        private string? CantarTruco(Usuario jugador)
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

        /// <summary>
        /// llama un método para determinar si quiere jugar truco o no, si no quiere se finaliza la partida
        /// </summary>
        private void ContestarTruco()
        {
            sala.SeContestoTruco = true;
            if (jugadores[0].CantoTruco && !jugadores[1].CantoTruco)
            {
                chatJug2 = partida.ContestarTruco(jugadores[1]);
                sala.Chat += jugadores[1].NombreUsuario + ": " + chatJug2  + "\n";
                if (chatJug2 == "No quiero" && chatJug1 == "Truco")
                {
                    Ganar(0, 1);
                    return;
                }
            }
            else if(jugadores[1].CantoTruco && !jugadores[0].CantoTruco)
            {
                chatJug1 = partida.ContestarTruco(jugadores[0]);
                sala.Chat += jugadores[0].NombreUsuario + ": " + chatJug1 + "\n";
                if (chatJug1 == "No quiero" && chatJug2 == "Truco")
                {
                    Ganar(1, 0);
                    return;
                }
            }
        }

        /// <summary>
        /// se suman los puntos de la partida (si quisieron envido muestra todas las cartas en la mesa) y se
        /// invierten los bool de qué jugador es mano 
        /// si los puntos son superiores o iguales a 15 se finaliza la partida mostrando el ganador e invocando 
        /// un delegado que setee todo nuevamente para volver a jugar otra partida correctamente
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="indiceOtroJug"></param>
        /// <param name="mensajeGanador"></param>
        /// <param name="mensajeGanadorPartida"></param>
        private void Ganar(int indice, int indiceOtroJug)
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
            if (jugadores[indice].PuntosPartida > 14)
            {
                sala.Chat += jugadores[indice].NombreUsuario + " ganó la partida!";
                sala.Ganador = "Felicidades " + jugadores[indice].NombreUsuario + ", ganaste!";
                delTerminarPartida();
            }
            else if (jugadores[indiceOtroJug].PuntosPartida > 14)
            {
                sala.Chat += jugadores[indiceOtroJug].NombreUsuario + " ganó la partida!";
                sala.Ganador = "Felicidades " + jugadores[indiceOtroJug].NombreUsuario + ", ganaste!";
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
                string? mensaje = "Ganó " + jugadores[indice].NombreUsuario;
                sala.Chat += mensaje;
                sala.Ganador = mensaje;
                sala.Chat += "\n\n";
                gano = true;
            }
        }

        /// <summary>
        /// si la carta aun no se jugó la muestra en mesa
        /// </summary>
        /// <param name="indice"></param>
        /// <param name="carta"></param>
        private void Mostrar(int indice, Carta carta)
        {
            if (!jugadores[indice].CartasJugadas.Contains(carta))
            {
                if(indice == 1)
                {
                    sala.CartasJug1 += carta.Numero + " " + carta.Palo + " ";
                }
                else
                {
                    sala.CartasJug2 += carta.Numero + " " + carta.Palo + " ";
                }
            }
        }

        /// <summary>
        /// muestra las cartas que no fueron jugadas en mesa para mostrar el envido
        /// </summary>
        private void MostrarCartas()
        {
            if (jugadores[0].Cartas.Count > 0)
            {
                jugadores[0].Cartas.ForEach( (x) => Mostrar(0, x) );
            }
            if (jugadores[1].Cartas.Count > 0)
            {
                jugadores[1].Cartas.ForEach((x) => Mostrar(1, x));
            }
            
        }

        /// <summary>
        /// agrega la partida a la base de datos
        /// </summary>
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
