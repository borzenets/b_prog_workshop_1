/*
Задача 4: Напишите программу, которая принимает на вход три числа
и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число: ");
string numberOneStr = Console.ReadLine() ?? "";
int numberOne = Convert.ToInt32(numberOneStr);

Console.WriteLine("Введите второе число: ");
string numberTwoStr = Console.ReadLine() ?? "";
int numberTwo = Convert.ToInt32(numberTwoStr);

Console.WriteLine("Введите третье число: ");
string numberThreeStr = Console.ReadLine() ?? "";
int numberThree = Convert.ToInt32(numberThreeStr);

int numberMax = numberOne;

if(numberMax < numberTwo)
{
    numberMax = numberTwo;
}
if(numberMax < numberThree)
{
    numberMax = numberThree;
}

Console.WriteLine($"{numberOne}, {numberTwo}, {numberThree} -> Максимальное: {numberMax}");