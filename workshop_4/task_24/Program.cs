/*
Задача 24
Напишите программу,  которая принимает на вход число (А)
и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некоректный ввод, введите число больше 0.");
        }
    }

    return result;
}


int SumOfNumbersFrom1To (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

Console.Write($"Сумма чисел от 1 до введеного: {SumOfNumbersFrom1To(GetNumber("Введите число: "))} ");