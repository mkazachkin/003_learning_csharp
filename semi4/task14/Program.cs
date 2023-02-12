// Задача 30: Напишите программу, которая выводит массив
// из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int[] arrayOne;
int[] arrayTwo;
int[] resultArray = new int[8];

Console.Clear();
arrayOne = GenerateArray();     //Генерируем массив 1
arrayTwo = GenerateArray();     //Генерируем массив 2
resultArray = SummArray(arrayOne, arrayTwo);
//Поэлементное сложение массива

PrintArray(arrayOne);           //Все в консоль
PrintArray(arrayTwo);
PrintArray(resultArray);

int[] GenerateArray()
{
    //Генерирует массив из 8 произвольных чисел 0 и 1
    int[] someArray = new int[8];
    for (int counter = 0; counter <= 7; counter++) someArray[counter] = new Random().Next(0, 2);
    return someArray;
}

void PrintArray(int[] someArray)
{
    //Выводит массив на печать в консоль
    Console.Write("[");
    for (int counter = 0; counter <= (someArray.Length - 2); counter++) Console.Write($"{someArray[counter]},");
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}

int[] SummArray(int[] someArr1, int[] someArr2)
{
    int[] resArr = new int[8];
    for (int counter = 0; counter <= 7; counter++) resArr[counter] = someArr1[counter] + someArr2[counter];
    return resArr;
}