/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов,
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/


int[] GetArrayWithNumbers(int numnumberOfElements, int minDigit, int maxDigit)
{
    Random rnd = new Random();
    int[] arrey = new int[numnumberOfElements];
    for (int i = 0; i < numnumberOfElements; i++)
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

PrintArrey(GetArrayWithNumbers(8, 0, 1));