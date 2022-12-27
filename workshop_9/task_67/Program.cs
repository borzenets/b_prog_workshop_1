/*
Задача 67: Напишите программу,
которая будет принимать на вход число и возвращать сумму его цифр.
Использовать рекурсию.

453 -> 12
45 -> 9
*/

int GetDigitSum(int number, int sum=0)
{
    if (number % 10 != 0)
    {
        sum = sum + number % 10;
        return GetDigitSum(number / 10, sum);
    }
    else
    {
        return sum;
    }
}

Console.WriteLine(GetDigitSum(555));
