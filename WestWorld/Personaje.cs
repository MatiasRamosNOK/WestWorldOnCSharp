using System;
using System.Collections.Generic;
using System.Text;

namespace WestWorld
{
    public class Personaje
    {
        public int energia;

        public int Energia{
            set
            {
                energia = value;
            }

            get
            {
                return energia;
            }
        }
        
        public virtual float Felicidad()
        {
            return 1; // devuelve por defecto
        }

        public double Rebeldia()
        {
            return 1 / Felicidad();
        }

        public bool Rebelde()
        {
            return Rebeldia() > 10;
        }

        public virtual void Interactuar(Personaje personaje)
        {
            energia /= 2;
        }

        public virtual void ConsecuenciasDeConocerEscenario(Escenario escenario) { }

        public void InteractuarConMuchos(List<Personaje> personajes)
        {
            personajes.ForEach((personaje) => Interactuar(personaje));
        }

        public void ConocerEscenario(Escenario unEscenario)
        {
            energia -= unEscenario.Fama();
            this.ConsecuenciasDeConocerEscenario(unEscenario);
            unEscenario.AumentarVisitas();
        }
    }
}
