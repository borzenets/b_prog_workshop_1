/*
Задача 57: Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
*/

int GetNumberFromConsole(string message)
{
    int rezult = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out rezult))
            break;
        else
            Console.WriteLine("Вы ввели не число.");
    }
    return rezult;
}

int[,] GetArrayRandomItemsTwoDimension(int xSizeArray = 5,
                                        int ySizeArray = 5,
                                        int startRndNum = 0,
                                        int finishRndNum = 10)
{
    int[,] array = new int[xSizeArray, ySizeArray];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(startRndNum, finishRndNum);
        }
    }
    return array;
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"  {array[i, j]}  ");
        }
        Console.WriteLine();
    }
}

Dictionary<int, int> CountNumberIdenticalItems(int[,] array)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (dict.ContainsKey(array[i, j]))
            {
                dict[array[i, j]] += 1;
            }
            else
            {
                dict.Add(array[i, j], 1);
            }
        }
    }
    return dict;
}

void PrintDictionary(Dictionary<int, int> dict)
{
    foreach (var item in dict)
    {
        Console.WriteLine($"{item.Key} встречается в массиве {item.Value} раз.");
    }
}

int numberOfRows = GetNumberFromConsole("Введите число строк: ");
int numberOfCols = GetNumberFromConsole("Введите число стодицов: ");
int[,] array = GetArrayRandomItemsTwoDimension(numberOfRows, numberOfCols);
PrintTwoDimensionalArray(array);
Dictionary<int, int> countItems = CountNumberIdenticalItems(array);
PrintDictionary(countItems);