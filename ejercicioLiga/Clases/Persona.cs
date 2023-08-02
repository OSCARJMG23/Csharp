using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Persona
    {
        public string Nombre {get; set;}
        public int Edad {get; set;}
        public string CiudadOrigen {get; set;}
        public int Id {get; set;}

        public Persona(string nombre, int edad,string ciudadOrigen, int id)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.CiudadOrigen = ciudadOrigen;
            this.Id = id;
            
        }
    }
}