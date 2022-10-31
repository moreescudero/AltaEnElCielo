using System.Data.SqlClient;
using System.Data;

namespace Entidades.Modelo
{
    public static class Conexion
    {
        static string stringConnection;
        static SqlConnection connection;
        static SqlCommand command;

        static Conexion()
        {
            stringConnection = @"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;";
            connection = new SqlConnection(stringConnection);
            command = new SqlCommand();
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
                    usuarios.Add(new Usuario(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
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

        private static void Comando(string mensaje)
        {
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = mensaje;
        }

        public static void AgregarUsuario(Usuario usuario, string contraseña)
        {
            try
            {
                connection.Open();

                Comando("insert into Usuarios (Usuario, Contraseña) values(@Usuario, @Contraseña)");

                command.Parameters.Clear();
                //command.Parameters.AddWithValue("@Id", usuario.Id);
                command.Parameters.AddWithValue("@Usuario", usuario.NombreUsuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

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