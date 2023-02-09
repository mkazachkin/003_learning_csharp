﻿// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

//-------
//Инициализация
int siz = 123;
int min = -200;
int max = 200;
int[] arr = GetArray(siz, min, max);

//-------
//Работаем
PrintArray(arr);
Console.Write("Количество элементов массива в диапазоне [10,99] составляет:");
Console.WriteLine($"{CountArrayInterval(arr, 10, 99)}.");

//-------
//Методы
int CountArrayInterval(int[] someArray, int down, int up)
{
    int counter = 0;
    for (int i = 0; i <= someArray.Length - 1; i++)
    {
        if ((someArray[i] >= down) && (someArray[i] <= up)) counter++;
    }
    return counter;
}
int[] GetArray(int length, int min = -1, int max = 1)
{
    //Генерирует массив целых чисел заданной длинны length
    //По-умолчанию числа в массиве от -1 до +1, меняется аргументами min и max
    int[] res = new int[length];
    for (int i = 0; i < length; i++) res[i] = new Random().Next(min, max + 1);
    return res;
}
void PrintArray(int[] someArray)
{
    //Выводит массив в консоль в виде [,,]
    Console.Write("[");
    for (int i = 0; i < someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.WriteLine($"{someArray[someArray.Length - 1]}]");
}