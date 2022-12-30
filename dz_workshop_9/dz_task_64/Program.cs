/*
Задача 64: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumberFromConsole(string message)
{
    int result;
    Console.Write(message);
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Вы ввели не число.");
    }
    return result;
}

void PrintIsNtoOne(int n)
{
    if (n != 0)
    {
    Console.Write($"{n}, ");
    PrintIsNtoOne(n - 1);
    }
}

PrintIsNtoOne(GetNumberFromConsole("Веедите положительное число: "));