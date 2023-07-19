// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
        Console.Write("Ingresa la temperatura en grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = celsius * 9 / 5 + 32;
        double kelvin = celsius + 273.15;

        Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit}Â°F");
        Console.WriteLine($"Temperatura en Kelvin: {kelvin} K");