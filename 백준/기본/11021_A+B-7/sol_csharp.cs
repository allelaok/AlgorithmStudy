using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Program {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());
    StringBuilder sb = new StringBuilder();
    
    for(int i = 0; i < n; i++){
      string[] srt =  Console.ReadLine().Split(' ');
      int a = int.Parse(srt[0]);
      int b = int.Parse(srt[1]);
      
      sb.Append("Case #" + (i + 1) + ": " + (a + b) + "\n");
    }

    Console.WriteLine(sb.ToString());
  }
}