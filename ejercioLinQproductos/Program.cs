using ejercioLinQproductos.View;
using ejercioLinQproductos.Clases;
internal class Program
{
    private static void Main(string[] args)
    {
        public List<Productos> Productos = new List<Productos>();
        public List<Categorias> Categorias = new List<Categorias>();
        int opcioMen;
        MenuPrincipal Menu = new MenuPrincipal();
        do{
            opcioMen =  Menu.mostarMenu();
            switch(opcioMen){
                case 1:
                    Productos nuevoProducto = new Productos();
                    nuevoProducto = nuevoProducto.agregarProducto();
                    Productos.Add(nuevoProducto)
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    Console.WriteLine("See you later");
                    break;
                default:
                    Console.WriteLine("Ingrese una opcion Valida");
                    break;
            }while(opcioMen != 6);
        }
    }
}