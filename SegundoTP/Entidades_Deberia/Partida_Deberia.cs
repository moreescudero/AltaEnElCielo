using Entidades.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Deberia
{
    [TestClass]
    public class Partida_Deberia
    {
        //private List<Carta> EscribirMazo()
        //{
        //    List<Carta> mazo = new List<Carta>();

        //    mazo.Add(new Carta(1, "espada", EValores.AnchoEspada));
        //    mazo.Add(new Carta(2, "espada", EValores.Dos));
        //    mazo.Add(new Carta(3, "espada", EValores.Tres));
        //    mazo.Add(new Carta(4, "espada", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "espada", EValores.Cinco));
        //    mazo.Add(new Carta(6, "espada", EValores.Seis));
        //    mazo.Add(new Carta(7, "espada", EValores.SieteEspada));
        //    mazo.Add(new Carta(10, "espada", EValores.Diez));
        //    mazo.Add(new Carta(11, "espada", EValores.Once));
        //    mazo.Add(new Carta(12, "espada", EValores.Doce));
        //    mazo.Add(new Carta(1,"oro", EValores.Uno));
        //    mazo.Add(new Carta(2, "oro", EValores.Dos));
        //    mazo.Add(new Carta(3, "oro", EValores.Tres));
        //    mazo.Add(new Carta(4, "oro", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "oro", EValores.Cinco));
        //    mazo.Add(new Carta(6, "oro", EValores.Seis));
        //    mazo.Add(new Carta(7, "oro", EValores.SieteOro));
        //    mazo.Add(new Carta(10, "oro", EValores.Diez));
        //    mazo.Add(new Carta(11, "oro", EValores.Once));
        //    mazo.Add(new Carta(12, "oro", EValores.Doce));
        //    mazo.Add(new Carta(1, "copa", EValores.Uno));
        //    mazo.Add(new Carta(2, "copa", EValores.Dos));
        //    mazo.Add(new Carta(3, "copa", EValores.Tres));
        //    mazo.Add(new Carta(4, "copa", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "copa", EValores.Cinco));
        //    mazo.Add(new Carta(6, "copa", EValores.Seis));
        //    mazo.Add(new Carta(7, "copa", EValores.Siete));
        //    mazo.Add(new Carta(10, "copa", EValores.Diez));
        //    mazo.Add(new Carta(11, "copa", EValores.Once));
        //    mazo.Add(new Carta(12, "copa", EValores.Doce));
        //    mazo.Add(new Carta(1, "basto", EValores.AnchoBasto));
        //    mazo.Add(new Carta(2, "basto", EValores.Dos));
        //    mazo.Add(new Carta(3, "basto", EValores.Tres));
        //    mazo.Add(new Carta(4, "basto", EValores.Cuatro));
        //    mazo.Add(new Carta(5, "basto", EValores.Cinco));
        //    mazo.Add(new Carta(6, "basto", EValores.Seis));
        //    mazo.Add(new Carta(7, "basto", EValores.Siete));
        //    mazo.Add(new Carta(10, "basto", EValores.Diez));
        //    mazo.Add(new Carta(11, "basto", EValores.Once));
        //    mazo.Add(new Carta(12, "basto", EValores.Doce));

        //    return mazo;
        //}

        [TestMethod]
        public void Barajar_Deberia()
        {
            //Mazo mazoAux = new Mazo();
            //mazoAux.Mazos = EscribirMazo();
            //Serializador<Mazo>.EscribirJSon(mazoAux, "mazo.json");
            Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); //me tira excepcion por no encontrar el archivo
            List<Carta> listaMazo = mazo.Mazos;
            Partida partida = new Partida(0);

            partida.Barajar(listaMazo);

            Assert.IsTrue(listaMazo.Count == 6);
            Assert.IsNotNull(listaMazo);
        }

        [DataRow()]
        [TestMethod]
        public void Repartir_Deberia()
        {
            Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); //me tira excepcion por no encontrar el archivo
            List<Carta> listaMazo = mazo.Mazos;
        }

        //[TestMethod] //no se como pasar un objeto para que pueda ser nulo
        //public void TirarCarta_Deberia()
        //{

        //}

        private List<Usuario> CrearPartidaPrueba()
        {
            List<Usuario> jugadores = new List<Usuario>()
            {
                new Usuario (0, "jug1", "test"),
                new Usuario (0, "jug2", "test")
            };
            return jugadores;
        }

        [DataRow(30, 20)]
        [DataRow(24, 22)]
        [DataRow(26, 26)]
        [TestMethod]
        public void DeterminarGanadorEnvido_DeberiaGanarJug1(int jug1, int jug2)
        {
            List<Usuario> jugadores = CrearPartidaPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);
            jugadores[0].EsMano = true;

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.AreEqual(jugadores[0].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(2, jugadores[0].PuntosPartida);
            Assert.AreNotEqual(jugadores[1].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(0, jugadores[1].PuntosPartida);
        } 
        
        
        [DataRow(21, 32)]
        [DataRow(26, 28)]
        [DataRow(29, 29)]
        [TestMethod]
        public void DeterminarGanadorEnvido_DeberiaGanarJug2(int jug1, int jug2)
        {
            List<Usuario> jugadores = CrearPartidaPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);
            jugadores[1].EsMano = true;

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.AreEqual(jugadores[1].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(2, jugadores[1].PuntosPartida);
            Assert.AreNotEqual(jugadores[0].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(0, jugadores[0].PuntosPartida);
        }
        
        [DataRow(25, 30)]
        [DataRow(26, 24)]
        [TestMethod]
        public void DeterminarGanadorEnvido_Deberia(int jug1, int jug2)
        {
            List<Usuario> jugadores = CrearPartidaPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.IsTrue(jugadores[1].NombreUsuario + " ganó envido" == ganador || jugadores[0].NombreUsuario + " ganó envido" == ganador);
            Assert.IsTrue(2 == jugadores[1].PuntosPartida && jugadores[0].PuntosPartida == 0 || 2 == jugadores[0].PuntosPartida && jugadores[1].PuntosPartida == 0);
        }

        [TestMethod]
        public void AsignarTurno_Deberia() // faltan más unit testing pero necesito pasar las cartas como datarow
        {
            List<Usuario> jugadores = CrearPartidaPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsTrue(EsTurnoDeJug2);
        }

        //[DataRow (15,13)]
        //[DataRow (14,16)]
        //[TestMethod]
        //public void AsignarPuntos_Deberia(int jug1, int jug2)
        //{
        //    List<Usuario> jugadores = CrearPartidaPrueba();
        //    Partida partida = new Partida(0, jugadores, DateTime.Now);
        //    jugadores[0].PuntosPartida = jug1;
        //    jugadores[1].PuntosPartida = jug2;

        //    partida.AsignarPuntos();

        //}
    }
}
