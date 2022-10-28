using Entidades;
using System.Security.Policy;

namespace Vista
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            //Mazo mazo = new Mazo();
            //Serializador<Mazo>.EscribirJSon(mazo, "mazo");
            try
            {
                List<Usuario> usuarios = Conexion.ObtenerUsuarios();

                Frm_MenuPrincipal frm_MenuPrincipal = new Frm_MenuPrincipal();

                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.ComprobarContraseña(txt_Contraseña.Text) && usuario.NombreUsuario == txt_Usuario.Text)
                    {
                        this.Hide();
                        frm_MenuPrincipal.ShowDialog();
                        this.Show();
                        break;
                    }
                    else if (usuarios.Last() == usuario)
                    {
                        throw new Exception("contraseña incorrecta");
                    }
                    if(usuario.NombreUsuario != txt_Usuario.Text)
                    {
                        throw new Exception("usuario incorrecto");
                    }
                }
            }
            catch(Exception ex)
            {
                if(ex.Message == "contraseña incorrecta")
                {
                    lbl_ContraseñaIncorrecta.Text = ex.Message;
                }
                if(ex.Message == "usuario incorrecto")
                {
                    lbl_UsuarioIncorrecto.Text = ex.Message;
                }
                
            }
        }
    }
}