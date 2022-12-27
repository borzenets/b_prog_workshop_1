/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

void  PrintNumbers(int startNum, int finNum)
{
    if ( startNum == finNum)
    {
        Console.Write(startNum);
    }
    else
    {
        Console.Write($"{startNum}, ");
        PrintNumbers(startNum +1, finNum);
    }
}

PrintNumbers (3, 8);