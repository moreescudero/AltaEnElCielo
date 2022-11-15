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
        public void ActivarEventoMazo_Deberia()
        {
            Partida partida = new Partida(0, DevolverJugadoresPrueba(), DateTime.Now);

            partida.ActivarEventoMazo();

            Assert.IsNotNull(partida.Jugadores[0].Cartas);
            Assert.IsNotNull(partida.Jugadores[1].Cartas);
            Assert.IsTrue(partida.Jugadores[0].Cartas.Count == 3 && partida.Jugadores[0].Cartas.Count == 3);
        }

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

        [ExpectedException (typeof(NullReferenceException))]
        [TestMethod]
        public void Barajar_Fallo()
        {
            //Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); 
            List<Carta> listaMazo = null;
            Partida partida = new Partida(0);

            partida.Barajar(listaMazo);

            //Assert.IsFalse(listaMazo.Count == 6);
            //Assert.IsNull(listaMazo);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod]
        public void Repartir_Fallo()
        {
            //Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); 
            List<Carta> listaMazo = null;
            Partida partida = new Partida(0, DevolverJugadoresPrueba(), DateTime.Now);

            //partida.Barajar(listaMazo);
            partida.Repartir(listaMazo);

            //Assert.IsFalse(partida.Jugadores[0].Cartas.Count == 3 && partida.Jugadores[1].Cartas.Count == 3);
            //Assert.IsNull(listaMazo);
        }

        [TestMethod] 
        public void Jugar_DeberiaJug1TirarSuMejorCarta()
        {
            Partida partida = new Partida(0, DevolverJugadoresPrueba(), DateTime.Now);
            partida.ActivarEventoMazo();
            Carta? carta = null;
            for (int i = 0; i < partida.Jugadores[0].Cartas.Count; i++)
            {
                if (carta is null || carta.Valor > partida.Jugadores[0].Cartas[i].Valor)
                {
                    carta = partida.Jugadores[0].Cartas[i];
                }
            }

            Carta cartaTirada = partida.Jugar(partida.Jugadores[0], null);

            Assert.AreEqual(carta.Valor, cartaTirada.Valor);
            Assert.IsTrue(partida.Jugadores[0].Cartas.Count == 2 && partida.Jugadores[0].CartasJugadas.Count == 1 && partida.Jugadores[0].CartaJugada is not null);
        }
        
        [TestMethod] 
        public void Jugar_DeberiaJug2TirarSuMejorCarta()
        {
            Partida partida = new Partida(0, DevolverJugadoresPrueba(), DateTime.Now);
            partida.ActivarEventoMazo();
            Carta? carta = null;
            for (int i = 0; i < partida.Jugadores[1].Cartas.Count; i++)
            {
                if (carta is null || carta.Valor > partida.Jugadores[1].Cartas[i].Valor)
                {
                    carta = partida.Jugadores[1].Cartas[i];
                }
            }

            Carta cartaTirada = partida.Jugar(partida.Jugadores[1], null);

            Assert.AreEqual(carta.Valor, cartaTirada.Valor); 
            Assert.IsTrue(partida.Jugadores[1].Cartas.Count == 2 && partida.Jugadores[1].CartasJugadas.Count == 1 && partida.Jugadores[1].CartaJugada is not null);
        }

        //[TestMethod]
        //public void Jugar_DeberiaJug2Ganar

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
            jugadores[0].CantoEnvido = true;
            jugadores[1].CantoEnvido = true;


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
            jugadores[1].CantoEnvido = true;
            jugadores[0].CantoEnvido = true;

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
            jugadores[0].CantoEnvido = true;
            jugadores[1].CantoEnvido = true;

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.IsTrue(jugadores[1].NombreUsuario + " ganó envido" == ganador || jugadores[0].NombreUsuario + " ganó envido" == ganador);
            Assert.IsTrue(2 == jugadores[1].PuntosPartida && jugadores[0].PuntosPartida == 0 || 2 == jugadores[0].PuntosPartida && jugadores[1].PuntosPartida == 0);
        }

        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug2() 
        {
            List<Usuario> jugadores = DevolverJugadoresPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsTrue(EsTurnoDeJug2 && jugadores[1].CartaJugada is null && jugadores[0].CartaJugada is null);
        }
        
        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug2ConCartas() 
        {
            List<Usuario> jugadores = DevolverJugadoresPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);
            jugadores[1].CartaJugada = new Carta(1, "espada", EValores.AnchoEspada);
            jugadores[0].CartaJugada = new Carta(3, "basto", EValores.Tres);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsTrue(EsTurnoDeJug2);
            Assert.IsNotNull(jugadores[0].CartaJugada);
            Assert.IsNotNull(jugadores[1].CartaJugada);
        }

        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug1() 
        {
            List<Usuario> jugadores = DevolverJugadoresPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);
            jugadores[1].CartaJugada = new Carta(1, "espada", EValores.AnchoEspada);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsFalse(EsTurnoDeJug2 && jugadores[0].CartaJugada is null);
        }

        [TestMethod]
        public void AsignarTurno_DeberiaDarleElTurnoAlJug1ConCartas()
        {
            List<Usuario> jugadores = DevolverJugadoresPrueba();
            Partida partida = new Partida(0, jugadores, DateTime.Now);
            jugadores[0].CartaJugada = new Carta(7, "espada", EValores.SieteEspada);
            jugadores[1].CartaJugada = new Carta(2, "basto", EValores.Dos);

            bool EsTurnoDeJug2 = partida.AsignarTurno();

            Assert.IsFalse(EsTurnoDeJug2);
            Assert.IsNotNull(jugadores[0].CartaJugada);
            Assert.IsNotNull(jugadores[1].CartaJugada);
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
