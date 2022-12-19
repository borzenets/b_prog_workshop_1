/*
Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void PrintgArreyNumbers(int[] arrey)
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

string PluralNumberInRus(int number)
{
    if (number == 1 || number % 10 == 1 && number != 11) return "число";
    else if ((number != 12
            && number != 13
            && number != 14)
            && (number == 2
            || number == 3
            || number == 4
            || number % 10 == 2
            || number % 10 == 3
            || number % 10 == 4))
            return "числа";
    else return "чисел";
}

int[] ConvertStringToArrayNumbers(string stringNumbers, string separator)
{
    string[] stringNumbersArray = stringNumbers.Split(separator);
    int temp;
    int countInputErrors = 0;
    int[] newArray = new int[stringNumbersArray.Length];
    for (int i = 0; i < stringNumbersArray.Length; i++)
    {
        if(int.TryParse(stringNumbersArray[i].Trim(), out temp))
            newArray[i] = temp;
        else
            countInputErrors ++;
    }
    if (countInputErrors > 0) 
        Console.WriteLine($"Вы ввели не число {countInputErrors} раз(a), символы заменены на 0");
    return newArray;
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

Console.WriteLine("Введите числа через запятую: ");
string stringNumbers = Console.ReadLine() ?? "";
int[] arrayNumbers = ConvertStringToArrayNumbers(stringNumbers, ",");
int countPositiveNumbers = CountNumberPositiveItems(arrayNumbers);
Console.WriteLine($"Вы ввели: {countPositiveNumbers}"
                + $"{PluralNumberInRus(countPositiveNumbers)} больше 0.");
PrintgArreyNumbers(arrayNumbers);