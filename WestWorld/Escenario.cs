using System;
using System.Collections.Generic;
using System.Text;


namespace WestWorld
{
    interface ICategoria
{
    public int Extra();
    public void AumentarVisitas();
        public void Evolucionar(Escenario unEscenario);
}
    public class Escenario
    {
        public string nombre;
        public dynamic categoria;

        public Escenario(string unNombre, dynamic unaCategoria) 
        {
            nombre = unNombre;
            categoria = unaCategoria;
        }

        public int Fama()
        {
            return 100 + categoria.Extra();
        }

        public void AumentarVisitas()
        {
            categoria.AumentarVisitas();
        }

        public void Evolucionar()
        {
            categoria.Evolucionar(this);
        }

        public void CambiarCategoria(dynamic unaCategoria)
        {
            categoria = unaCategoria;
        }

        public dynamic Categoria()
        {
            return categoria;
        }
    }

    public class BajoCoste : ICategoria
    {
        public string zona;

        public BajoCoste(string unaZona)
        {
            zona = unaZona;
        }
        public int Extra()
        {
            return zona.Length;
        }

        public void AumentarVisitas() { }

        public void Evolucionar(Escenario unEscenario)
        {
            unEscenario.CambiarCategoria(new Estandar());
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
            unEscenario.CambiarCategoria(new DeLujo(0));
        }
    }

    public class DeLujo : ICategoria
    {
        public int visitas;
        public DeLujo(int cantidadVisitas)
        {
            visitas = cantidadVisitas;
        }
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
            throw new NoPuedeEvolucionarExcepcion("DeLujo no puede evolucionar mas");
        }
    }

    public class NoPuedeEvolucionarExcepcion : Exception
    {
        public NoPuedeEvolucionarExcepcion(string mensaje) : base(mensaje) { }
    }
}
