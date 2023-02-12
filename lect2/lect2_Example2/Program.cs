int numMax(int[] nums)
{
    int resMax = nums[0];
    int counter = 1;
    while (counter < nums.Length)
    {
        if (nums[counter] > resMax)
        {
            resMax = nums[counter];
        }
        counter++;
    }
    return resMax;
}
int[] numArray = { 12, 13, 45, 34, 45, 12, 23, 78, 8 };

Console.Clear();
Console.WriteLine("Итоговый результат: " + numMax(numArray));