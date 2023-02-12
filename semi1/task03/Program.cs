// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"
Console.Clear();
Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!)!;
int leftNumber;
int rightNumber;
if (userNumber > 0)
{
    leftNumber = userNumber * (-1);
    rightNumber = userNumber;
}
else
{
    leftNumber = userNumber;
    rightNumber = userNumber * (-1);
}
int counter = leftNumber;
while (counter < rightNumber)
{
    Console.Write(counter + ", ");
    counter++;
}
Console.WriteLine(counter);