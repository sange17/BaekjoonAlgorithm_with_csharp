using System;

namespace baekjoon
{
  class Mathematics_26545
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      int sum = 0;
      for(int i = 0; i < n; i++)
      {
        sum += Int32.Parse(Console.ReadLine());
      }

      System.Console.WriteLine(sum);
    }
  }
}