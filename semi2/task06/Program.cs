int decNum = new Random().Next(10, 100);
int firstNum = decNum / 10;
int secondNum = decNum % 10;
Console.Clear();
Console.WriteLine("Случайное число: " + decNum);
if (firstNum > secondNum)
{
    Console.WriteLine($"Число в десятках {firstNum} больше чем число в единицах {secondNum}.");
}
else if (firstNum < secondNum)
{
    Console.WriteLine($"Число в единицах {secondNum} больше чем число в десятках {firstNum}.");
}
else
{
    Console.WriteLine($"Число в единицах и десятках одинаковое - {secondNum}.");
}