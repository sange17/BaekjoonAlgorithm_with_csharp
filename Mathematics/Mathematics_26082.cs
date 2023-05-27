using System;

namespace baekjoon
{
  class Mathematics_26082
  {
    public void solve()
    {
      String str = Console.ReadLine();

      int A = Convert.ToInt32(str.Split(' ')[0]);
      int B = Convert.ToInt32(str.Split(' ')[1]);
      int C = Convert.ToInt32(str.Split(' ')[2]);

      System.Console.WriteLine(B / A * 3 * C);
    }
  }
}