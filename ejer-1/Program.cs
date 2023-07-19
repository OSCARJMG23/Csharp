// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

        Console.WriteLine("Calculadora básica");
        Console.Write("Ingresa el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Suma: {num1 + num2}");
        Console.WriteLine($"Resta: {num1 - num2}");
        Console.WriteLine($"Multiplicación: {num1 * num2}");
        Console.WriteLine($"División: {num1 / num2}");