/*
Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементом массива.

[3 7 22 2 78] -> 76
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

int FindDifferenceMaxAndMinItem(int[] arrey)
{
    int max = arrey[0];
    int min = arrey[0];
    
    for (int i = 0; i < arrey.Length; i++)
    {
        if (max <  arrey[i])
            max = arrey[i];
        else if (min > arrey[i])
            min = arrey[i];
    }

    return max - min;
}

void PrintArrey(int[] arrey)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length ; i++)
    {
        if (i == arrey.Length - 1)
            Console.Write(arrey[i]);
        else    
            Console.Write($"{arrey[i]}, ");
    }
    Console.Write("]");
}

int[] newArrey = GetArrayWithNumbers(5, 1, 99);
PrintArrey(newArrey);
Console.WriteLine($" -> {FindDifferenceMaxAndMinItem(newArrey)} ");
