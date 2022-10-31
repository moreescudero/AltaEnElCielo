using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Presentador
{
    public class PresentadorMenuPrincipal
    {
        IMenuPrincipal menu;
        public static List<Usuario> usuarios;
        List<Usuario> jugadores;
        Usuario usuarioActivo;

        public PresentadorMenuPrincipal (IMenuPrincipal menu)
        {
            this.menu = menu;
            usuarioActivo = PresentadorLogin.usuarioActivo;
            usuarios = PresentadorLogin.usuarios;
        }

        public void MostrarJugadorActivo()
        {
            menu.Bienvenido += usuarioActivo.NombreUsuario;
        }

        public void CargarDataGrid()
        {
            //menu.HabilitarBotonAbrirSala = false;
            menu.CargarDgv(usuarios);
        }

        //public void CargarUsuarios(int indiceJugador)
        //{
        //    if(jugadores.Count < 3)
        //    {
        //        Usuario usuarioElegido = usuarios[indiceJugador];
        //        if(!jugadores.Contains(usuarioElegido))
        //        {
        //            jugadores.Add(usuarioElegido);
        //            menu.UsuariosCargados = "Se cargó al jugador " + usuarioElegido.NombreUsuario + " a la partida";
        //            if(jugadores.Count == 2)
        //            {
        //                menu.HabilitarBotonAbrirSala = true;
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("Ya elegiste este usuario");
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("No podes cargar más de 2 jugadores");
        //    }
        //}
    }
}
