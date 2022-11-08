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
        public static Usuario usuarioActivo;

        public PresentadorMenuPrincipal (IMenuPrincipal menu)
        {
            this.menu = menu;
            ObtenerPartidas();
            usuarioActivo = PresentadorLogin.usuarioActivo;
            usuarios = PresentadorLogin.usuarios;
        }

        /// <summary>
        /// Obtiene las partidas de la base de datos
        /// </summary>
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

        /// <summary>
        /// muestra el usuario del jugador activo en un label 
        /// </summary>
        public void MostrarJugadorActivo()
        {
            menu.Bienvenido += usuarioActivo.NombreUsuario;
        }

        /// <summary>
        /// carga el datagridview con la lista de usuarios con mas cantidad de partidas ganadas
        /// </summary>
        public void CargarDataGrid()
        {
            // que en este dgv se muestren los usuarios con más cantidad de partidas ganadas
            menu.CargarDgv(usuarios);
        }

        /// <summary>
        /// actualiza la informacion de los usuarios (partidas ganadas y perdidas) en la base de datos 
        /// </summary>
        public void GuardarInfoUsuarios()
        {
            try
            {
                ConexionUsuarios.ModificarUsuarios(usuarios);
            }
            catch (Exception ex)
            {
                menu.HabilitarPanel = true;
                menu.ErrorPanel = ex.Message;
            }             
        }


    }
}
