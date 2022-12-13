//метод получения числа с консоли
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
int[] InitArray(int dimension)
{
    int[] array = new int [dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-9,10);
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

//метод нахождения суммы отрицательных
int GetNegativeSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            summ += array[i];
    }

    return summ;
}

//метод нахождения суммы положительных
int GetPositiveSumm(int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            summ += array[i];
    }

    return summ;
}

//первым возвращает положительную сумму, вторым - отрицательную
(int, int) GetSumms(int[] array)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            positiveSumm += array[i];
        else
            negativeSumm += array[i];
    }

    return (positiveSumm, negativeSumm);
}


int dimension = GetNumber("Введите размерность массива");
int[] array = InitArray(dimension);
PrintArray(array);
int negativeSumm = GetNegativeSumm(array);
int positiveSumm = GetPositiveSumm(array);

(int pos, int neg) = GetSumms(array);

Console.WriteLine($"Сумма положительных: {positiveSumm}, сумма отрицательных: {negativeSumm}");
Console.WriteLine($"Сумма положительных: {pos}, сумма отрицательных: {neg}");