using System;
public class Usuario
{
  public string Nombre { get; set; }
  public int Edad { get; set; }
  public List<string> Hobbies { get; set; }

    public Usuario(string nombre, int edad, List<string> hobbies)
    {
        Nombre = nombre;
        Edad = edad;
        Hobbies = hobbies;
    }
}
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
        } while (opcion != 4);
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
        Usuario usuario = new Usuario(name,edad,hobbies);
        Usuarios.Add(nDoc,usuario);
    }

    static void MostrarUsuario() {
        Console.Write("Ingrese el numero de documento del usuario a consultar: ");
        int nConsult = Convert.ToInt32(Console.ReadLine());
        if (Usuarios.ContainsKey(nConsult))
        {
            var user = Usuarios[nConsult];
            for (int i = 0; i < usuario.Value.Hobbies.Length; i++)
            {
                hobies+= $"{usuario.Value.Hobbies[i]} ";

            }
            Console.WriteLine($"{user.Nombre}, Edad:{user.Edad}. Hobbies:{hobies}");
        }
        else
        {
            Console.WriteLine($"El usuario con numero de documento {nConsult} no existe");
        }
    }

    static void MostrarUsuarios() {
        Console.Write("Ingresa el radio del círculo: ");

    }
    static void EiminarUsuario() {
        Console.Write("Ingresa el radio del círculo: ");

    }
}