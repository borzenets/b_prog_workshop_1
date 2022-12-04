/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите номер дня недели (число): ");
int dayOfWeekNumber = int.Parse(Console.ReadLine() ?? "");
if (dayOfWeekNumber > 0 && dayOfWeekNumber < 8)
{
    if (dayOfWeekNumber == 6 || dayOfWeekNumber == 7)
        Console.WriteLine($"{dayOfWeekNumber}-й день недели это выходной");
    else
        Console.WriteLine($"{dayOfWeekNumber}-й день недели это не выходной");
}
else
{
    Console.WriteLine($"{dayOfWeekNumber} - такого номера дня недели не существует");
}