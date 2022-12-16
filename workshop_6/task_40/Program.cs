/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.

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

bool GetComhfreLengths(int sideA, int sideB, int sideC)
{
    return sideA < sideB + sideC && sideB < sideA + sideC && sideC < sideA + sideB;
}

int triangleSideA = GetNumber("Введите сторону А треугольника");
int triangleSideB = GetNumber("Введите сторону B треугольника");
int triangleSideC = GetNumber("Введите сторону C треугольника");

Console.WriteLine($"Треугольник существует или нет: {GetComhfreLengths(triangleSideA, triangleSideB, triangleSideC)}");