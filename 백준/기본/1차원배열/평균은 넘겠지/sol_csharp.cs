using System;

class Program
{
  public static void Main(string[] args)
  {
    int line = int.Parse(Console.ReadLine());

    for (int j = 0; j < line; j++)
    {
      string[] str = Console.ReadLine().Split(' ');
      int n = int.Parse(str[0]);

      int[] score = new int[n];
      for (int i = 0; i < n; i++)
      {
        score[i] = int.Parse(str[i + 1]);
      }

      int sum = 0;
      for (int i = 0; i < n; i++)
      {
        sum += score[i];
      }

      float avg = (float)sum / n;
      int cnt = 0;

      for (int i = 0; i < n; i++)
      {
        if (score[i] > avg)
        {
          cnt++;
        }
      }

      float result = (float)cnt / n;
      Console.WriteLine("{0:#0.000%}", result);
    }
  }
}