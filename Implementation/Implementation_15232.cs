using System;

namespace baekjoon
{
  class Implementation_15232
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());
      int m = Int32.Parse(Console.ReadLine());

      for(int i = 0; i < n; i++)
      {
        for(int j = 0; j < m; j++)
        {
          System.Console.Write("*");
        }
        System.Console.WriteLine();
      }
    }
  }
}