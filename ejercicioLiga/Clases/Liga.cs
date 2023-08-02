using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Liga
    {
        int Id {get; set;}
        string Nombre {get; set;}
        List<Equipo> Equipos {get; set;}

        public Liga(int id, string nombre){
            this.Id = id;
            this.Nombre = nombre;
            this.Equipos = new List<Equipo>();
        }

        public void CrearLiga(){
            Console.WriteLine("Nombre de nueva liga");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el nombre: ");
            string nombre = Console.ReadLine();
        }
    }
}