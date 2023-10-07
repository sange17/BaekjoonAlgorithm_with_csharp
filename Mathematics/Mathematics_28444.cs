using System;

namespace baekjoon
{
  class Mathematics_28444
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int H = Int32.Parse(line.Split(" ")[0]);
      int I = Int32.Parse(line.Split(" ")[1]);
      int A = Int32.Parse(line.Split(" ")[2]);
      int R = Int32.Parse(line.Split(" ")[3]);
      int C = Int32.Parse(line.Split(" ")[4]);

      System.Console.WriteLine((H*I) - (A*R*C));
    }
  }
}