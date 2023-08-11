using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ejercicioLinQProductosJson.Entities
{
    public class Producto
    {
        public int CodProducto {get; set;}
        public string NombreProducto {get; set;}
        public int Stock {get; set;}
        public int StockMin {get; set;}
        public int StockMax {get; set;}
        public double PrecioVenta {get; set;}
        public double PrecioCompra {get; set;}
        public int IdCategoria {get; set;}

        public Producto(){
            if(!File.Exists(Env.FileName))
            {
                File.WriteAllText(Env.FileName,"");
            }
        }

        public static void addProducto(){
            Producto producto = new Producto();
            Console.WriteLine("Seccion de Registro de Productos");
            Console.Write("Ingrese el codigo del Producto: ");
            producto.CodProducto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nombre del Producto: ");
            producto.NombreProducto =  Console.ReadLine();
            Console.Write("Ingrese el Stock que tiene del Producto: ");
            producto.Stock = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el stock minimo del Producto: ");
            producto.StockMin =int.Parse (Console.ReadLine ());
            Console.Write("Ingrese el stock maximo del Producto: ");
            producto.StockMax = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio de venta del Producto: ");
            producto.PrecioVenta = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese el precio de compra del Producto: ");
            producto.PrecioCompra = Double.Parse(Console.ReadLine());
            Console.Write("Ingrese la Categoria del Producto: ");
            producto.IdCategoria = int.Parse(Console.ReadLine());
            Env.TiendaCampus.Productos.Add(producto);
        }
            public IEnumerable<Producto>ListaProductos(){
            return from produc in Env.TiendaCampus.Productos
                select produc;
        }
    }
}