using System;

namespace baekjoon
{
  class Mathematics_10707
  {
    public void solve()
    {
      int A = Int16.Parse(Console.ReadLine());
      int B = Int16.Parse(Console.ReadLine());
      int C = Int16.Parse(Console.ReadLine());
      int D = Int16.Parse(Console.ReadLine());
      int P = Int16.Parse(Console.ReadLine());

      int X = P * A;

      int Y = 0;
      if(P > C) {

        Y = B + (P - C) * D;
      }else{

        Y = B;
      }

      System.Console.WriteLine(Math.Min(X, Y));
    }
  }
}