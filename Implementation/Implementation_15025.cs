using System;

namespace baekjoon
{
  class Implementation_15025
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int L = Int32.Parse(line.Split(' ')[0]);
      int R = Int32.Parse(line.Split(' ')[1]);

      if(L == 0 && R == 0)
      {
        Console.WriteLine("Not a moose");
      }
      else if(L == R)
      {
        Console.WriteLine("Even " + (L + R));
      }
      else if(L != R)
      {
        Console.WriteLine("Odd " + (Math.Max(L, R) * 2));
      }
    }
  }
}