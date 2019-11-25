using System;
using Xunit;
using WestWorld;
using System.Collections.Generic;
using System.Linq;

namespace TestWestWorld
{
    public class TramaTests
    {
        [Fact]
        public void CalcularComplejidadDelEscenarioQueEs1()
        {
            var escenario = new Escenario(" ", new Estandar());
            var dolores = new Anfitrion(110, 1f, new List<Recuerdo>());
            var william = new Huesped(3600, new List<Personaje>());
            var personajes = new List<Personaje>();
            personajes.Add(dolores);
            personajes.Add(william);
            var unaTrama = new Trama(personajes,escenario);
            Assert.Equal(1f, unaTrama.ComplejidadDelEscenario());
        }

        [Fact]
        public void RenovanLaTrama()
        {
            var escenario = new Escenario(" ", new Estandar());
            var dolores = new Anfitrion(10, 100f, new List<Recuerdo>());
            var listaAmigos = new List<Personaje>();
            listaAmigos.Add(dolores);
            var william = new Huesped(3600, listaAmigos);
            var personajes = new List<Personaje>();
            personajes.Add(dolores);
            personajes.Add(william);
            var unaTrama = new Trama(personajes, escenario);

            unaTrama.Renovar();

            var listaDeNoRebeldes = new List<Personaje>();
            listaDeNoRebeldes.Add(william);
            Assert.Equal(listaDeNoRebeldes, unaTrama.Personajes());
        }
    }
}
