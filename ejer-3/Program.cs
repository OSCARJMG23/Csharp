// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
        Console.Write("Ingresa un número entero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0) {
            Console.WriteLine("Es un número par.");
        } else {
            Console.WriteLine("Es un número impar.");
        }