// See https://aka.ms/new-console-template for more information
/* Console.Write("Hello, World!");
Console.Write("Ingrese la fila en la que se encuentra el caballo: ");
int fila = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese la columna en la que se encuentra el caballo: ");
string? columna = Console.ReadLine();

 // Tamaño del tablero de ajedrez (8x8)
        const int boardSize = 8;

        // Crear el tablero y llenarlo con ceros
        int[,] board = new int[boardSize, boardSize];

        // Pedir al usuario la posición del caballo (fila y columna)
        Console.WriteLine("Ingrese la posición del caballo en el formato (fila, columna), por ejemplo, 2, C:");

        int row = 0;
        int col = 0;
        bool validInput = false;

        do
        {
            string input = Console.ReadLine();

            if (IsValidInput(input, boardSize, out row, out col))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Coordenada inválida. Vuelva a intentarlo:");
            }

        } while (!validInput);

        // Convertir la columna de letras (A-H) a un índice de matriz (0-7)
        int colIndex = col - 'A';

        // Convertir la fila de números (1-8) a un índice de matriz (0-7)
        int rowIndex = boardSize - row;

        // Marcamos la posición inicial del caballo en el tablero con un 1
        board[rowIndex, colIndex] = 1;

        // Posiciones relativas a las que puede saltar el caballo (ocho posibles movimientos)
        int[] rowMoves = { -2, -2, -1, -1, 1, 1, 2, 2 };
        int[] colMoves = { -1, 1, -2, 2, -2, 2, -1, 1 };

        // Calcular las posiciones a las que puede acceder el caballo
        for (int i = 0; i < rowMoves.Length; i++)
        {
            int newRow = rowIndex + rowMoves[i];
            int newCol = colIndex + colMoves[i];

            // Verificar si la nueva posición es válida y si no ha sido visitada previamente
            if (IsValidPosition(newRow, newCol, boardSize))
            {
                // Marcar la posición a la que puede saltar el caballo
                board[newRow, newCol] = 2;
            }
        }

        // Mostrar el tablero con las posiciones accesibles por el caballo
        Console.WriteLine("\nTablero con las posiciones accesibles por el caballo:");
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if (board[i, j] == 0)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write(board[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    

    // Función para validar la entrada del usuario (fila o columna)
    static bool IsValidInput(string input, int boardSize, out int row, out char col)
    {
        row = 0;
        col = 'A';

        // Verificar que la entrada tenga al menos 3 caracteres (por ejemplo, "2, C")
        if (input.Length < 3)
        {
            return false;
        }

        // Extraer la fila y columna de la entrada del usuario
        if (int.TryParse(input.Split(',')[0], out row) && char.TryParse(input.Split(',')[1].Trim().ToUpper(), out col))
        {
            // Verificar si las coordenadas están dentro del rango válido
            if (row >= 1 && row <= boardSize && col >= 'A' && col <= 'H')
            {
                return true;
            }
        }

        return false;
    }

    // Función para verificar si una posición es válida en el tablero
    static bool IsValidPosition(int row, int col, int boardSize)
    {
        return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
    } */
using System;

class Program
{
    static void Main(string[] args)
    {
        // Tamaño del tablero de ajedrez (8x8)
        const int boardSize = 8;

        // Crear el tablero y llenarlo con ceros
        int[,] board = new int[boardSize, boardSize];

        // Pedir al usuario la posición del caballo (fila y columna)
        Console.WriteLine("Ingrese la posición del caballo en el formato (fila, columna), por ejemplo, 2, C:");

        int row = 0;
        int col = 0;
        bool validInput = false;

        do
        {
            string input = Console.ReadLine();

            if (IsValidInput(input, boardSize, out row, out col))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Coordenada inválida. Vuelva a intentarlo:");
            }

        } while (!validInput);

        // Convertir la columna de letras (A-H) a un índice de matriz (0-7)
        int colIndex = col - 'A';

        // Convertir la fila de números (1-8) a un índice de matriz (0-7)
        int rowIndex = boardSize - row;

        // Marcamos la posición inicial del caballo en el tablero con un 1
        board[rowIndex, colIndex] = 1;

        // Posiciones relativas a las que puede saltar el caballo (ocho posibles movimientos)
        int[] rowMoves = { -2, -2, -1, -1, 1, 1, 2, 2 };
        int[] colMoves = { -1, 1, -2, 2, -2, 2, -1, 1 };

        // Calcular las posiciones a las que puede acceder el caballo
        for (int i = 0; i < rowMoves.Length; i++)
        {
            int newRow = rowIndex + rowMoves[i];
            int newCol = colIndex + colMoves[i];

            // Verificar si la nueva posición es válida y si no ha sido visitada previamente
            if (IsValidPosition(newRow, newCol, boardSize))
            {
                // Marcar la posición a la que puede saltar el caballo
                board[newRow, newCol] = 2;
            }
        }

        // Mostrar el tablero con las posiciones accesibles por el caballo
        Console.WriteLine("\nTablero con las posiciones accesibles por el caballo:");
        for (int i = 0; i < boardSize; i++)
        {
            for (int j = 0; j < boardSize; j++)
            {
                if (board[i, j] == 0)
                {
                    Console.Write("- ");
                }
                else
                {
                    Console.Write(board[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }

    // Función para validar la entrada del usuario (fila o columna)
    static bool IsValidInput(string input, int boardSize, out int row, out int col)
    {
        row = 0;
        col = 0;

        // Verificar que la entrada tenga al menos 3 caracteres (por ejemplo, "2, C")
        if (input.Length < 3)
        {
            return false;
        }

        // Extraer la fila y columna de la entrada del usuario
        string[] coordinates = input.Split(',');

        if (coordinates.Length != 2)
        {
            return false;
        }

        if (int.TryParse(coordinates[0], out row) && char.TryParse(coordinates[1].Trim().ToUpper(), out char colChar))
        {
            if (row >= 1 && row <= boardSize && colChar >= 'A' && colChar <= 'H')
            {
                col = colChar;
                return true;
            }
        }

        return false;
    }

    // Función para verificar si una posición es válida en el tablero
    static bool IsValidPosition(int row, int col, int boardSize)
    {
        return row >= 0 && row < boardSize && col >= 0 && col < boardSize;
    }
}
