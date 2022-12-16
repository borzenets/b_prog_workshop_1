/* 
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
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

void PrintFibonachi(int number)
{
    string result = String.Empty;
    
    if (number == 1)
    {
        Console.WriteLine("0");
    }
    else if (number == 2)
    {
        Console.WriteLine("0 1");
    }
    else
    {
        result = "0 1";
        int a = 0;
        int b = 1;
        int temp;
        for (int i = 3; i <= number; i++)
        {
            result += $" {(a + b)}";
            temp = a + b;
            a = b;
            b = temp;
        }
    }

    Console.WriteLine(result);

}


int number = GetNumber("Введите сколько чисел фибоначи по порядку хотите вывести: ");
PrintFibonachi(number);