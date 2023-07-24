// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] filas = {1, 2, 3, 4, 5, 6, 7, 8};
string[] columnas = {"a", "b", "c", "d", "e", "f", "g", "h"};

int[] movimientosColumna = {2, 2, -2, -2, 1, -1, 1, -1};
int[] movimientosFila = {1, -1, 1, -1, 2, 2, -2, -2};

Console.Write("\nIngrese la fila en la que se encuentra el caballo: ");
int fila = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIngrese la columna en la que se encuentra el caballo: ");
string? columna = Console.ReadLine();

int posicionFila = Array.IndexOf(filas,fila);
int posicionColumna = Array.IndexOf(columnas,$"{columna}");

Console.Write(posicionColumna + " "+ posicionFila);
Console.WriteLine("\nLas posiciones a las que puede acceder el caballo son: ");

for(int i = 0; i < 8; i++)
{
    int newRow = posicionFila + movimientosFila[i];
    int newCol = posicionColumna + movimientosColumna[i];

    if(newRow >=0 && newRow < 8 && newCol>=0 && newCol <8)
    {
        Console.WriteLine($"\nFila: {filas[newRow]}, Columna: {columnas[newCol]}");
    }
}