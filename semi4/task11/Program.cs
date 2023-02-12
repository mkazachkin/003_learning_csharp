//Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int userNumber, sumResult;
string userInput;

Console.Clear();
Console.Write("Введите число: ");
userInput = Console.ReadLine()!;
userNumber = int.Parse(userInput);
sumResult = sumOneToNum(userNumber);
Console.WriteLine($"Сумма от одного до {userNumber} равна {sumResult}.");



int sumOneToNum(int someNumber)
{
    int counter = 1;
    int sum = 0;
    while (counter <= someNumber)
    {
        sum = sum + counter;
        counter++;
    }
    return sum;
}