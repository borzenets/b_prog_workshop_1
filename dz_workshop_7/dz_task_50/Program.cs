/*
Задача 50. Напишите программу,
которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

int GetNumberFromConsole(string message)
{
    int result;
    Console.Write(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Вы ввели не число.");
    }
    return result;
}

int[,] InitRandomArray2D(int initRandomValue = 0, int finRandomValue = 10)
{
    Random rnd = new Random();
    int[,] matrix = new int[rnd.Next(3, 13), rnd.Next(3, 13)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(initRandomValue, finRandomValue);
        }
    }
    return matrix;
}

void PrintArray2D(int[,] matrix)
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

string SearchItemInArrey2D(int[,] arrey, int x, int y)
{
    if (x >= arrey.GetLength(0) || y >= arrey.GetLength(1))
    {
        return $"X:{x}, Y:{y} - Tакого элемента в массиве нет";
    }
    else
        return $"{arrey[x, y]} ";
}


int[,] matrix = InitRandomArray2D();
int x = GetNumberFromConsole("Введите кординату X: ");
int y = GetNumberFromConsole("Введите кординату Y: ");
Console.WriteLine($"Значение элемента: {SearchItemInArrey2D(matrix, x, y)} \n");
PrintArray2D(matrix);