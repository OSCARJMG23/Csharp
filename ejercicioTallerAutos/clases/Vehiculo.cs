using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.clases
{
    public class Vehiculo
    {
        public string Placa {get; set;}
        public string Modelo {get; set;}
        public string Marca {get; set;}
        public string Color {get; set;}
        public double Kilometraje {get; set;}

        public Vehiculo(string placa, string modelo, string marca, string color, double kilometraje){
            this.Placa = placa;
            this.Modelo = modelo;
            this.Marca = marca;
            this.Color = color;
            this.Kilometraje = kilometraje;
        }
        public Vehiculo(){  }

        public void agregarVehiculo(){

            Console.Write("Ingrese la placa del vehiculo: ");
            Placa = Console.ReadLine();
            Console.Write("Ingrese el modelo del vehiculo: ");
            Modelo = Console.ReadLine();
            Console.Write("Ingrese la marca del vehiculo: ");
            Marca = Console.ReadLine();
            Console.Write("Ingrese el color del vehiculo: ");
            Color = Console.ReadLine();
            Console.Write("Ingrese el kilometraje del vehiculo: ");
            Kilometraje = Convert.ToDouble(Console.ReadLine());
            
        }
    }
}