/*
Задача 29:
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int[] GetArrayWithNumbers(int numberOfElements, int minDigit, int maxDigit)
{
    Random rnd = new Random();
    int[] arrey = new int[numberOfElements];
    for (int i = 0; i < numberOfElements; i++)
    {
        arrey[i] = rnd.Next(minDigit, maxDigit + 1);
    }
    return arrey;
}


void PrintArrey(int[] arrey)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length ; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write("]");
} 

PrintArrey(GetArrayWithNumbers(8, 1, 12));