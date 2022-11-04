using System.Data.SqlClient;
using System.Data;

namespace Entidades.Modelo
{
    public static class ConexionUsuarios
    {
        static string stringConnection;
        static SqlConnection connection;
        static SqlCommand command;

        static ConexionUsuarios()
        {
            stringConnection = @"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;";
            connection = new SqlConnection(stringConnection);
            command = new SqlCommand();
        }

        private static void Comando(string mensaje)
        {
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = mensaje;
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();
                connection.Open();

                Comando("select * from Usuarios");

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombreUsuario = dataReader.GetString(1);
                    string contraseña = dataReader.GetString(2);
                    int partidasGanadas = dataReader.GetInt32(3);
                    int partidasPerdidas = dataReader.GetInt32(4);

                    Usuario usuario = new Usuario(id, nombreUsuario, contraseña, partidasGanadas, partidasPerdidas);
                    usuarios.Add(usuario);
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                return usuarios;
            }
            catch (Exception )
            {
                throw new Exception("Ocurrio un error en la obtención de usuarios");
            }
        }

        public static void AgregarUsuario(Usuario usuario, string contraseña)
        {
            try
            {
                connection.Open();

                Comando("insert into Usuarios (Usuario, Contraseña, PartidasGanadas, PartidasPerdidas) values(@Usuario, @Contraseña, @PartidasGanadas, @PartidasPerdidas)");

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                command.Parameters.AddWithValue("@PartidasGanadas", usuario.PartidasGanadas);
                command.Parameters.AddWithValue("@PartidasPerdidas", usuario.PartidasPerdidas);

                command.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al agregar usuario");
            }

        }

    }
}