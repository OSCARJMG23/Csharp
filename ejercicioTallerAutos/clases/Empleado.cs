using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class Empleado : Persona
    {
        public List<string> Especialidades { get; set; }


        public Empleado(double Cc, string Nombre, string Apellido, double NumeroMovil, List<string> especialidades):base(Cc,Nombre,Apellido,NumeroMovil){
            this.Especialidades = especialidades;
        }
        public Empleado(){  }

        public Empleado agregarEmpleado(){
            Empleado empleado = new Empleado();
            Console.WriteLine("Ingrese el numereo de documento del empleado: ");
            empleado.Cc = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el nombre del empleado: ");
            empleado.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del empleado: ");
            empleado.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el numero de movil del empleado: ");
            empleado.NumeroMovil = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cuantas especialidades tiene el empleado: ");
            int canEspecialidades = Convert.ToInt32(Console.ReadLine());
            
            empleado.Especialidades = new List<string>();
            for (int i = 0; i < canEspecialidades; i++)
            {
                Console.WriteLine($"Ingrese la especialidad {i+1} del empleado: ");
                empleado.Especialidades.Add((Console.ReadLine()));
            }
            return empleado;
        }
    }
}