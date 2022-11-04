using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelo
{
    public static class ConexionPartidas
    {
        static string stringConnection;
        static SqlConnection connection;
        static SqlCommand command;

        static ConexionPartidas()
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

        public static List<Partida> ObtenerPartidas()
        {
            try
            {
                List<Partida> partidas = new List<Partida>();
                connection.Open();

                Comando("select * from Partidas");

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string ganador = dataReader.GetString(1);
                    DateTime fecha = dataReader.GetDateTime(2);

                    Partida partida = new Partida(id, ganador, fecha);
                    partidas.Add(partida);
                }

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                return partidas;
            }
            catch (Exception)
            {
                throw new Exception("ocurrio un error en la obtención de partidas");
            }
        }

        public static void AgregarPartida(Partida partida)
        {
            try
            {
                connection.Open();

                Comando("insert into Partidas (Ganador, Fecha) values(@Ganador, @Fecha)");

                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Ganador", partida.Ganador);
                command.Parameters.AddWithValue("@Fecha", partida.Fecha);

                command.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al agregar una partida");
            }

        }
    }
}
