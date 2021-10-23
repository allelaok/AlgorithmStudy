using System;

class Program {
  public static void Main (string[] args) {
    int n = int.Parse(Console.ReadLine());

    for(int i = 1; i <= n; i++){
      for(int j = 0; j < i; j++){
        Console.Write("*");
      }
      Console.Write("\n");
    }
  }
}