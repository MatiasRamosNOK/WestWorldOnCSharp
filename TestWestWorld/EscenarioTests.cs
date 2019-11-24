using System;
using Xunit;
using WestWorld;

namespace TestWestWorld
{
    public class TestDeEscenario
    {
        [Fact]
        public void LaFamaDelEscenarioDeberiaSer114()
        {
            var bajoCosto = new BajoCoste("Un Viejo Local");
            var unEscenario = new Escenario("Escenario Viejo", bajoCosto);

            Assert.Equal(114, unEscenario.Fama());
        }

        [Fact]
        public void LaFamaDeUnEscenarioEstandarEs110()
        {
            var estandar = new Estandar();
            var unEscenario = new Escenario("Escenario Viejo", estandar);

            Assert.Equal(110, unEscenario.Fama());
        }

        [Fact]
        public void UnEscenarioDeBajoCosteEvoluciona()
        {
            var bajoCosto = new BajoCoste("Un Viejo Local");
            var unEscenario = new Escenario("Escenario Viejo", bajoCosto);

            unEscenario.Evolucionar();

            Assert.IsType<Estandar>(unEscenario.Categoria());
        }

        [Fact]
        public void UnEscenarioStandarEvoluciona()
        {
            var estandar = new Estandar();
            var unEscenario = new Escenario("Escenario Viejo", estandar);

            unEscenario.Evolucionar();

            Assert.IsType<DeLujo>(unEscenario.Categoria());
        }

        [Fact]
        public void UnEscenarioDeLujoNoPuedeEvolucionar()
        {
            var deLujo = new DeLujo(0);
            var unEscenario = new Escenario("Escenario Viejo", deLujo);

            Assert.Throws<NoPuedeEvolucionarExcepcion>(()=>unEscenario.Evolucionar());
        }
    }
}
