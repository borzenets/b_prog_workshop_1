/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
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

int CountNumberPositiveItems (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count ++;
    }

    return count;
}

int[] GetArrayFromConsole()
{
    int numberOfElements = GetNumber("Какое количество чисел хотите ввести: ");

    int[] array = new int[numberOfElements];

    for (int i = 0; i < numberOfElements; i++)
    {
        array[i] = GetNumber($"Веедите {i + 1}-е число: ");
    }

    return array;
}

void PrintArrey(int[] arrey)
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

int[] newArray = GetArrayFromConsole();
PrintArrey(newArray);
Console.WriteLine();
Console.WriteLine($"Вы ввели: {CountNumberPositiveItems(newArray)} чисел больше 0.");
Console.WriteLine();