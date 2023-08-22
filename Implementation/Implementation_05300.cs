using System;

namespace baekjoon
{
  class Implementation_05300
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      for(int i = 1; i <= n; i++)
      {
        System.Console.Write(i + " ");
        if(i % 6 == 0 || i == n) System.Console.Write("Go! ");
      }
    }
  }
}