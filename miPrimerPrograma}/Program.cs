// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!");
Console.WriteLine("El dia esta soleado");
Console.Write("hace calor");

int[] numeros = {10,20,30, 40,50};
foreach(int i in numeros){
    Console.WriteLine(i);
}
int longitud = numeros.Length;
Console.WriteLine(longitud); */

int[] filas = {1,2,3,4,5,6,7,8};
string[] columnas = {"a","b","c","d","e","f","g","h"};

Console.Write("Ingrese la fila en la que se encuentra el caballo: ");
int fila = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la columna en la que se encuentra el caballo: ");
string ? columna = Console.ReadLine();

int[] movimientos;