// Задача 2. Получить от пользователя 2 числа и проверить
// Является ли одно из них квадратом другого
Console.Clear();
Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine()!)!;
int sqrFirst = firstNumber * firstNumber;
int sqrSecond = secondNumber * secondNumber;
if (firstNumber == sqrSecond)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else if (secondNumber == sqrFirst)
{
    Console.WriteLine("Второе число является квадратом первого.");
}
else
{
    Console.WriteLine("Ни одно из чисел не является квадратом второго.");
}