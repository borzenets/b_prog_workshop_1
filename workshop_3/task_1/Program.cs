/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выведет номер четверти, в которой находится эта точка.
            |
            |
      2     |       1
            |
-------------------------
            |
            |
     3      |       4
            |
*/

// Получение числа с консоли
int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while(!isCorrect)
    {
        Console.WriteLine(message);

        /*
        2 Типа данных: reference types(ссылочные) и value types(значимые)
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types
        https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types
        */

        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число или 0. Введите корректное число");
        }
    }
    return result;
}

int GetQuarter(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    if(x < 0 && y > 0)
        return 2;
    if(x < 0 && y < 0)
        return 3;    
    
    return 4;
}

int x = GetNumber("Введите x: ");
int y = GetNumber("Введите y: ");

int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами {x}, {y} лежит в {quarter} четверти");