using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercioLinQproductos.View
{
    public static class MenuPrincipal
    {
        public static int mostrarMenu(){
            Console.WriteLine("*** Super Tienda ABS");
            Console.WriteLine("1-Registrar Producto");
            Console.WriteLine("2-Registrar Categoria");
            Console.WriteLine("3-Listar Categorias");
            Console.WriteLine("4-Listar Productos");
            Console.WriteLine("5-Costo total del Inventario");
            Console.WriteLine("6-Salir");
            return int.Parse(Console.ReadLine());
        }
    }
}