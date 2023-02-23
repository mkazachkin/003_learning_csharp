// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите начальное число:");
string first = Console.ReadLine()!;
Console.Write("Введите конечное число:");
string last = Console.ReadLine()!;
Console.WriteLine(NaturalNumbersString(first, last));

string NaturalNumbersString(string start, string end)
{
    if (start == end)
    {
        return start + ".";
    }
    else
    {
        return start + ", " + NaturalNumbersString(Convert.ToString(int.Parse(start) + 1), end);
    }
}