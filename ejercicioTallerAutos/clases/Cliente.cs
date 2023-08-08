using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class Cliente : Persona
    {
        public string Email {get; set;}
        public string FechaRegistro {get; set;}
        public List<Vehiculo> Vehiculos {get; set;}


        public Cliente(double Cc, string Nombre, string Apellido, double NumeroMovil, string email, string fechaRegistro):base(Cc, Nombre, Apellido, NumeroMovil){
            this.Email = email;
            this.FechaRegistro = fechaRegistro;
            this.Vehiculos = new List<Vehiculo>();
        }

        public Cliente(){  }

        public  Cliente agregarCliente(){
            Cliente cliente = new Cliente();
            Console.Write("Ingrese el numero de documento del cliente: ");
            cliente.Cc = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el nombre del cliente: ");
            cliente.Nombre = Console.ReadLine();
            Console.Write("Ingrese el apellido del cliente: ");
            cliente.Apellido = Console.ReadLine();
            Console.Write("Ingrese el numero de movil del cliente: ");
            cliente.NumeroMovil = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el email del cliente: ");
            cliente.Email = Console.ReadLine();
            Console.Write("Ingrese la fecha de registro del cliente: ");
            cliente.FechaRegistro = Console.ReadLine();

            return cliente;
        }
        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            if (Vehiculos == null)
            {
                Vehiculos = new List<Vehiculo>();
            }
            Vehiculos.Add(vehiculo);
        }
    }
}


