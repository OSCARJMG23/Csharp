using System;
using System.Collections.Generic;
class Program {
    public static  Dictionary<int,Producto> Productos = new Dictionary<int, Producto>();
    static void Main() {
        int opcion;

        do {
            MostrarMenu();
            opcion = PedirOpcion();

            switch (opcion) {
                case 1:
                    AgregarProducto();
                    break;
                case 2:
                    DetallesProducto();
                    break;
                // case 3:
                //     listaProductos();
                //     break;
                // case 4:
                //     actualizarPrecioP();
                //     break;
                // case 5:
                //     actualizarInventario();
                //     break;
                // case 6:
                //     actualiarClientes();
                //     break;
                case 7:
                    Console.WriteLine("Hasta luego.");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 7);
    }

    static void MostrarMenu() {
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine("1. Agregar Nuevo Producto");
        Console.WriteLine("2. Detalles del producto");
        Console.WriteLine("3. Lista de productos");
        Console.WriteLine("4. Actualizar Precio de un Producto");
        Console.WriteLine("5. Actualizar Inventario de un Producto");
        Console.WriteLine("6. Actualizar listado de clientes de un producto");
        Console.WriteLine("7. Salir del programa");     
    }

    static int PedirOpcion() {
        Console.Write("Elige una opción: ");
        return Convert.ToInt32(Console.ReadLine());
    }

    static void AgregarProducto() {
        List<string> clientes = new List<string>();
        Console.Write("Codigo del producto: ");
        int codigoP = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nombre del producto: ");
        string? nombreP = Console.ReadLine();
        Console.Write("Precio del Producto: ");
        double precioP = double.Parse(Console.ReadLine());
        Console.Write("Inventario disponible en stock: ");
        int inventarioP = Convert.ToInt32(Console.ReadLine());
        Console.Write("Cuantos clientes tiene el producto: ");
        int nClientes = Convert.ToInt32(Console.ReadLine());
        for(int i =0; i < nClientes; i++)
        {
            Console.Write("Introduce el nombre del cliente: ");
            string? cliente = Console.ReadLine();
            clientes.Add(cliente);
        }
        Producto producto = new Producto(codigoP, nombreP, precioP, inventarioP,clientes);
        Productos.Add(codigoP,producto);
    }

    static void DetallesProducto() {
        Console.Write("Ingrese el codigo del producto para consultar sus detalles: ");
        int cConsult = Convert.ToInt32(Console.ReadLine());
        if (Productos.ContainsKey(cConsult))
        {
            var products = Productos[cConsult];
            products.MostrarDetalles();
        }
        else
        {
            Console.WriteLine($"El producto con el codigo: {cConsult} no existe");
        }
    }

    // static void MostrarUsuarios() {
    //     Console.WriteLine("*********************   Usuarios Disponibles   *********************\n");
    //     if(Usuarios.Count >=1)
    //     {
    //         foreach (var usuario in Usuarios)
    //         {
    //             int nDoc = usuario.Key;
    //             var user = usuario.Value;

    //             string hobbies = string.Join(", ", user.Hobbies); // Unir los hobbies en una cadena separada por comas

    //             Console.WriteLine($"Número de documento: {nDoc} \t Nombre: {user.Nombre} \t Edad: {user.Edad} \t Hobbies: {hobbies}");
    //         }
        
    //     }
    //     else
    //     {
    //         Console.WriteLine("No hay usuarios registrados.");
    //     }
    // }
    // static void EiminarUsuario() {
    //     Console.Write("Ingrese el documento del usuario a eliminar: ");
    //     int nDocDelete = Convert.ToInt32(Console.ReadLine());
    //     if(Usuarios.ContainsKey(nDocDelete))
    //     {
    //         Usuarios.Remove(nDocDelete);
    //         Console.WriteLine("********************* Usuario eliminado *********************");
    //     }
    //     else
    //     {
    //         Console.WriteLine($"**************** El usuario con numero de documento {nDocDelete} no existe ****************");
    //     }

    // }
}
