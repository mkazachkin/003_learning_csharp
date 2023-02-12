// Задача 1 на семинаре.
// Написать программу, считающую квадрат числа
Console.Clear();
Console.Write("Введите целое число: ");
int userNumber = int.Parse(Console.ReadLine()!)!;
int result = userNumber * userNumber!;
Console.WriteLine("Квадрат числа = " + result);
