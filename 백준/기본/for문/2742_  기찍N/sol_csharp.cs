using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        for (int i = n; i > 0; i--)
            sb.AppendLine(i.ToString());
        Console.WriteLine(sb);
    }
}