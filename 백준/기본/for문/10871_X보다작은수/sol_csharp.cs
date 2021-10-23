using System;
using System.Text;
using System.IO;

class Program {
  public static void Main (string[] args) {
    string[] nx = Console.ReadLine().Split(' ');
    int n = int.Parse(nx[0]);
    int x = int.Parse(nx[1]);

    string[] StrA = Console.ReadLine().Split(' ');
    StringBuilder sb = new StringBuilder();

    for(int i = 0; i < n; i++){
      if(int.Parse(StrA[i]) < x){
        sb.Append(StrA[i] + " ");
      }
    }

    Console.WriteLine(sb.ToString());
  }
}