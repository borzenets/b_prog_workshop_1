/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

int GetNumber(string message)
{
    int result;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

Console.WriteLine("Расчет точки пересечения двух прямых, " + 
                  "заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;");

int b1 = GetNumber("Введите значение 'b1': ");
int k1 = GetNumber("Введите значение 'k1': ");
int b2 = GetNumber("Введите значение 'b2': ");
int k2 = GetNumber("Введите значение 'k2': ");

if (k1 == k2 && b1 == b2) Console.WriteLine("Ответ: прямые совпадают");
else if (k1 == k2) Console.WriteLine("Ответ: прямые паралельны");
else
{
    double x = (b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"Ответ: точка пересечения заданных прямых: (x = {x}; y = {y})");
}