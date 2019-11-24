using System;
using System.Collections.Generic;
using System.Text;

namespace WestWorld
{
    class Anfitrion : Personaje
    {
        public int velocidadProcesamiento;
        List<Recuerdo> recuerdos;

        override public int Felicidad()
        {
            return energia / velocidadProcesamiento;
        }

        public override void ConsecuenciasDeConocerEscenario(Escenario escenario)
        {
            recuerdos.Add(new Recuerdo("Conoci un escenario", escenario));
        }
    }

    class Recuerdo
    {
        public string descripcion;
        public Escenario escenario;

        public Recuerdo(string unaDescripcion, Escenario unEscenario)
        {
            descripcion = unaDescripcion;
            escenario = unEscenario;
        }
    }
}
