using System;

namespace baekjoon
{
  class Mathematics_14924
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int S = Int32.Parse(line.Split(' ')[0]);
      int T = Int32.Parse(line.Split(' ')[1]);
      int D = Int32.Parse(line.Split(' ')[2]);

      System.Console.WriteLine(D / (S * 2) * T);
    }
  }
}