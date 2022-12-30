/*
Задача 66: Задайте значения M и N. Напишите программу,
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
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

int SumIsMtoN(int m, int n, int sum=0)
{
    if (m <= n)
    {
        sum += m;
        return SumIsMtoN(m +1, n, sum);
    }
    else
        return sum;
}

int sum = SumIsMtoN(GetNumberFromConsole("Введите М: "), GetNumberFromConsole("Введите N: "));
Console.WriteLine($"Сумма чисел от M до N равна: {sum}");