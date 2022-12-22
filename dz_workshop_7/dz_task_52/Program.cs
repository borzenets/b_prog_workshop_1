/*
Задача 52. Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintArrey(double[] arrey)
{
    for (int i = 0; i < arrey.Length ; i++)
    {
            Console.Write($"{arrey[i]}; ");
    }
}

double[] calcArithmeticMeanInColumn(int[,] array)
{
    double[] arithmeticMeanInColumn = new double[array.GetLength(0)];

    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
           arithmeticMeanInColumn[j] = arithmeticMeanInColumn[j] + array[i, j];
        }
        arithmeticMeanInColumn[j] = arithmeticMeanInColumn[j] / array.GetLength(0);
    }

    return arithmeticMeanInColumn;
}

int[,] intTwoDimensionalArray = GetArrayRandomItemsTwoDimension();
PrintTwoDimensionalArray(intTwoDimensionalArray);
Console.WriteLine();
PrintArrey(calcArithmeticMeanInColumn(intTwoDimensionalArray));