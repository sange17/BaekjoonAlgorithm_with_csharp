using System;

namespace baekjoon
{
  class Mathematics_14470
  {
    public void solve()
    {
      int A = Int32.Parse(Console.ReadLine());
      int B = Int32.Parse(Console.ReadLine());
      int C = Int32.Parse(Console.ReadLine());
      int D = Int32.Parse(Console.ReadLine());
      int E = Int32.Parse(Console.ReadLine());

      if(A < 0 && B < 0)
      {
        System.Console.WriteLine(Math.Abs(A - B) * C);
      }
      else if(A < 0 && B == 0)
      {
        System.Console.WriteLine(Math.Abs(A - B) * C + D);
      }
      else if(A < 0 && B > 0)
      {
        System.Console.WriteLine(Math.Abs(A - 0) * C + D + Math.Abs(0 - B) * E);
      }
      else if(A == 0 && B > 0)
      {
        System.Console.WriteLine(D + Math.Abs(0 - B));
      }
      else if(A > 0 && B > 0)
      {
        System.Console.WriteLine(Math.Abs(A - B) * E);
      }
    }
  }
}