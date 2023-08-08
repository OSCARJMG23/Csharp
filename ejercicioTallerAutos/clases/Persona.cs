using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class Persona
    {
        public double Cc {get; set;}
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public double NumeroMovil {get; set;}


        public Persona(double cc, string nombre, string apellido, double numeroMovil){
            this.Cc = cc;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NumeroMovil = numeroMovil;
        }

        public Persona(){  }
    }
}