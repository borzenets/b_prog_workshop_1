/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

int  GetRandomNumber(int a, int b)
{
    Random rnd = new Random();
    int rndNumber = rnd.Next(a, b+1);
    return rndNumber;
}

int number = GetRandomNumber(100, 1000);

Console.WriteLine($"Рандомное число = {number}");

int firstNumber = number / 100;
int secondNumber = number % 10;

int rezult = firstNumber * 10 + secondNumber;

Console.WriteLine($"{number} -> {rezult}");