/*
Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является 
ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/
Console.WriteLine("Ввендите первое число: ");
string numberOneStr = Console.ReadLine() ?? "";
Console.WriteLine("Ввендите второе число: ");
string numberTwoStr = Console.ReadLine() ?? "";

int numberOne = Convert.ToInt32(numberOneStr);
int numberTwo = Convert.ToInt32(numberTwoStr);

if (numberOne == numberTwo * numberTwo)
{
    Console.WriteLine($"Певое число {numberOne} является квадратом второго числа {numberTwo}");
}
else
{
    Console.WriteLine($"Певое число {numberOne} не является квадратом второго числа {numberTwo}");
}