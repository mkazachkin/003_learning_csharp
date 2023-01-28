Console.Clear();
int x1 = 40, y1 = 1,
    x2 = 1, y2 = 81,
    x3 = 81, y3 = 81;
Console.SetCursorPosition(x1, y1);
Console.Write("*");

Console.SetCursorPosition(x2, y2);
Console.Write("*");

Console.SetCursorPosition(x3, y3);
Console.Write("*");

int x = x1, y = y1;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // 0 1 2
    if (what == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    if (what == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
    if (what == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.Write("*");
    count++;
}
Console.SetCursorPosition(1, 42);
Console.WriteLine("");