//Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21
Console.Clear();

Console.Write("Введите координату X1: ");
long x1 = long.Parse(Console.ReadLine()!)!;
Console.Write("Введите координату Y1: ");
long y1 = long.Parse(Console.ReadLine()!)!;
Console.Write("Введите координату X2: ");
long x2 = long.Parse(Console.ReadLine()!)!;
Console.Write("Введите координату Y2: ");
long y2 = long.Parse(Console.ReadLine()!)!;

long length = calcLength(x1, x2);
long width = calcLength(y1, y2);

double result = Math.Round(Math.Sqrt(length * length + width * width), 2);
Console.WriteLine($"Расстояние между точками {result}");
result = Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)), 2);
Console.WriteLine($"Расстояние между точками {result}");

long calcLength(long coord1, long coord2)
{
    long res;
    if ((coord1 >= 0) && (coord2 >= 0))
    {
        if (coord1 > coord2)
        {
            res = coord1 - coord2;
        }
        else
        {
            res = coord2 - coord1;
        }
    }
    else if ((coord1 < 0) && (coord2 < 0))
    {
        if (coord1 > coord2)
        {
            res = coord2 - coord1;
        }
        else
        {
            res = coord1 - coord2;
        }
    }
    else
    {
        if (coord1 > coord2)
        {
            res = coord1 - coord2;
        }
        else
        {
            res = coord2 - coord1;
        }
    }
    return res;
}