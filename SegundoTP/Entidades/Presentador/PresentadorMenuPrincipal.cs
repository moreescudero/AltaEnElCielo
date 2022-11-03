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
        //List<Usuario> jugadores;
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
            menu.CargarDgv(usuarios);
        }
    }
}
