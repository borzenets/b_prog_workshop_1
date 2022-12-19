/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void PrintStringArrey(string[] arrey)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length ; i++)
    {
        if (i == arrey.Length - 1)
            Console.Write(arrey[i]);
        else    
            Console.Write($"{arrey[i]}, ");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Введите числа через запятую: ");
string numbersString = Console.ReadLine();
string[] numbersArray = numbersString.Split(',');

PrintStringArrey(numbersArray);