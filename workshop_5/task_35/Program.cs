/*
Задача 35: Задайте одномерный массив из 123 случайных чисел.
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 

Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/


int[] GetArrayWithNumbers(int numberOfElements, int minDigit, int maxDigit)
{
    Random rnd = new Random();
    int[] arrey = new int[numberOfElements];
    for (int i = 0; i < numberOfElements; i++)
    {
        arrey[i] = rnd.Next(minDigit, maxDigit + 1);
    }
    return arrey;
}

void PrintArrey(int[] arrey)
{
    Console.Write("[");
    for (int i = 0; i < arrey.Length ; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
    Console.Write("]");
    Console.WriteLine();
} 

int CountItemsIiDiapason(int[] array, int begDiapason, int afterDiapason)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= begDiapason && array[i] <= afterDiapason)
        count ++;
    }

    return count;
}

int[] newArray = GetArrayWithNumbers(123, -10, 200);

PrintArrey(newArray);

int countItemsInArray = CountItemsIiDiapason(newArray, 10, 99);

Console.WriteLine($"В массиве присутствует {countItemsInArray} в диапалоне от 10 до 99");





/*

РЕШЕНИЕ С СЕМИНАРА, ВЫШЕ МОЕ РЕШЕНИЕ.

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число.");
        }
    }

    return result;
}

//метод инициализации массива

int[] InitArray(int dimention)
{
    int[] array = new int [dimention];
    Random rnd = new Random();

    for (int i = 0; i < dimention; i++)
    {
        array[i] = rnd.Next(-9,200);
    }

    return array;
}

//метод печати массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// метод подсчёта количества элементов, удовлетворяющих условию

int CountNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
        {
            count ++;
        }
    }
    return count;
}

int dim = GetNumber ("Введите размерность массива");
int [] array = InitArray(dim);
PrintArray(array);
Console.WriteLine($"Количество элементов, находящихся в промежутке от 10 до 99 составляет {CountNumbers(array)}");
*/