using System;
using System.Collections.Generic;
class Program {
    public static  Dictionary<int,Usuario> Usuarios = new Dictionary<int, Usuario>();
    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    AgregarUsuario();
                    break;
                case 2:
                    MostrarUsuario();
                    break;
                case 3:
                    MostrarUsuarios();
                    break;
                case 4:
                    EiminarUsuario();
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
        Console.WriteLine("1. Agregar Nuevo Usuario");
        Console.WriteLine("2. Consultar Usuario");
        Console.WriteLine("3. Mostrar Usuarios");
        Console.WriteLine("4. Eliminar Usuario");
        Console.WriteLine("5. Salir del programa");     
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AgregarUsuario() {
        List<string> hobbies = new List<string>();
        Console.Write("Numero de documento del Usuario: ");
        int nDoc = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nombre del usuario: ");
        string? name = Console.ReadLine();
        Console.Write("Edad del usuario: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cuantos hobbies tiene el usuario: ");
        int nHobbies = Convert.ToInt32(Console.ReadLine());
        for(int i =0; i < nHobbies; i++)
        {
            Console.Write("Introduce el hobby: ");
            string? hobby = Console.ReadLine();
            hobbies.Add(hobby);
        }
        Usuario usuario = new Usuario(name, edad, hobbies);
        Usuarios.Add(nDoc,usuario);
    }

    static void MostrarUsuario() {
        Console.Write("Ingrese el numero de documento del usuario a consultar: ");
        int nConsult = Convert.ToInt32(Console.ReadLine());
        if (Usuarios.ContainsKey(nConsult))
        {
            var user = Usuarios[nConsult];
            string hobies = string.Join(", ",user.Hobbies);
            Console.WriteLine("********************* Usuario Encontrado *********************\n");
            Console.WriteLine($"Nombre: {user.Nombre} Edad: {user.Edad} Hobbies: {hobies}");
        }
        else
        {
            Console.WriteLine($"El usuario con numero de documento {nConsult} no existe");
        }
    }

    static void MostrarUsuarios() {
        Console.WriteLine("*********************   Usuarios Disponibles   *********************\n");
        if(Usuarios.Count >=1)
        {
            foreach (var usuario in Usuarios)
            {
                int nDoc = usuario.Key;
                var user = usuario.Value;

                string hobbies = string.Join(", ", user.Hobbies); // Unir los hobbies en una cadena separada por comas

                Console.WriteLine($"Número de documento: {nDoc} \t Nombre: {user.Nombre} \t Edad: {user.Edad} \t Hobbies: {hobbies}");
            }
        
        }
        else
        {
            Console.WriteLine("No hay usuarios registrados.");
        }
    }
    static void EiminarUsuario() {
        Console.Write("Ingrese el documento del usuario a eliminar: ");
        int nDocDelete = Convert.ToInt32(Console.ReadLine());
        if(Usuarios.ContainsKey(nDocDelete))
        {
            Usuarios.Remove(nDocDelete);
            Console.WriteLine("********************* Usuario eliminado *********************");
        }
        else
        {
            Console.WriteLine($"**************** El usuario con numero de documento {nDocDelete} no existe ****************");
        }

    }
}
