/*
Напишите программу, которая выводит случайное число из отрезка [10, 99]
и показывает наибольшую цифру числа.

Например:
78 -> 8
12-> 2
85 -> 8
*/

// Рандомное число от 'a' до 'b'
int GetRadomNumber(int a, int b)
{
    Random rnd = new Random();

    int rezult = rnd.Next(a, b+1);

    return rezult;
}
// Получает наибольшую цифру числа number
int GetMaxDigitOfNumber(int number)
{
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;

}

int number = GetRadomNumber(10, 99);

Console.WriteLine($"Рандомное число = {number}");

int maxDigitOfNumber = GetMaxDigitOfNumber(number);

Console.WriteLine($"Наибольшая цифра числа {number} = {maxDigitOfNumber}");