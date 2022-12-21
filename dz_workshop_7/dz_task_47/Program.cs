/*
Задача 47. Задайте двумерный массив размером m×n,
заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumberFromConsole(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Вы ввели не число.");
    }
    return result;
}

double[,] InitDoobleMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(-10 + rnd.NextDouble() * 20, 1);
        }
    }
    return matrix;
}

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите строк (m): ");
int n = GetNumberFromConsole("Введите столбцов (n): ");

double[,] matrix = InitDoobleMatrix(m, n);
PrintArray(matrix);