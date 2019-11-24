using System;
using Xunit;
using WestWorld;
using System.Collections.Generic;

namespace TestWestWorld
{
    public class TestPersonaje
    {
        [Fact]
        public void ConocerElNivelDeFelicidadDeDoloresQueEsDe112()
        {
            var dolores = new Anfitrion(90, 0.8f, new List<Recuerdo>());

            Assert.Equal(112.5f, dolores.Felicidad());
        }

        [Fact]
        public void ConocerLaFelicidadDeWilliam405k()
        {
            var listaAmigos = new List<Personaje>();
            var dolores = new Anfitrion(90, 0.8f, new List<Recuerdo>());
            listaAmigos.Add(dolores);
            var william = new Huesped(3600,listaAmigos);

            Assert.Equal(403200, william.Felicidad());
        }

        [Fact]
        public void EmotividadDeUnRecuerdoDebeSer880()
        {
            var unRecuerdo = new Recuerdo("Recuerdo", new Escenario("Un recuerdo", new Estandar())); //110 * 8

            Assert.Equal(880, unRecuerdo.EmotividadDeUnRecuerdo());
        }

    }
}
