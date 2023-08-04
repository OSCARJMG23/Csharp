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

        public Masajista (){}

        public Masajista agregarMasajista(){
            Masajista masajeador = new Masajista();

            Console.Write("Ingrese el nombre del masajista: ");
            masajeador.Nombre=Console.ReadLine();
            Console.Write("Ingrese la edad del masjista: ");
            masajeador.Edad= Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la ciudad de origen del masjista: ");
            masajeador.CiudadOrigen=Console.ReadLine();
            Console.Write("Ingrese el ID del masjista: ");
            masajeador.Id=Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese los años de experiencia que tiene el masjista: ");
            masajeador.AñosDeExp= Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la titulacion del masajista: ");
            masajeador.Titulacion = Console.ReadLine ();
            return masajeador;
        }
    }


}