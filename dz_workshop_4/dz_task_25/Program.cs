/*
Задача 25:
Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16
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

int[] numbers = new int[2];

for (int i = 0; i < 2; i++)
{
    numbers[i] = GetNumber($"Введите {i+1}-е число");
}

Console.WriteLine(Math.Pow(numbers[0], numbers[1]));