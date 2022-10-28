using System;
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

        public PresentadorSala (ISala sala)
        {
            this.sala = sala;
            partida = new Partida(Conexion.ObtenerUsuarios(),DateTime.Now);
        }

        public void AbarajarYRepartir()
        {
            Mazo mazoAux = Serializador<Mazo>.LeerJSon("mazo.json");
            List<Carta>  mazo = mazoAux.Mazos;
            mazo = sala.Partidita.Abarajar(mazo);
            sala.Partidita.Repartir(mazo);
        }

        public void ContestarTruco()
        {
            if (sala.Jugadores[0].CantoTruco)
            {
                sala.ChatJug2 = sala.Partidita.ContestarTruco(sala.Jugadores[1]);
            }
            else
            {
                sala.ChatJug1 = sala.Partidita.ContestarTruco(sala.Jugadores[0]);
            }
            if(sala.ChatJug1 == "No quiero" || sala.ChatJug2 == "No quiero")
            {
                sala.Ganar();
            }
        }
    }
}
