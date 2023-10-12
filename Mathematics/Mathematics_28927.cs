using System;

namespace baekjoon
{
  class Mathematics_28927
  {
    public void solve()
    {
      string? line = Console.ReadLine();

      if(line == null) return;

      int t1 = Int32.Parse(line.Split(" ")[0]);
      int e1 = Int32.Parse(line.Split(" ")[1]);
      int f1 = Int32.Parse(line.Split(" ")[2]);

      line = Console.ReadLine();

      if(line == null) return;

      int t2 = Int32.Parse(line.Split(" ")[0]);
      int e2 = Int32.Parse(line.Split(" ")[1]);
      int f2 = Int32.Parse(line.Split(" ")[2]);

      int minute1 = t1 * 3 + e1 * 20 + f1 * 120;
      int minute2 = t2 * 3 + e2 * 20 + f2 * 120;

      if(minute1 > minute2) System.Console.WriteLine("Max");
      else if(minute1 < minute2) System.Console.WriteLine("Mel");
      else System.Console.WriteLine("Draw");
    }
  }
}