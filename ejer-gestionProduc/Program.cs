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
                case 3:
                    listaProductos();
                    break;
                case 4:
                    actualizarPrecioP();
                    break;
                case 5:
                    actualizarInventario();
                    break;
                case 6:
                    actualizarClientes();
                    break;
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

    static void listaProductos() {
        Console.WriteLine("*********************   Productos Disponibles   *********************\n");
        if(Productos.Count >=1)
        {
            foreach (var producto in Productos)
            {
                int codigoP = producto.Key;
                var product = producto.Value;

                string clientes = string.Join(", ", product.Clientes); // Unir los hobbies en una cadena separada por comas

                Console.WriteLine($"Codigo del producto: {codigoP} \t Nombre Producto: {product.Nombre} \t Precio Producto: {product.Precio} \t Inventario: {product.Inventario} \t Clientes: {clientes}");
            }
        
        }
        else
        {
            Console.WriteLine("No hay productos registrados.");
        }
    }
    static void actualizarPrecioP() {
        Console.Write("Ingrese el codigo del producto para actualizar su precio: ");
        int codigoP = Convert.ToInt32(Console.ReadLine());
        if (Productos.ContainsKey(codigoP))
        {
            Console.Write($"Ingrese el nuevo precio del producto con el codigo {codigoP}: ");
            double newPrecioP = double.Parse(Console.ReadLine());

            var product = Productos[codigoP];
            product.ActualizarPrecioP(newPrecioP);
            Console.WriteLine("Precio actualizado correctamente.");
        }
        else
        {
            Console.WriteLine($"El producto con el codigo: {codigoP} no existe");
        }
    }
    static void actualizarInventario() {
        Console.Write("Ingrese el codigo del producto para actualizar su inventario: ");
        int codigoP = Convert.ToInt32(Console.ReadLine());
        if (Productos.ContainsKey(codigoP))
        {
            Console.Write($"Ingrese el nuevo inventario del producto con el codigo {codigoP}: ");
            int newInventarioP = Convert.ToInt32(Console.ReadLine());

            var product = Productos[codigoP];
            product.ActualizarInventarioP(newInventarioP);
            Console.WriteLine($"Inventario del producto {codigoP} actualizado correctamente");
        }
        else
        {
            Console.WriteLine($"No existe ningun producto con el codigo {codigoP}");
        }
    }
    static void actualizarClientes()
    {
        Console.Write("Ingrese el codigo del producto para actualizar sus clientes: ");
        int codigoP = Convert.ToInt32(Console.ReadLine());
        if (Productos.ContainsKey(codigoP))
        {
            Console.Write($"Ingrese la cantidad de nuevos clientes para el producto con el codigo {codigoP}: ");
            int nClientes = Convert.ToInt32(Console.ReadLine());
            List<string> nuevosClientes = new List<string>();

            for (int i = 0; i < nClientes; i++)
            {
                Console.Write("Introduce el nombre del nuevo cliente: ");
                string nuevoCliente = Console.ReadLine();
                nuevosClientes.Add(nuevoCliente);
            }

            var product = Productos[codigoP];
            product.actualizarClientesP(nuevosClientes);
            Console.WriteLine($"Clientes del producto {codigoP} actualizados correctamente.");
        }
        else
        {
            Console.WriteLine($"No existe ningun producto con el codigo {codigoP}");
        }
    }
}
