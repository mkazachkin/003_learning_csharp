// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Clear();
Console.Write ("Введите число от 100 до 999: ");
int userNumber = int.Parse(Console.ReadLine()!)!;
string result;
if ((userNumber >999) | (userNumber<100))
{
    Console.WriteLine("Введено неправильное число.");
} else
{
    Console.WriteLine("Последняя цифра введенного числа - " + userNumber %100%10+".");
}