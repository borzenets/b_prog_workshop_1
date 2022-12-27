/*
Задача 69: Напишите программу,
которая на вход принимает два числа A и B,
и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int RaiseNumberToDegree(int number, int degree)
{
    if (degree == 1)
    {
        return number;
    }
    else
    {
       return number * RaiseNumberToDegree(number, degree - 1);
    }
}

Console.WriteLine((RaiseNumberToDegree(3, 5)));