/*
Напишите программу, которая будет принимать на вход два числа и выводить,
является ли второе число кратным первому. Если число 2 не кратно числу 1,
то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

Console.WriteLine("Введите первое число: ");
string firstNumberStr = Console.ReadLine() ?? "";
int firstNumber = Convert.ToInt32(firstNumberStr);

Console.WriteLine("Введите второе число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "");



if (firstNumber % secondNumber == 0)
{
    Console.WriteLine($"Число {firstNumber} кратно числу {secondNumber}");
}
else
{
    int ost = secondNumber % firstNumber;
    Console.WriteLine($"Число {firstNumber} не кратно числу {secondNumber} " +
    $"остаток: {ost}");
}