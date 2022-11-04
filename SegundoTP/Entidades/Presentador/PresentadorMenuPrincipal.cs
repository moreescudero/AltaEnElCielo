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
        List<Partida> partidas;
        public static List<Usuario> usuarios;
        //List<Usuario> jugadores;
        Usuario usuarioActivo;

        public PresentadorMenuPrincipal (IMenuPrincipal menu)
        {
            this.menu = menu;
            ObtenerPartidas();
            usuarioActivo = PresentadorLogin.usuarioActivo;
            usuarios = PresentadorLogin.usuarios;
        }

        public void ObtenerPartidas()
        {
            try
            {
                partidas = ConexionPartidas.ObtenerPartidas(); 
            }
            catch(Exception ex)
            {
                menu.HabilitarPanel = true;
                menu.ErrorPanel = ex.Message;
            }
            //en el dgv solo se van a mostrar las partidas activas asi que a penas se ingrese a este frm
            //se deberian crear automaticamente entre 2 y 4 partidas para simular que ya exista gente jugando
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
