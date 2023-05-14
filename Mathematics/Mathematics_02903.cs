using System;

namespace baekjoon
{
  class Mathematics_02903
  {
    public void solve()
    {
      int n = Int16.Parse(Console.ReadLine());

      int width = 2;
      int[] dots = new int[15];
      for(int i = 0; i < 15; i++){

        width += (width - 1);
        dots[i] = width * width;
      }

      System.Console.WriteLine(dots[n - 1]);
    }
  }
}
