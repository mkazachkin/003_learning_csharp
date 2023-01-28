// Задача 3. Получить от пользователя число от 1 до 7 и вывести соответствующий ему день недели
Console.Clear();
Console.Write("Введите целое число от 1 до 7: ");
int userNumber = int.Parse(Console.ReadLine()!)!;
string dayOfWeek = "Вы ввели неправильное число.";
if (userNumber == 1)
{
    dayOfWeek = "Понедельник";
}
else if (userNumber == 2)
{
    dayOfWeek = "Вторник";
}
else if (userNumber == 3)
{
    dayOfWeek = "Среда";
}
else if (userNumber == 4)
{
    dayOfWeek = "Четверг";
}
else if (userNumber == 5)
{
    dayOfWeek = "Пятница";
}
else if (userNumber == 6)
{
    dayOfWeek = "Суббота";
}
else if (userNumber == 7)
{
    dayOfWeek = "Воскресенье";
}
Console.WriteLine(dayOfWeek);