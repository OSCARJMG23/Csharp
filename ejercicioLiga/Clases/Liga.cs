using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLiga.Clases;

    public class Liga
    {
        private int id;
        public string Nombre {get; set;}
        private List<Equipo> Equipos = new List<Equipo>();

        public int Id
        {
            get{return this.id;}
            set{this.id = value;}
        }
        public List<Equipo> EquiposLiga
        {
            get{return this.Equipos;}
            set{this.Equipos = value;}
        }

        public Liga(int id, string nombre){
            this.Id = id;
            this.Nombre = nombre;
        }
    public Liga(){}
        public void agregarLiga(List<Liga> Ligas)
        {
            Console.Write("Introduce el id de la liga: ");
            int idLiga = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce el nombre: ");
            string nombreLiga = Console.ReadLine();
            Liga liga = new Liga(idLiga,nombreLiga);
            Ligas.Add(liga);
        }
        
        public Liga agregarLiga ()
        {
            Liga liga = new Liga();

            Console.Write("Ingrese el Id de la liga: ");
            liga.id = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nombre de la liga: ");
            liga.Nombre = Console.ReadLine();

            return liga;
        }

        public void mostrarLigas(List<Liga> Ligas)
        {
            Console.Clear();
            Console.WriteLine("Id\tNombre");
            foreach (var liga in Ligas)
            {
                Console.WriteLine($"{liga.id}\t{liga.Nombre}");
            }
            Console.ReadKey();
        }

        public Liga buscarLiga(List<Liga> Ligas)
        {
            mostrarLigas(Ligas);

            Console.Write("Ingrese el Id de la liga: ");
            int opcion = int.Parse(Console.ReadLine());

            return Ligas.Find(e => e.id == opcion);
        }
    }
