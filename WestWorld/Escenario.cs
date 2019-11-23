using System;
using System.Collections.Generic;
using System.Text;


namespace WestWorld
{
    interface ICategoria
{
    public int Extra();
    public void AumentarVisitas();
        public void Evolucionar();
}
    public class Escenario
    {
        public string nombre;
        public ICategoria categoria;

        public int Fama()
        {
            return 100; + categoria.extra();
        }

        public void AumentarVisitas()
        {
            categoria.AumentarVisitas();
        }

        public void Evolucionar()
        {
            categoria.Evolucionar(this);
        }
    }

    public class BajoCoste : ICategoria
    {
        public string zona;
        public int Extra()
        {
            return zona.Length;
        }

        public void AumentarVisitas() { }

        public void Evolucionar(Escenario unEscenario)
        {
            unEscenario.categoria(new Estandar());
        }
    }

    public class Estandar : ICategoria
    {
        public int Extra()
        {
            return 10;
        }

        public void AumentarVisitas() { }

        public void Evolucionar(Escenario unEscenario)
        {
            unEscenario.categoria(new DeLujo());
        }
    }

    public class DeLujo : ICategoria
    {
        public int visitas;
        public int Extra()
        {
            return visitas;
        }

        public void AumentarVisitas()
        {
            visitas++;
        }

        public void Evolucionar(Escenario unEscenario)
        {
            Console.WriteLine("NoPuedeEvolucionarExcepcion: {0}", "DeLujo no puede evolucionar mas");
        }
    }

    public class NoPuedeEvolucionarExcepcion : Exception
    {
        public NoPuedeEvolucionarExcepcion(string mensaje) : base(mensaje) { }
    }
}
