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
        public static List<Usuario> usuarios;
        public static Usuario usuarioActivo;

        public PresentadorLogin (ILogin login)
        {
            this.login = login;
            ObtenerUsuarios();
        }

        public void IntentarIngresar()
        {
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
                    else if (usuarios.Last() == usuario)
                    {
                        throw new Exception("contraseña incorrecta");
                    }
                    //if(usuario.NombreUsuario != txt_Usuario.Text)
                    //{
                    //    throw new Exception("usuario incorrecto");
                    //}
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "contraseña incorrecta")
                {
                    login.ContraseñaIncorrecta = ex.Message;
                }
                if (ex.Message == "usuario incorrecto")
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
                usuarios = Conexion.ObtenerUsuarios();
            }
            catch (Exception ex)
            {
                login.ContraseñaIncorrecta = ex.Message;
            }
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
                    Conexion.AgregarUsuario(usuario, login.Contraseña);
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
