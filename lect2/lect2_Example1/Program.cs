int numMax(int num1, int num2, int num3)
{
    int resMax = num1;
    if (num2 > resMax)
    {
        resMax = num2;
    }
    if (num3 > resMax)
    {
        resMax = num3;
    }
    return resMax;
}

int a1 = 12;
int b1 = 13;
int c1 = 45;
int a2 = 34;
int b2 = 45;
int c2 = 12;
int a3 = 23;
int b3 = 78;
int c3 = 8;

int max1 = numMax(a1, a2, a3);
int max2 = numMax(b1, b2, b3);
int max3 = numMax(c1, c2, c3);
int maxFinal = numMax(max1, max2, max3);

Console.Clear();
Console.WriteLine("Итоговый результат: " + maxFinal);