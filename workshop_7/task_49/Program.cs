/*
Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Вы ввели не чило.");
    }
    return result;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

int[,] SquareElementsWithEvenIndexes (int[,] matrix)
{
    int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
            {
                newMatrix[i, j] = matrix[i,j] * matrix[i,j];
            }
            else
            {
                newMatrix[i, j] = matrix[i, j];
            }
        }
 
    }
    return newMatrix;
}

int m = GetNumber("Введите (m) количество строк: ");
int n = GetNumber("Введите (n) количество столбцов: ");

int[,] matrix = InitMatrix(m, n);
PrintArray(matrix);
int[,] newMatrix = SquareElementsWithEvenIndexes(matrix);
Console.WriteLine();
PrintArray(newMatrix);