using System;
using System.Text;
using System.IO;

class Program {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();

    for(int i = 0; i < n; i++){
      string[] ab = Console.ReadLine().Split(' ');
      int a = int.Parse(ab[0]);
      int b = int.Parse(ab[1]);
      
      sb.Append("Case #" + (i + 1) + ": " + a + " + " + b + " = " + (a + b) +"\n");
    }

    Console.WriteLine(sb.ToString());
  }
}