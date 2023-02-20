//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса
//чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int m = Input("Введите m: ");
int n = Input("Введите n: ");

int[,] array = new int[m, n];

array = Generate2DArray(m, n);
Print2DArray(array);
Console.WriteLine();
Kvadrat(array);
Print2DArray(array);

int Input(string message0)
{
    Console.Write(message0);
    int a = int.Parse(Console.ReadLine()!)!;
    return a;
}

void Print2DArray(int[,] someArray)
{
    bool flag = true;
    for (int i = 0; i < someArray.GetLength(0); i++)
    {
        if (flag)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            flag = !flag;
        }
        else
        {
            Console.ResetColor();
            flag = !flag;
        }
        for (int j = 0; j < someArray.GetLength(1); j++)
        {

            Console.Write($"{someArray[i, j],4} ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
}

int[,] Generate2DArray(int m, int n)
{
    int[,] res = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            res[i, j] = new Random().Next(0, 10);
        }
    }
    return res;
}
void Kvadrat(int[,] someArray)
{
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                someArray[i, j] *= someArray[i, j];
            }
        }
    }
}