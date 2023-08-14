using Newtonsoft.Json;
using ejercicioLinQProductosJson;
using ejercicioLinQProductosJson.Entities;
using ejercicioLinQProductosJson.View;

internal class Program
{
    private static void Main(string[] args)
    {
        int opcion;
        string json; 
        if(Env.ValidarFile(Env.FileName)==false)
        {
            File.WriteAllText(Env.FileName, "");
        }else{
            Env.LoadDataProductos(Env.FileName);
        }
        /* Env.ImprimirDAta("ddddd",Env.TiendaCampus.Categorias); */
        MenusView menu = new MenusView();
        do{
            opcion = menu.mostrarMenu();
            switch(opcion){
                case 1:
                    Producto.addProducto();
                    json = JsonConvert.SerializeObject(Env.TiendaCampus,Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
                case 2:
                    Categoria.addCategoria();
                    json= JsonConvert.SerializeObject(Env.TiendaCampus,Formatting.Indented);
                    File.WriteAllText(Env.FileName, json);
                    break;
                case 3:
                    Categoria lista = new ();
                    Env.ImprimirDAta<Categoria>("Lista Categorias \n", lista.ListaCategorias());
                    break;
                case 4:
                    Producto listaPro = new ();
                    Env.ImprimirDAta<Producto>("Lista Productos \n", listaPro.ListaProductos());
                        Producto listaProductos = new Producto();
/*                         Console.WriteLine("Listado de productos");
                        Console.WriteLine("{0,-15}{1,-20}{2,-10}", "id producto", "nombre producto", "stock");
                        foreach (var producto in listaProductos.ListaProductos())
                        {
                            Console.WriteLine("{0,-15}{1,-20}{2,-10}", producto.CodProducto, producto.NombreProducto, producto.Stock);
                        } */
                    break;
                case 5:
                    Console.WriteLine("\t\tCalculando el valor del inventario");
                    
                    Console.WriteLine("{0,-10}{1, -20}{2, -10}{3,-15}{4,-15}","ID","Producto","Stock", "Valor Uni","Subtotal");
                    double totalInventario = 0;
                    foreach(var producto in Env.TiendaCampus.Productos)
                    {
                        double valorProducto = producto.PrecioCompra * producto.Stock;
                        totalInventario += valorProducto;
                        Console.WriteLine($"{producto.CodProducto,-10}{producto.NombreProducto,-20}{producto.Stock,-10}{producto.PrecioCompra,-15}{valorProducto,-15}");
                    }
                    Console.WriteLine("\n\t\t\t\t      Total inventario: " + totalInventario);
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("See you later");
                    break;
                default:
                Console.WriteLine("Ingresa una opcion valida");
                    break;
            }
        }while(opcion !=6);
    }
}