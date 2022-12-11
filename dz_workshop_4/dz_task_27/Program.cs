/*
Задача 27:
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
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

int SumDigitsOfNumber(int number)
{
    string numberStr = Convert.ToString(number);
    int sum = 0;
    for (int i = 0; i < numberStr.Length; i++)
    {
        sum = sum + (int)Char.GetNumericValue(numberStr[i]);
    }
    return sum;
}

Console.WriteLine($"Сумма цифр введенного числа: {SumDigitsOfNumber(GetNumber("Введите число сумму цифр которого хотите получить: "))}");
