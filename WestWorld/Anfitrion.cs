using System;
using System.Collections.Generic;
using System.Text;

namespace WestWorld
{
    public class Anfitrion : Personaje
    {
        public float velocidadProcesamiento;
        List<Recuerdo> recuerdos;

        public Anfitrion(int unaEnergia, float unavelocidadDeProcesamiento, List<Recuerdo> unosRecuerdos)
        {
            energia = unaEnergia;
            velocidadProcesamiento = unavelocidadDeProcesamiento;
            recuerdos = unosRecuerdos;
        }
        override public float Felicidad()
        {
            return energia / velocidadProcesamiento;
        }

        public override void ConsecuenciasDeConocerEscenario(Escenario escenario)
        {
            recuerdos.Add(new Recuerdo("Conoci un escenario", escenario));
        }
    }

    public class Recuerdo
    {
        public string descripcion;
        public Escenario escenario;

        public Recuerdo(string unaDescripcion, Escenario unEscenario)
        {
            descripcion = unaDescripcion;
            escenario = unEscenario;
        }

        public int EmotividadDeUnRecuerdo()
        {
            return descripcion.Length * escenario.Fama();
        }
    }
}
