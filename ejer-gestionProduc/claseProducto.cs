using System;

public class Producto
{
    public int Codigo { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public int Inventario { get; set; }
    public List<string> Clientes { get; set; }


    public Producto(int codigo, string nombre, double precio, int inventario, List<string> clientes)
    {
        Codigo = codigo;
        Nombre = nombre;
        Precio = precio;
        Inventario = inventario;
        Clientes = clientes;
    }

    public void MostrarDetalles()
    {
        string clientes = string.Join(", ", Clientes);
            Console.WriteLine("********************* Producto Encontrado *********************\n");
            Console.WriteLine($"Codigo Producto: {Codigo} Nombre Producto: {Nombre} Precio: {Precio} Inventario:{Inventario} Clientes: {clientes}");
    }


}