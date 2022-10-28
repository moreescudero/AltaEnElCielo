using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface ISala
    {
        List<Usuario> Jugadores { get; }
        Partida Partidita { get; }
        string? ChatJug1 { get; set; }
        string? ChatJug2 { get; set; }

        public void VerificarEnvido();
        public void DecirEnvido();
        public void JugarEnvido();
        string? CantarTruco(Usuario jugador, string? mensaje);
        //void ContestarTruco();
        void Jugar();
        void Ganar();
        void MostrarCartas();

       
    }
}
