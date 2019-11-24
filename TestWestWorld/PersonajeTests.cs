using System;
using Xunit;
using WestWorld;
using System.Collections.Generic;

namespace TestWestWorld
{
    public class TestPersonaje
    {
        [Fact]
        public void conocerElNivelDeFelicidadDeDoloresQueEsDe112()
        {
            var dolores = new Anfitrion(90, 0.8f, new List<Recuerdo>());

            Assert.Equal(112.5f, dolores.Felicidad());
        }

    }
}
