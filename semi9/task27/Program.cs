// Задача 63: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

Console.Write("Введите N: ");
int userN = int.Parse(Console.ReadLine()!)!;

NaturalNumbers(userN);
Console.WriteLine();

void NaturalNumbers(int n, int start = 1)
{
    if (start <= n)
    {
        Console.Write($"{start}");
        if (start != n) Console.Write(", "); else Console.Write(".");
        NaturalNumbers(n, start + 1);
    }
}