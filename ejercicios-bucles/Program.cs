// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* int opcion;

do {
    Console.WriteLine("Menú de opciones:");
    Console.WriteLine("1. Opción 1");
    Console.WriteLine("2. Opción 2");
    Console.WriteLine("3. Salir");
    Console.Write("Elige una opción: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion) {
        case 1:
            Console.WriteLine("Seleccionaste Opción 1.");
            break;
        case 2:
            Console.WriteLine("Seleccionaste Opción 2.");
            break;
        case 3:
            Console.WriteLine("¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
            break;
    }
} while (opcion != 3); */

/* string contraseña;
const int LongitudMinima = 8;

do {
    Console.Write("Ingresa una contraseña (al menos 8 caracteres): ");
    contraseña = Console.ReadLine();
} while (contraseña.Length < LongitudMinima);

Console.WriteLine("¡Contraseña válida ingresada!"); */

/* int numero;

do {
    Console.Write("Ingresa un número positivo mayor que cero: ");
    numero = Convert.ToInt32(Console.ReadLine());
} while (numero <= 0);

Console.WriteLine("¡Número válido ingresado!"); */


/* Console.Write("Ingresa un número entero: ");
int numero = Math.Abs(Convert.ToInt32(Console.ReadLine())); // Convertir a valor absoluto para evitar problemas con números negativos

int contadorDigitos = 0;

while (numero > 0) {
    numero /= 10;
    contadorDigitos++;
}

Console.WriteLine($"El número tiene {contadorDigitos} dígitos."); */

/* Console.Write("Ingresa un número entero positivo: ");
int numero = Convert.ToInt32(Console.ReadLine());

int contadorDivisores = 0;

int i = 1;
while (i <= numero) {
    if (numero % i == 0) {
        contadorDivisores++;
    }
    i++;
}

Console.WriteLine($"El número {numero} tiene {contadorDivisores} divisores."); */

/*  Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);

        int intentos = 0;
        int numeroUsuario;

        Console.WriteLine("Adivina el número entre 1 y 100.");

        while (true) {
            Console.Write("Ingresa tu intento: ");
            numeroUsuario = Convert.ToInt32(Console.ReadLine());
            intentos++;

            if (numeroUsuario == numeroAleatorio) {
                Console.WriteLine($"¡Adivinaste! El número era {numeroAleatorio}. ¡Lo lograste en {intentos} intentos!");
                break;
            } else if (numeroUsuario < numeroAleatorio) {
                Console.WriteLine("El número es mayor. Sigue intentando.");
            } else {
                Console.WriteLine("El número es menor. Sigue intentando.");
            }
        } */

/*         Console.Write("Ingresa una palabra: ");
        string palabra = Console.ReadLine();

        int contadorVocales = 0;
        for (int i = 0; i < palabra.Length; i++) {
            char caracter = char.ToLower(palabra[i]);
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u') {
                contadorVocales++;
            }
        }

        Console.WriteLine($"La palabra tiene {contadorVocales} vocales."); */

/*         Console.Write("Ingresa un número N para generar la secuencia de Fibonacci: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++) {
            Console.Write(a + " ");
            int temp = a;
            a = b;
            b = temp + b;
        } */

Console.WriteLine("hola este es mi primer prog, cual es tu nombre?");
string ? name = Console.ReadLine();
Console.WriteLine($"hola {name} esta es una buena forma de conocerte");