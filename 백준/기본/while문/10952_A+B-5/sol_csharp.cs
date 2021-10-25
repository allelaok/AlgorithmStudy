using System;
using System.Text;
using System.IO;

class Program {
  public static void Main (string[] args) {

    StringBuilder sb = new StringBuilder();
    
    while(true){
      string[] ab = Console.ReadLine().Split(' ');
      int a = int.Parse(ab[0]);
      int b = int.Parse(ab[1]);
      if(a == 0 && b == 0)  break;

      sb.Append((a + b) + "\n");

    }

    Console.WriteLine(sb.ToString());
  }
}