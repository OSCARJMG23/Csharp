using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Masajista : Persona
    {
        public int AñosDeExp {get; set;}
        public string Titulacion {get; set;}

        public Masajista (string Nombre, int Edad, string CiudadOrigen, int Id, int añosDeExp, string titulacion): base (Nombre,Edad,CiudadOrigen,Id){
        this.AñosDeExp = añosDeExp;
        this.Titulacion = titulacion;
        }
    }


}