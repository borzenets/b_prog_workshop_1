Console.WriteLine("Введите число от 1 до 7: ");
string dey = Console.ReadLine() ?? "";

if (dey == "1")
{
    Console.WriteLine("Понедельник");
}
else if (dey == "2")
{
    Console.WriteLine("Вторник");
}
else if (dey == "3")
{
    Console.WriteLine("Среда");
}
else if (dey == "4")
{
    Console.WriteLine("Четверг");
}
else if (dey == "5")
{
    Console.WriteLine("Пятница");
}
else if (dey == "6")
{
    Console.WriteLine("Суббота");
}
else if (dey == "7")
{
    Console.WriteLine("Воскресенье");
}
else
{
     Console.WriteLine("Вы ввели не коректное число");
}