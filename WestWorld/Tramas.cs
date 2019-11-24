using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WestWorld
{
    public class Trama
    {
        List<Personaje> personajes = new List<Personaje>();
        public Escenario escenario;

        public Escenario Escenario() { return escenario; }
        
        public dynamic Personajes()
        {
            return personajes;
        }

        public int FelicidadPersonajes()
        {
            return personajes.Sum((personaje)=> (int)personaje.Felicidad());
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
    }
}
