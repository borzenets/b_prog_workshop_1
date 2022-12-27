/*
Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2
2 2 6
3 4 7
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

(int, int) FindIndexMinItem(int[,] array)
{
    int rowIndexMinItem = 0;
    int colIndexMinItem = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[rowIndexMinItem, colIndexMinItem] > array[i, j])
            {
                rowIndexMinItem = i;
                colIndexMinItem = j;
            }
        }
    }
    return (rowIndexMinItem, colIndexMinItem);
}

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

int[,] RemoveRowColArray(int[,] array, int rowIndex, int colIndex)
{
    int countRowNewArray = 0;
    int countColNewArray = 0;
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != rowIndex)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != colIndex)
                {
                    newArray[countRowNewArray, countColNewArray] = array[i, j];
                    countColNewArray += 1;
                }
            }
            countRowNewArray += 1;
            countColNewArray = 0;
        }
    }
    return newArray;
}

int[,] array = GetArrayRandomItemsTwoDimension();
PrintTwoDimensionalArray(array);
(int minRow, int minCol) = FindIndexMinItem(array);
Console.WriteLine($"Row min item : {minRow}, Col min item: {minCol}. \n");
int[,] croppedArray = RemoveRowColArray(array, minRow, minCol);
PrintTwoDimensionalArray(croppedArray);