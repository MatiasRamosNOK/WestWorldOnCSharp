using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WestWorld
{
    public class Trama
    {
        List<Personaje> personajes;
        public Escenario escenario;

        public Escenario Escenario() { return escenario; }

        public Trama(List<Personaje> unosPersonajes, Escenario unEscenario)
        {
            personajes = unosPersonajes;
            escenario = unEscenario;
        }
        
        public dynamic Personajes()
        {
            return personajes;
        }

        public Personaje PersonajeMasFeliz()
        {
            var maximaFelicidad = personajes.Max((personaje)=> (int)personaje.Felicidad());
            return personajes.OrderByDescending((personaje) => personaje.Felicidad()).First();
        }

        public void Renovar()
        {
            escenario.Evolucionar();
            personajes.RemoveAll((personaje) => !personaje.Rebelde());
        }

        public void Cruzar(Trama otraTrama)
        {
            this.PersonajesConocenEscenario(otraTrama.Escenario());
            this.CruzarPersonajes(otraTrama.Personajes());
        } 

        public void PersonajesConocenEscenario(Escenario unEscenario)
        {
            personajes.ForEach((personaje) => personaje.ConocerEscenario(unEscenario));
        }

        public void CruzarPersonajes(dynamic unosPersonajes)
        {
            personajes.ForEach((personaje) => personaje.InteractuarConMuchos(unosPersonajes));
        }

        public float ComplejidadDelEscenario()
        {
            return escenario.Fama() / PersonajeMasFeliz().Felicidad();
        }
    }
}
