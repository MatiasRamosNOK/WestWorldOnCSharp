using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WestWorld
{
    class Anfitrion : Personaje
    {
        public int minutosRestantes;
        public List<Personaje> amigos;

        public override int Felicidad()
        {
            return minutosRestantes * FelicidadAmigos();
        }

        public int FelicidadAmigos()
        {
            return amigos.Sum((amigo)=>amigo.Felicidad());
        }

        public override void ConsecuenciasDeConocerEscenario(Escenario escenario){ }
    }
}
