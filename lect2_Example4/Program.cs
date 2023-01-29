int arraySize, minNum, maxNum, counter, index, find;
int[] array;

Console.Clear();
Console.Write("Введите размер массива, который нужно заполнить: ");
arraySize = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите минимальное число, которое будет в массиве: ");
minNum = int.Parse(Console.ReadLine()!)!;
Console.Write("Введите максимальное число, которое будет в массиве: ");
maxNum = int.Parse(Console.ReadLine()!)!;

array = FillArray(arraySize, minNum, maxNum);
counter = 0;

Console.Write("Введите число от " + minNum + " до " + maxNum + ", индекс которого вам нужно найти в массиве: ");
find = int.Parse(Console.ReadLine()!)!;

index = -1;
counter = 0;
while (counter < arraySize)
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
PrintArray(array);

int[] FillArray(int arraySize, int minNum, int maxNum)
{
    int counter = 0;
    int[] result;
    result = new int[arraySize];
    while (counter < arraySize)
    {
        result[counter] = new Random().Next(minNum, maxNum + 1);
        counter++;
    }
    return result;
}

void PrintArray(int[] array)
{
    Console.Write("Массив: {");
    int counter = 0;
    while (counter < array.Length - 1)
    {
        Console.Write(array[counter] + ", ");
        counter++;
    }
    Console.WriteLine(array[counter] + "}");
}