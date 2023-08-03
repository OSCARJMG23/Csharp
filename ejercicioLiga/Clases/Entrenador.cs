using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Entrenador : Persona
    {
        public int CodFederacion {get; set;}
        public string Especialidad {get; set;}

        public Entrenador(string Nombre, int Edad, string CiudadOrigen, int Id, int codFederacion, string especialidad): base (Nombre,Edad,CiudadOrigen,Id){
            this.CodFederacion = codFederacion;
            this.Especialidad = especialidad;
        }
    }
}