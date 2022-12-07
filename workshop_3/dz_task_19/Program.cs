/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 9999 && result < 100000)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите корректное число");
        }
    }
    return result;
}

bool ItPalindrome(int num)
{
    int oneDigit = num / 10000;
    int twoDigit = num / 1000 % 10;
    int fourDigit = num % 100 / 10;
    int fiveDigit = num % 10;
    Console.WriteLine($"{oneDigit}, {twoDigit}, {fourDigit}, {fiveDigit}");

    if (oneDigit == fiveDigit && twoDigit == fourDigit)
    {
        return true;
    }
    else
    {
        return false;
    }

}

int number = GetNumber("Введите пятизначное число: ");

if (ItPalindrome(number))
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}