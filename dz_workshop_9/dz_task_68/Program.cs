/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumberFromConsole(string message)
{
    int result;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
            break;
        else
            Console.WriteLine("Вы ввели не число, или отрицательное число.");
    }
    return result;
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    else if (m > 0 && n > 0)
        return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
    else
        return n + 1;
}

int resultAckerman = AckermanFunction(  
                    GetNumberFromConsole("Введите положительное число M "),
                    GetNumberFromConsole("Введите положительное число N "));
Console.WriteLine($"A(m,n) = {resultAckerman}");