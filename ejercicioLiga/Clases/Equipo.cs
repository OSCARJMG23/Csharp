using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Equipo
    {
        public string Nombre {get;set;}
        public List<string> Propietarios {get;set;}
        public List<Jugador> Jugadores {get; set;}
        public List<Entrenador> Entrenadores {get; set;}
        public List<Masajista> Masajistas {get; set;}

        public Equipo(string nombre){
            this.Nombre = nombre;
            this.Propietarios= new List<string>();
            this.Jugadores =new List<Jugador>();
            this.Entrenadores = new List<Entrenador>();
            this.Masajistas = new List<Masajista>();
        }

        public Equipo(){
            this.Propietarios= new List<string>();
            this.Jugadores =new List<Jugador>();
            this.Entrenadores = new List<Entrenador>();
            this.Masajistas = new List<Masajista>();
        }

        public Equipo agregarEquipo()
        {
            Equipo equipo = new Equipo();

            Console.Write("Ingrese el nombre del equipo: ");
            equipo.Nombre = Console.ReadLine();

            return equipo;
        }
        public void consultarEquipo(List<Equipo> EquiposLigas){
            Console.WriteLine("Equipos");
            foreach (var equipo in EquiposLigas){
                Console.WriteLine($"{equipo.Nombre}");
            }
            Console.Write("Ingrese el nombre del equipo: ");
            string nombreConsultar = Console.ReadLine();
            
            Equipo equipoSeleccionado = EquiposLigas.Find(equipo => equipo.Nombre.Equals(nombreConsultar));
            Console.WriteLine("Nombre Equipo \t\t ")
            Console.WriteLine($"{equipoSeleccionado.Nombre}\t{equipoSeleccionado.Propietarios.Count} \t{equipoSeleccionado.Jugadores.Count} \t{equipoSeleccionado.Entrenadores.Count} \t{equipoSeleccionado.Masajistas.Count}");
        }
    }
}