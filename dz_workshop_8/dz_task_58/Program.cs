/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] productOfArrays(int[,] oneArray, int[,] twoArray)
{
    int[,] newArray = new int[oneArray.GetLength(0), twoArray.GetLength(1)];

    if (oneArray.GetLength(0) == twoArray.GetLength(1))
    {
        for (int i = 0; i < newArray.GetLength(0); i++)
        {
            for (int j = 0; j < newArray.GetLength(1); j++)
            {
                for (int k = 0; k < newArray.GetLength(0); k++)
                {
                    newArray[i, j] += oneArray[i, k] * twoArray[k, j];
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Массивы не могут быть перемноженны, "
                        + "так как количество строк первого массива не равно "
                        + "количеству столбцов второго массива.");
    }
    return newArray;
}

int[,] oneArray = { { 2, 4 }, { 3, 2 } };
int[,] twoArray = { { 3, 4 }, { 3, 3 } };

PrintTwoDimensionalArray(productOfArrays(oneArray, twoArray));