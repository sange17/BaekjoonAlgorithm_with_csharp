using System;

namespace baekjoon
{
  class Mathematics_24083
  {
    public void solve()
    {
      int A = Int32.Parse(Console.ReadLine());
      int B = Int32.Parse(Console.ReadLine());
      int result = (A + B) % 12;

      System.Console.WriteLine(result == 0 ? 12 : result);
    }
  }
}