/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
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

int[] InitArray(int dimension)
{
    int[] arr = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        arr[i] = rnd.Next(1,10);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }

    Console.WriteLine();
}

int[] Reverse(int[] arr)
{
    int[] result = new int[arr.Length];
    int count = 0;

    for (int i = arr.Length - 1; i >= 0; i--)
    {
        result[count] = arr[i];
        count++;
    }

    return result;
}


int dimension = GetNumber("Введите размерность");
int[] arr = InitArray(dimension);
PrintArray(arr);
int[] reversedArray = Reverse(arr);
PrintArray(reversedArray);


Array.Reverse(reversedArray);

PrintArray(reversedArray);