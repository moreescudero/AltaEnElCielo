using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Modelo;

namespace Entidades.Presentador
{
    public class PresentadorLogin
    {
        ILogin login;
        public static List<Usuario> usuarios = new List<Usuario>();
        public static Usuario usuarioActivo;

        public PresentadorLogin (ILogin login)
        {
            this.login = login;
            ObtenerUsuarios();
        }

        public void IntentarIngresar()
        {
            int contador = 0;
            try
            {
                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.ComprobarContraseña(login.Contraseña) && usuario.NombreUsuario == login.NombreUsuario)
                    {
                        usuarioActivo = usuario;
                        login.IngresarAlMenuPrincipal();
                        break;
                    }
                    else if(usuario.NombreUsuario != login.NombreUsuario)
                    {
                        contador++;
                    }
                    //else if (usuarios.Last() == usuario)
                    //{
                    //    throw new Exception("contraseña incorrecta");
                    //}
                    ////if(usuario.NombreUsuario != txt_Usuario.Text)
                    ////{
                    ////    throw new Exception("usuario incorrecto");
                    ////}
                }
                if(contador == usuarios.Count)
                {
                    throw new Exception("nombre de usuario incorrecto");
                }
                else if(contador == (usuarios.Count - 1))
                {
                    throw new Exception("contraseña incorrecta");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "contraseña incorrecta")
                {
                    login.ContraseñaIncorrecta = ex.Message;
                }
                if (ex.Message == "nombre de usuario incorrecto")
                {
                    login.UsuarioIncorrecto = ex.Message;
                }
            }
        }

        private int ObtenerUltimoID()
        {
            foreach(Usuario usuario in usuarios)
            {
                if(usuarios.Last() == usuario)
                {
                    return usuario.Id;
                }
            }
            return -1;
        }

        private void ObtenerUsuarios()
        {
            try
            {
                usuarios = ConexionUsuarios.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                login.ContraseñaIncorrecta = ex.Message;
            }
        }

        public bool ComprobarNombreUsuarioUnico(string nombreUsuario)
        {
            foreach (Usuario usuario in usuarios)
            {
                if(usuario.NombreUsuario == nombreUsuario)
                {
                    return false;
                }
            }
            return true;
        }

        public bool AgregarUsuario()
        {
            bool agregoUsuario = false;
            int id = ObtenerUltimoID() + 1;
            Usuario usuario = new Usuario(id, login.NombreUsuario, login.Contraseña);
            if (!usuarios.Contains(usuario))
            {
                try
                {
                    ConexionUsuarios.AgregarUsuario(usuario, login.Contraseña);
                    usuarios.Add(usuario);
                    agregoUsuario = true;
                }
                catch(Exception ex)
                {
                    login.ContraseñaIncorrecta = ex.Message;
                }
            }
            return agregoUsuario;
        }
    }
}
