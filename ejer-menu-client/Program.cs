using System;
using System.Collections;
class Program {
    public static  Dictionary<string,long> contactos = new Dictionary<string, long>();
    static void Main() {
        int opcion;


        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    Agregar();
                    break;
                case 2:
                    MostrarContacto();
                    break;
                case 3:
                    ContactImp();
                    break;
                case 4:
                    EliminarContac();
                    break;
                case 5:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 5);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Agregar Contacto");
        Console.WriteLine("2. Mostrar contactos");
        Console.WriteLine("3. Contacto important");
        Console.WriteLine("4. Eliminar Contacto");
        Console.WriteLine("5. Salir del programa");
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void Agregar() {
        Console.Write("Ingrese el nombre del nuevo cliente: ");
        string? nameCient = Console.ReadLine();
        Console.Write("Ingrese el numero de telefono: ");
        long num = long.Parse(Console.ReadLine());
        contactos.Add(nameCient,num);
    }

    static void MostrarContacto() {
        foreach(KeyValuePair<string,long> contacto in contactos)
        {
            Console.WriteLine($"Nombre: {contacto.Key} Telefono: {contacto.Value}");
        }
    }

    static void ContactImp() {
        MostrarContacto();
        Console.Write("Ingrese el nombre del contacto a marcar como importante: ");
        string? contacFav = Console.ReadLine();

    }
    static void EliminarContac() {
        Console.Write("Ingresa el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * radio * radio;
        Console.WriteLine($"El área del círculo es: {area}");
    }
}