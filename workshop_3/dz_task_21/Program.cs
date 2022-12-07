/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
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

double getDistanceBetweenPoints(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
}

double x_1 = GetNumber("Введите значение x первой точки: ");
double y_1 = GetNumber("Введите значение y первой точки: ");
double z_1 = GetNumber("Введите значение z первой точки: ");

double x_2 = GetNumber("Введите значение x второй точки: ");
double y_2 = GetNumber("Введите значение y второй точки: ");
double z_2 = GetNumber("Введите значение z второй точки: ");

Console.WriteLine($"Растояние между точками {getDistanceBetweenPoints(x_1, y_1, z_1, x_2, y_2, z_2)}");