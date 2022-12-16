/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

string GetBinary(int number)
{
    string resultBinaryNumber = String.Empty;

    while (number > 0)
    {
        resultBinaryNumber += $"{number % 2}";
        number = number / 2;
    }
    
    return new string(resultBinaryNumber.Reverse().ToArray());
}

int number = GetNumber("Веедите десятичное число: ");
Console.WriteLine($"Число {number} в двоичной системе: {GetBinary(number)}");