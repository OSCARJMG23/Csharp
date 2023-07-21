// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.Write("Ingresa el límite de la suma: ");
int limite = Convert.ToInt32(Console.ReadLine());

int suma = 0;
int numero;

Console.WriteLine("Ingresa números para sumar (ingresa 0 para terminar):");

numero = Convert.ToInt32(Console.ReadLine());
suma += numero;

while (suma < limite && numero != 0) {
    numero = Convert.ToInt32(Console.ReadLine());
    suma += numero;
}

Console.WriteLine($"La suma total es: {suma}");
