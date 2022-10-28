using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public static class Conexion
    {
        static string stringConnection;
        static SqlConnection connection;
        static SqlCommand command;

        static Conexion ()
        {
            stringConnection = @"Data Source = 192.168.0.163 ; Initial Catalog = truco ; User ID = more ; Password = segtp ;";
            connection = new SqlConnection (stringConnection);
            command = new SqlCommand();
        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            connection.Open();

            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "select * from Usuarios";

            SqlDataReader dataReader = command.ExecuteReader();

            while(dataReader.Read())
            {
                usuarios.Add(new Usuario(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2)));
            }

            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return usuarios; 
        }
        
        //public static List<Carta> InicializarMazo()
        //{
        //    List<Carta> mazo = new List<Carta>();

        //    mazo.Add(new Carta(1, "Espada", EValores.AnchoEspada));
        //    mazo.Add(new Carta(2, "Espada", EValores.Dos));
        //    mazo.Add(new Carta(3, "Espada", EValores.Tres));
        //    mazo.Add(new Carta(4, "Espada", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "Espada", EValores.Cinco));
        //    mazo.Add(new Carta(6, "Espada", EValores.Seis));
        //    mazo.Add(new Carta(7, "Espada", EValores.SieteEspada));
        //    mazo.Add(new Carta(10, "Espada", EValores.Diez));
        //    mazo.Add(new Carta(11, "Espada", EValores.Once));
        //    mazo.Add(new Carta(12, "Espada", EValores.Doce));
        //    mazo.Add(new Carta(1, "Oro", EValores.Uno));
        //    mazo.Add(new Carta(2, "Oro", EValores.Dos));
        //    mazo.Add(new Carta(3, "Oro", EValores.Tres));
        //    mazo.Add(new Carta(4, "Oro", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "Oro", EValores.Cinco));
        //    mazo.Add(new Carta(6, "Oro", EValores.Seis));
        //    mazo.Add(new Carta(7, "Oro", EValores.SieteOro));
        //    mazo.Add(new Carta(10, "Oro", EValores.Diez));
        //    mazo.Add(new Carta(11, "Oro", EValores.Once));
        //    mazo.Add(new Carta(12, "Oro", EValores.Doce));
        //    mazo.Add(new Carta(1, "Copa", EValores.Uno));
        //    mazo.Add(new Carta(2, "Copa", EValores.Dos));
        //    mazo.Add(new Carta(3, "Copa", EValores.Tres));
        //    mazo.Add(new Carta(4, "Copa", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "Copa", EValores.Cinco));
        //    mazo.Add(new Carta(6, "Copa", EValores.Seis));
        //    mazo.Add(new Carta(7, "Copa", EValores.Siete));
        //    mazo.Add(new Carta(10, "Copa", EValores.Diez));
        //    mazo.Add(new Carta(11, "Copa", EValores.Once));
        //    mazo.Add(new Carta(12, "Copa", EValores.Doce));
        //    mazo.Add(new Carta(1, "Basto", EValores.AnchoBasto));
        //    mazo.Add(new Carta(2, "Basto", EValores.Dos));
        //    mazo.Add(new Carta(3, "Basto", EValores.Tres));
        //    mazo.Add(new Carta(4, "Basto", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "Basto", EValores.Cinco));
        //    mazo.Add(new Carta(6, "Basto", EValores.Seis));
        //    mazo.Add(new Carta(7, "Basto", EValores.Siete));
        //    mazo.Add(new Carta(10, "Basto", EValores.Diez));
        //    mazo.Add(new Carta(11, "Basto", EValores.Once));
        //    mazo.Add(new Carta(12, "Basto", EValores.Doce));

        //    return mazo;
        //}

    }
}