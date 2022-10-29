using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISala
    {
        //List<Usuario> Jugadores { get; }
        //Partida Partidita { get; }
        string? ChatJug1 { get; set; }
        string? ChatJug2 { get; set; }
        string? Ganador { get; set; }
        string? PuntosJug1 { get; set; }
        string? PuntosJug2 { get; set; }
        string? CartasJug1 { get; set; }
        string? CartasJug2 { get; set; }
        int EnvidoJug1 { get; set; }
        int EnvidoJug2 { get; set; }
        bool PrimeraMano { get; set; }
        bool HayEnvido { get; set; }
        bool SeCantoTruco { get; set; }
        bool SeCantoRetruco { get; set; }
        bool SeCantoQuieroVale4 { get; set; }
        bool DecirEnvido { get; set; }
        bool SeContestoTruco { get; set; }
        bool TerminoVuelta { get; set; }

        void FrenarTimer();
        //public void VerificarEnvido();
        //public void DecirEnvido();
        //public void JugarEnvido();
        //string? CantarTruco(Usuario jugador, string? mensaje);
        ////void ContestarTruco();
        //void Jugar();
        //void Ganar();
        //void MostrarCartas();


    }
}
