// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
        Console.Write("Ingresa un año: ");
        int year = Convert.ToInt32(Console.ReadLine());

        bool esBisiesto = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        if (esBisiesto) {
            Console.WriteLine("Es un año bisiesto.");
        } else {
            Console.WriteLine("No es un año bisiesto.");
        }