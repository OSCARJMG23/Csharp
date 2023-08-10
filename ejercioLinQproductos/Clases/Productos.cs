using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercioLinQproductos.Clases
{
    public class Productos
    {
        public int CodProducto {get; set;}
        public string NombreProducto {get; set;}
        public int Stock {get; set;}
        public int StockMin {get; set;}
        public int StockMax {get; set;}
        public double PrecioVenta {get; set;}
        public double PrecioCompra {get; set;}
        public int IdCategoria {get; set;}

        public Productos () {}

        public Productos agregarProducto()
        {
            Productos producto = new Productos();
            Console.WriteLine("Seccion de Registro de Productos");
            Consosole.Write("Ingrese el codigo del Producto: ");
            producto.CodProducto = Convert.ToInt32(Console.ReadLine());
            Consosole.Write("Ingrese el nombre del Producto: ");
            producto.NombreProducto =  Console.ReadLine();
            Consosole.Write("Ingrese el Stock que tiene del Producto: ");
            producto.Stock = int.Parse(Console.ReadLine());
            Consosole.Write("Ingrese el stock minimo del Producto: ");
            producto.StockMin =int.Parse (Console.ReadLine ());
            Consosole.Write("Ingrese el stock maximo del Producto: ");
            producto.StockMax = Int32.Parse(Console.ReadLine());
            Consosole.Write("Ingrese el precio de venta del Producto: ");
            producto.PrecioVenta = Double.parse(Console.ReadLine());
            Consosole.Write("Ingrese el precio de compra del Producto: ");
            producto.PrecioCompra = Double.Parse(Console.ReadLine());
            Consosole.Write("Ingrese la Categoria del Producto: ");
            producto.IdCategoria = int.Parse(Console.ReadLine());
            return producto;
        }
    }
}