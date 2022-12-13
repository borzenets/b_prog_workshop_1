/*
Задача 32: Напишите программу замена элементов массива:
положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
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

int[] PositivToNegativeArreyItems(int[] arrey)
{

    int[] invertArrey = new int[arrey.Length];

    for (int i = 0; i < arrey.Length; i++)
    {
        invertArrey[i] = arrey[i] * -1;
    }
    return invertArrey;
}

int[] arrey = GetArrayWithNumbers(4, -10, 11);

PrintArrey(arrey);
Console.WriteLine();
PrintArrey(PositivToNegativeArreyItems(arrey));