int[] array = { 1, 12, 31, 4, 15, 16, 17, 16, 18 };
int n = array.Length;

Console.Clear();
Console.Write("Введите число, индекс которого вам нужно найти в массиве: ");
int find = int.Parse(Console.ReadLine()!)!;

int index = -1;
int counter = 0;
while (counter < n)
{
    if (array[counter] == find)
    {
        index = counter;
        break;
    }
    counter++;
}
if (index < 0)
{
    Console.WriteLine("Заданное число в массиве отсутствует.");
}
else
{
    Console.WriteLine("Индекс числа в массиве: " + index + " (начиная с 0).");
}