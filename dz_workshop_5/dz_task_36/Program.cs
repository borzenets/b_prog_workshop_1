/*
Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

int SumNumbersEvenPositions(int[] arrey)
{
    int sum = 0;
    for (int i = 0; i < arrey.Length; i++)
    {
        if (i % 2 != 0) sum = sum + arrey[i];
    }
    return sum;
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

int[] newArrey = GetArrayWithNumbers(4, 1, 50);
PrintArrey(newArrey);
Console.WriteLine($" -> {SumNumbersEvenPositions(newArrey)} ");
