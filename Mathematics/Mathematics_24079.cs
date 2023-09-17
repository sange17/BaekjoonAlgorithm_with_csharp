using System;

namespace baekjoon
{
  class Mathematics_24079
  {
    public void solve()
    {
      int X = Int32.Parse(Console.ReadLine());
      int Y = Int32.Parse(Console.ReadLine());
      int Z = Int32.Parse(Console.ReadLine());

      System.Console.WriteLine(X + Y <= Z ? 1 : 0);
    }
  }
}