// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine()!)!;
if ((quarter > 4) || (quarter < 1))
{
    Console.WriteLine("Нет такой четверти. Не могу показать диапазон точек.");
}
else if (quarter == 1)
{
    Console.WriteLine("В I четверти x > 0 и y > 0.");
}
else if (quarter == 2)
{
    Console.WriteLine("Во II четверти x < 0 и y > 0.");
}
else if (quarter == 3)
{
    Console.WriteLine("В III четверти x < 0 и y < 0.");
}
else
{
    Console.WriteLine("В IV четверти x > 0 и y < 0");
}
