using System;

class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string[] str = Console.ReadLine().Split();
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(str[i]);
        }

        int max = nums[0];
        int min = nums[0];

        for(int i = 1; i < n; i++)
        {
            if(nums[i] > max)
            {
                max = nums[i];
            }
            else if(nums[i] < min)
            {
                min = nums[i];
            }
        }

        Console.WriteLine(min + " " + max);
    }
}