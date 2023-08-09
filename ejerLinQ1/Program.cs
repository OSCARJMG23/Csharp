using ejerLinQ1;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Repuesto> RepuestosList = new List<Repuesto>(){
    new Repuesto() {IdRepuesto = 1, NombreRepuesto ="Luces", PrecioRepuesto = 50.000, Categoria = 1},
    new Repuesto() {IdRepuesto = 2, NombreRepuesto ="Intermitentes", PrecioRepuesto = 30.000, Categoria = 1},
    new Repuesto() {IdRepuesto = 3, NombreRepuesto ="Faros traseros", PrecioRepuesto = 60.000, Categoria = 1},
    new Repuesto() {IdRepuesto = 4, NombreRepuesto ="Supension Delantera", PrecioRepuesto = 350.000, Categoria = 2},
    new Repuesto() {IdRepuesto = 5, NombreRepuesto ="Suspension Trasera", PrecioRepuesto = 350.000, Categoria = 2},
    new Repuesto() {IdRepuesto = 6, NombreRepuesto ="Goma Suspension", PrecioRepuesto = 40.000, Categoria = 2},
    new Repuesto() {IdRepuesto = 7, NombreRepuesto ="Pastillas de freno", PrecioRepuesto = 65.000, Categoria = 3},
    new Repuesto() {IdRepuesto = 8, NombreRepuesto ="Discos", PrecioRepuesto = 450.000, Categoria = 3},
    new Repuesto() {IdRepuesto = 9, NombreRepuesto ="Liquido de frenos", PrecioRepuesto = 205.000, Categoria = 3}
};
    var groupResult = from s in RepuestosList
            group s by s.Categoria;

        foreach (var categoriaGroup in groupResult)
        {
            Console.WriteLine("Categoria: {0}", categoriaGroup.Key);

            foreach (Repuesto repuesto in categoriaGroup)
                Console.WriteLine("Nombre Repuesto {0}", repuesto.NombreRepuesto);

        }
    }
}