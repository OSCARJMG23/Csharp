using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Jugador : Persona
    {
        int Dorsal {get; set;}
        string Posicion {get;set;}
        int NivelHabilidad {get; set;}
        string PiernaHabil {get;set;}

        public Jugador (string Nombre, int Edad,string CiudadOrigen, int Id, int dorsal, string posicion, int nivelHabilidad, string piernaHabil):base ( Nombre, Edad, CiudadOrigen, Id){
            this.Dorsal = dorsal;
            this.Posicion= posicion;
            this.NivelHabilidad= nivelHabilidad;
            this.PiernaHabil = piernaHabil;
        }
    }
}