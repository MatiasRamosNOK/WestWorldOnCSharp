using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WestWorld
{
    class Huesped : Personaje
    {
        public int minutosRestantes;
        public List<Personaje> amigos;

        public Huesped(int minutos, List<Personaje> unosAmigos)
        {
            minutosRestantes = minutos;
            amigos = unosAmigos;
        }

        public override float Felicidad()
        {
            return minutosRestantes * this.FelicidadAmigos();
        }

        public int FelicidadAmigos()
        {
            return amigos.Sum((amigo)=>(int)amigo.Felicidad());
        }

        public override void ConsecuenciasDeConocerEscenario(Escenario escenario)
        {
            minutosRestantes -= 10;
        }

        public override void Interactuar(Personaje personaje)
        {
            base.Interactuar(personaje);
            minutosRestantes -= 10;
        }
    }
}
