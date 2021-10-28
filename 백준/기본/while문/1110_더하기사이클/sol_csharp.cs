using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int n = int.Parse(Console.ReadLine());
    int first = n;
    int a; int b; int c;
    int idx = 0;

    a = n / 10;
    b = n % 10;
    c = a + b;
    n = (b * 10) + (c % 10);
    idx++;

    while(first != n)
    {
      a = n / 10;
      b = n % 10;
      c = a + b;
      n = (b * 10) + (c % 10);
      idx++;
    }

    Console.WriteLine(idx);
  }
}