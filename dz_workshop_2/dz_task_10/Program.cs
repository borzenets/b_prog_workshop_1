/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int GetRandomNumber(int a, int b)
{
    Random rnd = new Random();
    return rnd.Next(a, b);
}

int GetAverageDigit(int threeDigitNumber)
{
    return threeDigitNumber % 100 / 10;
}

int number = GetRandomNumber(100, 1000);
Console.WriteLine($"Трехзначное число: {number}");
Console.WriteLine($"Средняя цифра: {GetAverageDigit(number)}");