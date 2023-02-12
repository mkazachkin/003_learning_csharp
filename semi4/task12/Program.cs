// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
//78 -> 2
// 89126 -> 5

Console.Clear();
Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!)!;
Console.WriteLine($"{CountDigits(userNumber)}");

int CountDigits(int someNumber)
{
    int count = 0;
    while (someNumber > 0)
    {
        someNumber = someNumber / 10;
        count++;
    }
    return count;
}