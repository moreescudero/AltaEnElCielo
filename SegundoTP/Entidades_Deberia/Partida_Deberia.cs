﻿using Entidades.Modelo;
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
        //[TestMethod]
        //public void Barajar_Deberia()
        //{
        //    Mazo mazo = Serializador<Mazo>.LeerJSon("mazo.json"); //me tira excepcion por no encontrar el archivo
        //    List<Carta> listaMazo = mazo.Mazos;
        //    Partida partida = new Partida(0);

        //    partida.Barajar(listaMazo);

        //    Assert.IsTrue(listaMazo.Count == 6);
        //    Assert.IsNotNull(listaMazo);
        //}

        //[DataRow ()]
        //[TestMethod]
        //public void Repartir_Deberia()
        //{

        //}

        //[TestMethod] //no se como pasar un objeto para que pueda ser nulo
        //public void TirarCarta_Deberia()
        //{

        //}

        [DataRow(30, 20)]
        [DataRow(24, 22)]
        [DataRow(26, 26)]
        [TestMethod]
        public void DeterminarGanadorEnvido_DeberiaGanarJug1(int jug1, int jug2)
        {
            List<Usuario> jugadores = new List<Usuario>()
            {
                new Usuario (0, "jug1", "test"),
                new Usuario (0, "jug2", "test")
            };
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
            List<Usuario> jugadores = new List<Usuario>()
            {
                new Usuario (0, "jug1", "test"),
                new Usuario (0, "jug2", "test")
            };
            Partida partida = new Partida(0, jugadores, DateTime.Now);
            jugadores[1].EsMano = true;

            string? ganador = partida.DeterminarGanadorEnvido(jug1, jug2);

            Assert.IsNotNull(ganador);
            Assert.AreEqual(jugadores[1].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(2, jugadores[1].PuntosPartida);
            Assert.AreNotEqual(jugadores[0].NombreUsuario + " ganó envido", ganador);
            Assert.AreEqual(0, jugadores[0].PuntosPartida);
        }

    }
}
