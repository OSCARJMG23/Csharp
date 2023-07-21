class Lenguaje
{
    private string nombre;
    private int año;
    public Lenguaje(string nombre, int año)
    {
        this.nombre = nombre;
        this.año = año;
    }
    public void descripcion()
    {
        Console.WriteLine("{0} fue creado en {1}",this.nombre,this.año);
    }
}