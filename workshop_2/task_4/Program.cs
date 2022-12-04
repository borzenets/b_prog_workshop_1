/*
Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно 7 и 23.

14 -> нет
46 -> нет
161 -> да
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "");

if (number % 27 == 0 && number % 3 == 0)
{
    Console.WriteLine($"Введеное число {number} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Введеное число {number} не кратно 7 и 23");
}