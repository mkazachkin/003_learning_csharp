//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120

Console.Clear();
Console.Write("Введите число: ");
int userNumber = int.Parse(Console.ReadLine()!)!;
Console.WriteLine($"Произведение чисел от 1 до {userNumber} = {MultOneToNumber1(userNumber)}");

int MultOneToNumber1(int someNumber)
{
    int counter = 1;
    int mult = 1;
    while (counter <= someNumber)
    {
        mult *= counter;
        counter++;
    }
    return mult;
}