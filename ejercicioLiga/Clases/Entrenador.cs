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

        public Entrenador(){}

        public Entrenador agregarEntrenador(){
            Entrenador entrenador = new Entrenador();

            Console.Write("Ingrese el nombre del entrendor: ");
            entrenador.Nombre = Console.ReadLine();
            Console.Write("Ingrese la edad del entrenador: ");
            entrenador.Edad =int.Parse(Console.ReadLine());
            Console.Write("Ingrese la ciudad de origen del entrenador:");
            entrenador.CiudadOrigen=Console.ReadLine();
            Console.Write("Ingrese el ID del entrenador: ");
            entrenador.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el codigo de federacion del entrenador: ");
            entrenador.CodFederacion =Convert.ToInt32 (Console.ReadLine ());
            Console.Write ("Ingrese la especialidad del entrenador: ");
            entrenador.Especialidad =  Console.ReadLine ();
            return entrenador;
        }
    }
}