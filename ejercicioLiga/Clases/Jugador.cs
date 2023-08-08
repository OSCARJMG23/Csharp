using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases
{
    public class Jugador : Persona
    {
        public int Dorsal {get; set;}
        public string Posicion {get;set;}
        public int NivelHabilidad {get; set;}
        public string PiernaHabil {get;set;}

        public Jugador (string Nombre, int Edad,string CiudadOrigen, int Id, int dorsal, string posicion, int nivelHabilidad, string piernaHabil):base ( Nombre, Edad, CiudadOrigen, Id){
            this.Dorsal = dorsal;
            this.Posicion= posicion;
            this.NivelHabilidad= nivelHabilidad;
            this.PiernaHabil = piernaHabil;
        }
        public Jugador(){}
        public Jugador agregarJugador()
        {
            Jugador jugador = new Jugador();
            
            Console.Write("Ingrese el nombre del jugador: ");
            jugador.Nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del jugador: ");
            jugador.Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la ciudad de origen del jugador: ");
            jugador.CiudadOrigen = Console.ReadLine();

            Console.Write("Ingrese el ID del jugador: ");
            jugador.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el dorsal del jugador: ");
            jugador.Dorsal = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese la posición del jugador: ");
            jugador.Posicion = Console.ReadLine();

            Console.Write("Ingrese el nivel de habilidad del jugador: ");
            jugador.NivelHabilidad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese cual es la pierna habil del jugador: ");
            jugador.PiernaHabil = Console.ReadLine();
            
            return jugador;
        }

        public Jugador buscarJugador(List<Jugador> jugadores)
        {
            foreach (var jugador in jugadores){
                Console.WriteLine($"{jugador.Id}\t {jugador.Nombre}\t {jugador.Edad}\t {jugador.CiudadOrigen}\t {jugador.Dorsal}\t {jugador.Posicion}\t {jugador.NivelHabilidad}\t {jugador.PiernaHabil}");
            }
            Console.Write("Ingrese el nombre del jugador: ");
            string nombreBuscar =Console.ReadLine();

            Jugador jugadorSeleccionado = jugadores.Find(jugador=>jugador.Nombre.Equals(nombreBuscar));
            Console.WriteLine($"{jugadorSeleccionado.Id}\t {jugadorSeleccionado.Nombre}\t {jugadorSeleccionado.Edad}\t {jugadorSeleccionado.CiudadOrigen}\t {jugadorSeleccionado.Dorsal}\t {jugadorSeleccionado.Posicion}\t {jugadorSeleccionado.NivelHabilidad}\t {jugadorSeleccionado.PiernaHabil}");
            return jugadorSeleccionado;
        }
    }

}