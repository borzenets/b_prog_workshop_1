/*
Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
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

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некоректный ввод, введите число больше 0.");
        }
    }

    return result;
}

bool SearchItemInArray(int[] array, int searchItem)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == searchItem) return true;
    }
    return false;
}


int dimension = GetNumber("Введите размер массива: ");

int[] newArray = GetArrayWithNumbers(dimension, -8, 8);

int searchNumber = GetNumber("Введите искомое в массиве число: ");

PrintArrey(newArray);

if (SearchItemInArray(newArray, searchNumber))
    Console.WriteLine($"Элемент {searchNumber} есть в массиве.");
else
    Console.WriteLine($"Элемента {searchNumber} нет в массиве.");