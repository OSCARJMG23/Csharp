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

            Console.Write("Cuantos propietarios tiene el equipo: ");
            int cantidadPropietario = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i < cantidadPropietario; i++)
            {
                Console.Write($"Ingrese el Nombre de Propietario #{i+1}: ");
                equipo.Propietarios.Add((Console.ReadLine()));
            }

            return equipo;
        }
        public Equipo consultarEquipo(List<Equipo> EquiposLigas){
            Console.WriteLine("Equipos");
            foreach (var equipo in EquiposLigas){
                Console.WriteLine($"{equipo.Nombre}");
            }
            Console.ReadKey();

            Console.Write("Ingrese el nombre del equipo: ");
            string nombreConsultar = Console.ReadLine();
            
            Equipo equipoSeleccionado = EquiposLigas.Find(equipo => equipo.Nombre.Equals(nombreConsultar));
            Console.WriteLine("Nombre Equipo \t\t ");
            Console.WriteLine($"{equipoSeleccionado.Nombre}\t{equipoSeleccionado.Propietarios.Count} \t{equipoSeleccionado.Jugadores.Count} \t{equipoSeleccionado.Entrenadores.Count} \t{equipoSeleccionado.Masajistas.Count}");
            Console.ReadKey();
            return equipoSeleccionado;
        }

        public void listarJugadores(List<Jugador> jugadores){
            Console.WriteLine("Jugadores");
            foreach(var jugador in jugadores){
                Console.WriteLine($"{jugador.Id}\t {jugador.Nombre}\t {jugador.Edad}\t {jugador.CiudadOrigen}\t {jugador.Dorsal}\t {jugador.Posicion}\t {jugador.NivelHabilidad}\t {jugador.PiernaHabil}");
            }
            Console.ReadKey();
        }
        public void listarDelanteros(List<Jugador> jugadores){
            Console.WriteLine($"Delanteros{this.Nombre}");
            foreach(var jugador in jugadores)
            {
                if(jugador.Posicion.ToUpper().Equals("DELANTERO"))
                {
                    Console.WriteLine($"{jugador.Id}\t {jugador.Nombre}\t {jugador.Edad}\t {jugador.CiudadOrigen}\t {jugador.Dorsal}\t {jugador.Posicion}\t {jugador.NivelHabilidad}\t {jugador.PiernaHabil}");
                }
                Console.ReadKey();
            }
        }
        public void listarEntrenadores(List<Entrenador> entrenadores){
            Console.WriteLine($"Entrenadores{this.Nombre}");
            foreach(var entrenador in entrenadores)
            {
                Console.WriteLine($"{entrenador.Id}\t {entrenador.Nombre}\t {entrenador.Edad}\t {entrenador.CiudadOrigen}\t {entrenador.CodFederacion}\t {entrenador.Especialidad}");
                Console.ReadKey();
            }
        }
    }
}