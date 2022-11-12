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

        [TestMethod]
        public void Barajar_Deberia()
        {
            Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); 
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
            Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); 
            List<Carta> listaMazo = mazo.Mazos;
            Partida partida = new Partida(0, DevolverJugadoresPrueba(), DateTime.Now);

            partida.Barajar(listaMazo);
            partida.Repartir(listaMazo);

            Assert.IsTrue(partida.Jugadores[0].Cartas.Count == 3 && partida.Jugadores[1].Cartas.Count == 3);
        }

        //[TestMethod] //no se como pasar un objeto para que pueda ser nulo
        //public void TirarCarta_Deberia()
        //{

        //}

        private List<Usuario> DevolverJugadoresPrueba()
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
            List<Usuario> jugadores = DevolverJugadoresPrueba();
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
            List<Usuario> jugadores = DevolverJugadoresPrueba();
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
            List<Usuario> jugadores = DevolverJugadoresPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.IsTrue(jugadores[1].NombreUsuario + " ganó envido" == ganador || jugadores[0].NombreUsuario + " ganó envido" == ganador);
            Assert.IsTrue(2 == jugadores[1].PuntosPartida && jugadores[0].PuntosPartida == 0 || 2 == jugadores[0].PuntosPartida && jugadores[1].PuntosPartida == 0);
        }

        [TestMethod]
        public void AsignarTurno_Deberia() // faltan más unit testing pero necesito pasar las cartas como datarow
        {
            List<Usuario> jugadores = DevolverJugadoresPrueba();
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
