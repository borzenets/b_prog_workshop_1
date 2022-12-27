/*
Задача 63: Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
            break;
        else
            Console.WriteLine("Вы ввели не чило.");
    }
    return result;
}

string PrintNumberTo(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    else
    {
        return PrintNumberTo(number - 1) + $", {number}";
    }
}

int number = GetNumber("Введите число: ");
Console.WriteLine(PrintNumberTo(number));