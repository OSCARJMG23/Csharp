using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Equipo
    {
        string Nombre {get;set;}
        List<string> Propietarios {get;set;}
        List<Jugador> Jugadores {get; set;}
        List<Entrenador> Entrenadores {get; set;}
        List<Masajista> Masajistas {get; set;}

        public Equipo(string nombre){
            this.Nombre = nombre;
            this.Propietarios= new List<string>();
            this.Jugadores =new List<Jugador>();
            this.Entrenadores = new List<Entrenador>();
            this.Masajistas = new List<Masajista>();
        }
    }
}