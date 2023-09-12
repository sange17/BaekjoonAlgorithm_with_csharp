using System;

namespace baekjoon
{
  class Implementation_24072
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int A = Int32.Parse(line.Split(" ")[0]);
      int B = Int32.Parse(line.Split(" ")[1]);
      int C = Int32.Parse(line.Split(" ")[2]);

      System.Console.WriteLine((A <= C && B > C) ? 1 : 0);
    }
  }
}