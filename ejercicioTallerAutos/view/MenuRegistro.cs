using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioTallerAutos.view
{
    public class MenuRegistro
    {
        public MenuRegistro(){  }

        public int MostrarMenu(){
            Console.WriteLine("Centro de reparación Automotriz");
            Console.WriteLine("1. Registrar Nuevo Cliente");
            Console.WriteLine("2. Registrar vehiculo del Cliente");
            Console.WriteLine("3. Registrar Empleado");
            Console.WriteLine("4. Listar Clientes");
            Console.WriteLine("5. Listar Empleados");
            Console.WriteLine("6. Crear Nueva Orden");
            Console.WriteLine("7. Agregar Mecanico a una Orden");
            Console.WriteLine("8. Generar Factura");
            Console.WriteLine("9. salir");
            Console.Write("Seleccione una opción: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}