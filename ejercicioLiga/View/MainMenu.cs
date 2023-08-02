namespace ejercicioLiga.View;

    public class MainMenu
    {
        public MainMenu(){  }
        public int MostrarMenu(){
        Console.WriteLine("********* Liga BetPlay *******");
        Console.WriteLine("1. Registro Plantel");
        Console.WriteLine("2. Consulta de Datos");
        Console.WriteLine("3. Salir");
        return Convert.ToInt32(Console.ReadLine());
    }

}
