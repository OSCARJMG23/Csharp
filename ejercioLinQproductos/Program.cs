using ejercioLinQproductos.View;
using ejercioLinQproductos.Clases;
internal class Program
{
        public static List<Productos> Productos = new List<Productos>();
        public static List<Categorias> Categorias = new List<Categorias>();
    public static void Main(string[] args)
    {
        int opcionMenu;
        MenuPrincipal menup = new MenuPrincipal();
        do{
            opcionMenu =  menup.MostrarMenu();
            switch(opcionMenu){
                case 1:
                    Productos nuevoProducto = new Productos();
                    nuevoProducto = nuevoProducto.agregarProducto();
                    Productos.Add(nuevoProducto);
                    break;
                case 2:
                    Categorias nuevaCategoria = new Categorias();
                    nuevaCategoria = nuevaCategoria.agregarCategoria();
                    Categorias.Add(nuevaCategoria);
                    break;
                case 3:
                    listarCategorias();
                    break;
                case 4:
                    listarProductos();
                    break;
                case 5:
                    calcularValorInventario();
                    break;
                case 6:
                    Console.WriteLine("See you later");
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion Valida");
                    break;
            }
        }while(opcionMenu!= 6);
    }
        public static void listarCategorias()
        {
            Console.WriteLine("Listado de  Categorias");
            Console.WriteLine("{0,-30} {1,10}","ID Categoria", "Nombre Categoria");
            foreach(var categoria in Categorias)
            {
                Console.WriteLine("{0,-32} {1,7}", categoria.Id, categoria.Descripcion);
            }
        }
        public static void listarProductos()
        {
            Console.WriteLine("Listado de productos");
            Console.WriteLine("{0,-30} {1,10} {2,18}","ID Producto", "Nombre Producto", "Stock Producto");
            foreach(var producto in Productos)
            {
                Console.WriteLine("{0,-32} {1,7} {2,18}", producto.CodProducto, producto.NombreProducto, producto.Stock);
            }
        }
        public static void calcularValorInventario()
        {
            double totalInventario = Productos.Sum(producto => producto.Stock * producto.PrecioCompra);

            Console.WriteLine("Valor del Inventario");
            Console.WriteLine("--------------------");
            Console.WriteLine("{0,-32} {1,8} {2,12} {3,18} {4,22}", "ID","Nombre","Stock","Valor Unitario", "Subtotal");

            foreach (var producto in Productos)
            {
                double subtotal = producto.Stock * producto.PrecioCompra;
                Console.WriteLine("{0,-32} {1,8} {2,12} {3,18} {4,22}",producto.CodProducto, producto.NombreProducto, producto.Stock, producto.PrecioCompra, subtotal);
            }

            Console.WriteLine($"Total Inventario: {totalInventario:C}");
        }
}