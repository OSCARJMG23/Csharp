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
                    Env.ImprimirDAta<Categoria>("Lista Categorias ", lista.ListaCategorias());
                    break;
                case 4:
                    Producto listaPro = new ();
                    Env.ImprimirDAta<Producto>("Lista Productos ", listaPro.ListaProductos());
                    break;
                case 5:
                    break;
            }
        }while(opcion !=5);
    }
}