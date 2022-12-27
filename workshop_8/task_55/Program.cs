/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это невозможно,
программа должна вывести сообщение для пользователя.
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

int[,] TransposeArray(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[j, i] = array[i, j];
        }
    }
    return newArray;
}

int[,] array = GetArrayRandomItemsTwoDimension(6);
PrintTwoDimensionalArray(array);
Console.WriteLine();
PrintTwoDimensionalArray(TransposeArray(array));