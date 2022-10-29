﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Vista
{
    public partial class Frm_Sala : Form, ISala
    {
        DateTime segundos;
        //Partida partidita;
        //List<Usuario> jugadores;
        PresentadorSala presentador;
        int envidoJug1;
        int envidoJug2;
        bool primeraMano = true;
        bool hayEnvido = true;
        //bool seContestoEnvido = false;
        bool seCantoTruco = false;
        bool seCantoRetruco = false;
        bool seCantoQuieroVale4 = false;
        bool decirEnvido = false;
        bool seContestoTruco = false;
        bool terminoVuelta = false;

        public Frm_Sala ()
        {
            InitializeComponent();
            presentador = new PresentadorSala(this);
        }
        
        //public Frm_Sala (/*Partida partidita*/): this()
        //{
        //    //this.partidita = partidita;
            
        //}

        //public List<Usuario> Jugadores { get { return jugadores; } }
        //public Partida Partidita { get { return partidita; } }
        public string? ChatJug1 { get { return lbl_ChatJug1.Text; } set { lbl_ChatJug1.Text = value; } }
        public string? ChatJug2 { get { return lbl_ChatJug2.Text; } set { lbl_ChatJug2.Text = value; } }
        public string? Ganador { get { return lbl_Ganador.Text; } set { lbl_Ganador.Text = value; } }
        public string? PuntosJug1 { get { return lbl_PuntosJug1.Text; } set { lbl_PuntosJug1.Text = value; } }
        public string? PuntosJug2 { get { return lbl_PuntosJug2.Text; } set { lbl_PuntosJug2.Text = value; } }
        public string? CartasJug1 { get { return lbl_CartasJugador1.Text;} set { lbl_CartasJugador1.Text = value; } }
        public string? CartasJug2 { get { return lbl_CartasJugador2.Text;} set { lbl_CartasJugador2.Text = value; } }
        public int EnvidoJug1 { get { return envidoJug1; } set { envidoJug1 = value; } }
        public int EnvidoJug2 { get { return envidoJug2; } set { envidoJug2 = value; } }
        public bool PrimeraMano { get { return primeraMano; } set { primeraMano = value; } }
        public bool HayEnvido { get { return hayEnvido; } set { hayEnvido = value; } }
        public bool SeCantoTruco { get { return seCantoTruco; } set { seCantoTruco = value; } }
        public bool SeCantoRetruco { get { return seCantoRetruco; } set { seCantoRetruco = value; } }
        public bool SeCantoQuieroVale4 { get { return seCantoQuieroVale4; } set { seCantoQuieroVale4 = value; } }
        public bool DecirEnvido { get { return decirEnvido; } set { decirEnvido = value; } }
        public bool SeContestoTruco { get { return seContestoTruco; } set { seContestoTruco = value; } }
        public bool TerminoVuelta { get { return terminoVuelta; } set { terminoVuelta = value; } }

        private void Frm_Sala_Load(object sender, EventArgs e)
        {
            presentador.AbarajarYRepartir();
            //jugadores = partidita.Jugadores;
        }

        private void btn_Comenzar_Click(object sender, EventArgs e)
        {
            tmr_Partida.Start();
        }

        private void tmr_Partida_Tick(object sender, EventArgs e)
        {
            segundos = segundos.AddSeconds(1);
            //lblTiempoPartida.Text = hora.ToString("mm:ss");
            int segundosInt = int.Parse(segundos.ToString("ss"));
            if (segundosInt % 2 == 0)
            {
                if (terminoVuelta)
                {
                    LimpiarVuelta();
                }
                else
                {
                    if (hayEnvido)
                    {
                        presentador.JugarEnvido();
                    }
                    else
                    {
                        presentador.Jugar();
                    }
                }
            }
        }

        public void FrenarTimer()
        {
            tmr_Partida.Stop();
        }

        //public string? CantarTruco(Usuario jugador, string? retorno)
        //{
        //    Random rnd = new Random();
        //    int decision = rnd.Next(1, 3);
        //    if(decision == 1)
        //    {
        //        retorno = partidita.CantarTruco(jugador, "Truco");
        //        seCantoTruco = true;
        //    }
        //    return retorno;
        //}

        //public void ContestarTruco()
        //{
        //    //if (jugadores[0].CantoTruco)
        //    //{
        //    //    lbl_ChatJug2.Text = partidita.ContestarTruco(jugadores[1]);
        //    //}
        //    //else
        //    //{
        //    //    lbl_ChatJug1.Text = partidita.ContestarTruco(jugadores[0]);
        //    //}
        //    //if(lbl_ChatJug1.Text == "No quiero" || lbl_ChatJug2.Text == "No quiero")
        //    //{
        //    //    Ganar();
        //    //}
        //    presentador.ContestarTruco();
        //    seContestoTruco = true;
        //}

        //public void JugarEnvido()
        //{
        //    if (!jugadores[1].CantoEnvido && !jugadores[0].CantoEnvido)
        //    {
        //        VerificarEnvido();
        //    }
        //    else if (jugadores[0].CantoEnvido && !jugadores[1].CantoEnvido)
        //    {
        //        if (partidita.CantarEnvido(jugadores[1]))
        //        {
        //            lbl_ChatJug2.Text = "Quiero";
        //            if (decirEnvido)
        //            {
        //                jugadores[1].CantoEnvido = true;
        //                DecirEnvido();
        //            }
        //            decirEnvido = true;
        //        }
        //        else
        //        {
        //            lbl_ChatJug2.Text = "No quiero";
        //            jugadores[0].PuntosPartida++;
        //            puntos = jugadores[0].PuntosPartida;
        //            lbl_PuntosJug1.Text = puntos.ToString();
        //            hayEnvido = false;
        //        }
        //    }
        //    else if (!jugadores[0].CantoEnvido && jugadores[1].CantoEnvido)
        //    {
        //        if (partidita.CantarEnvido(jugadores[0]))
        //        {
        //            lbl_ChatJug1.Text = "Quiero";
        //            if (decirEnvido)
        //            {
        //                jugadores[0].CantoEnvido = true;
        //                DecirEnvido();
        //            }
        //            decirEnvido = true;
        //        }
        //        else
        //        {
        //            lbl_ChatJug1.Text = "No quiero";
        //            jugadores[1].PuntosPartida++;
        //            puntos = jugadores[1].PuntosPartida;
        //            lbl_PuntosJug2.Text = puntos.ToString();
        //            hayEnvido = false;
        //        }

        //    }
        //}

        //public void DecirCantEnvido()
        //{
        //    envidoJug1 = partidita.DecirEnvido(jugadores[0]);
        //    lbl_ChatJug1.Text = envidoJug1.ToString();
        //    envidoJug2 = partidita.DecirEnvido(jugadores[1]);
        //    lbl_ChatJug2.Text = envidoJug2.ToString();
        //    lbl_Ganador.Text = partidita.DeterminarGanadorEnvido(envidoJug1, envidoJug2);

        //    if(lbl_Ganador.Text == "Jugador 1 ganó envido")
        //    {
        //        puntos = jugadores[0].PuntosPartida;
        //        lbl_PuntosJug1.Text = puntos.ToString();
        //    }
        //    else
        //    {
        //        puntos = jugadores[1].PuntosPartida;
        //        lbl_PuntosJug2.Text = puntos.ToString();
        //    }

        //    hayEnvido = false;

        //}

        //public void VerificarEnvido()
        //{
        //    if (partidita.CantarEnvido(jugadores[0]))
        //    {
        //        jugadores[0].CantoEnvido = true;
        //        lbl_ChatJug1.Text = "Envido";
        //    }
        //    else if (partidita.CantarEnvido(jugadores[1]))
        //    {
        //        jugadores[1].CantoEnvido = true;
        //        lbl_ChatJug2.Text = "Envido";
        //    }
        //    else
        //    {
        //        hayEnvido = false;
        //    }
        //}

        //public void Jugar()
        //{
        //    if (!seCantoTruco && !seContestoTruco || (seCantoTruco && seContestoTruco))
        //    {
        //        if ((jugadores[0].ManosGanadas == 2 || jugadores[1].ManosGanadas == 2) && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count)
        //        {
        //            Ganar();
        //        }
        //        else if ((primeraMano || (!partidita.AsignarTurno() && jugadores[0].Cartas.Count == jugadores[1].Cartas.Count) || jugadores[0].Cartas.Count > jugadores[1].Cartas.Count) && jugadores[0].Cartas.Count > 0)
        //        {
        //            if(!seCantoTruco)
        //            {
        //                lbl_ChatJug1.Text = CantarTruco(jugadores[0], lbl_ChatJug1.Text);
        //            }
        //            Carta cartaJugada = partidita.Jugar(jugadores[0], jugadores[1].CartaJugada);
        //            lbl_CartasJugador1.Text += cartaJugada.Numero + " " + cartaJugada.Palo + ", ";
        //        }
        //        else if (jugadores[1].Cartas.Count > 0 || (jugadores[0].CantoTruco && !seContestoTruco))
        //        {
        //            if (!seCantoTruco)
        //            {
        //                lbl_ChatJug2.Text = CantarTruco(jugadores[1], lbl_ChatJug2.Text);
        //            }
        //            Carta cartaJugada = partidita.Jugar(jugadores[1], jugadores[0].CartaJugada);
        //            lbl_CartasJugador2.Text += cartaJugada.Numero + " " + cartaJugada.Palo + ", ";
        //        }
        //    }
        //    else if(seCantoTruco && !seContestoTruco)
        //    {
        //        presentador.ContestarTruco();
        //        seContestoTruco = true;
        //    }
        //    partidita.SumarPunto();
        //    primeraMano = false;
        //}

        //public void Ganar()
        //{
        //    if (jugadores[0].ManosGanadas == 2 || (jugadores[0].CantoTruco && !jugadores[1].CantoTruco))
        //    {
        //        lbl_Ganador.Text = "Gano jugador 1";
        //        if (jugadores[0].CantoTruco && jugadores[1].CantoTruco)
        //        {
        //            jugadores[0].PuntosPartida += 2;
        //            puntos = jugadores[0].PuntosPartida;
        //            lbl_PuntosJug1.Text = puntos.ToString();
        //        }
        //        else
        //        {
        //            lbl_PuntosJug1.Text = jugadores[0].PuntosPartida++.ToString();
        //        }
        //    }
        //    else if(jugadores[1].ManosGanadas == 2 || (jugadores[1].CantoTruco && !jugadores[0].CantoTruco))
        //    {
        //        lbl_Ganador.Text = "Gano jugador 2";
        //        if (jugadores[0].CantoTruco && jugadores[1].CantoTruco)
        //        {
        //            jugadores[1].PuntosPartida += 2;
        //            puntos = jugadores[1].PuntosPartida;
        //            lbl_PuntosJug2.Text = puntos.ToString();
        //        }
        //        else
        //        {
        //            lbl_PuntosJug2.Text = jugadores[1].PuntosPartida++.ToString();
        //        }
        //    }
        //    terminoVuelta = true;
        //    if (jugadores[0].PuntosPartida >= 15 || jugadores[1].PuntosPartida >= 15)
        //    {
        //        puntos = jugadores[0].PuntosPartida;
        //        lbl_PuntosJug1.Text = puntos.ToString();
        //        puntos = jugadores[1].PuntosPartida;
        //        lbl_PuntosJug2.Text = puntos.ToString();

        //        if(jugadores[0].PuntosPartida >= 15)
        //        {
        //            lbl_Ganador.Text = "Felicidades jugador 1, ganaste!";
        //        }
        //        else
        //        {
        //            lbl_Ganador.Text = "Felicidades jugador 2, ganaste!";
        //        }
        //        tmr_Partida.Stop();
        //    }
        //    MostrarCartas();
        //}

        public void LimpiarVuelta() //se puede usar delegados para LimpiarVuelta, finalizarVuelta y AbarajarYRepartir
        {
            envidoJug1 = 0;
            envidoJug2 = 0;
            primeraMano = true;
            hayEnvido = true;
            seCantoTruco = false;
            seCantoRetruco = false;
            seCantoQuieroVale4 = false;
            decirEnvido = false;
            seContestoTruco = false;
            terminoVuelta = false;
            presentador.AbarajarYRepartir();

            lbl_CartasJugador1.Text = String.Empty;
            lbl_CartasJugador2.Text = String.Empty;
            lbl_ChatJug1.Text = String.Empty;
            lbl_ChatJug2.Text = String.Empty;
            lbl_Ganador.Text = String.Empty;
        }

        //public void MostrarCartas()
        //{
        //    if (decirEnvido)
        //    {
        //        if (jugadores[0].Cartas.Count > 0)
        //        {
        //            foreach (Carta carta in jugadores[0].Cartas)
        //            {
        //                if (!jugadores[0].CartasJugadas.Contains(carta))
        //                {
        //                    lbl_CartasJugador1.Text += carta.Numero + " " + carta.Palo;
        //                }
        //            }
        //        }
        //        if (jugadores[1].Cartas.Count > 0)
        //        {
        //            foreach (Carta carta in jugadores[1].Cartas)
        //            {
        //                if (!jugadores[1].CartasJugadas.Contains(carta))
        //                {
        //                    lbl_CartasJugador2.Text += carta.Numero + " " + carta.Palo;
        //                }
        //            }
        //        }
        //    }
        //}
        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}