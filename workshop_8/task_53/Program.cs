/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
*/

int[,] GetArrayRandomItemsTwoDimension(int xSizeArray = 5,
                                        int ySizeArray = 5,
                                        int startRndNum = 0,
                                        int finishRndNum = 10)
{
    int[,] array = new int[xSizeArray, ySizeArray];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(startRndNum, finishRndNum);
        }
    }
    return array;
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

int[,] SwapFirstAndLastRows(int[,] array)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                newArray[0, j] = array[array.GetLength(0) - 1, j];
                newArray[array.GetLength(0) - 1, j] = array[0, j];
            }
        }
        else
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                newArray[i, k] = array[i, k];
            }
        }
    }
    return newArray;
}

int[,] array = GetArrayRandomItemsTwoDimension();
PrintTwoDimensionalArray(array);
Console.WriteLine();
PrintTwoDimensionalArray(SwapFirstAndLastRows(array));