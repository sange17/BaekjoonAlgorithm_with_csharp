using System;

namespace baekjoon
{
  class Mathematics_08558
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      int result = 1;
      for(int i = 1; i <= n; i++)
      {
        if(i >= 5)
        {
          result = 0;
          break;
        }

        result *= i % 10;
      }

      System.Console.WriteLine(result % 10);
    }
  }
}