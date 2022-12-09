/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите число");
        }
    }

    return result;
}

void PrintDigitCount(int number)
{
    int count = 0;
    while (number >= 1)
    {
        count++;
        number = number / 10;
    }
    Console.WriteLine($"Количество цифор в числе равно {count}");
}

PrintDigitCount(GetNumber("Введите число: "));