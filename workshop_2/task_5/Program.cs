/*
Напишите программу, которая принимает на вход два числа и проверяет,
является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/

int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

string ItIsSquare(int oneNumber, int twoNumber)
{
    if (oneNumber * oneNumber == twoNumber || twoNumber * twoNumber == oneNumber)
        return "Yes";
    else
        return "No";
}


int oneNumber = GetNumberFromConsole("Введите первое число: ");
int twoNumber = GetNumberFromConsole("Введите второе число: ");

Console.WriteLine(ItIsSquare(oneNumber, twoNumber));