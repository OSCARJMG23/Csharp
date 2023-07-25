using System;
using System.Collections;
class Program {
    public static  Dictionary<string,string> contactos = new Dictionary<string, string>();
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
        string num = Console.ReadLine();
        contactos.Add(nameCient,num);
        Console.WriteLine("Contaco agregado con exito!!!");
    }

    static void MostrarContacto() {
        if(contactos.Count >=1)
        {
            Console.WriteLine($"***************** Contactos ***************** \nTienes {contactos.Count} contactos en tu lista\n");
            foreach(KeyValuePair<string,string> contacto in contactos)
            {
                Console.WriteLine($"Nombre: {contacto.Key} Telefono: {contacto.Value}\n");
            }
        }
        else
        {
            Console.WriteLine("Aun no existen contactos en la lista");
        }
    }

    static void ContactImp() {
        MostrarContacto();
        Console.Write("Ingrese el nombre completo del contacto a marcar como importante: ");
        string? contacFav = Console.ReadLine();
        if(contactos.ContainsKey(contacFav))
        {
            contactos[contacFav] = contactos[contacFav]+ "   ⭐";
            Console.WriteLine($"{contacFav} se agrego como contacto importanto o favorito");
        }
        else
        {
            Console.WriteLine($"{contacFav} no existe en la lista de contactos");
        }
        

    }
    static void EliminarContac() {
        Console.Write("Ingrese el nombre del contacto a eliminar: ");
        string? deleteClient = Console.ReadLine();
        if(contactos.ContainsKey(deleteClient))
        {
            contactos.Remove(deleteClient);
            Console.WriteLine($"{deleteClient} ha sido eliminado con exito!!!");
        }
        else
        {
            Console.WriteLine($"{deleteClient} no existe en la lista de clientes");
        }
        
    }
}