using System;

namespace baekjoon
{
  class Mathematics_27324
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());

      if(N / 10 == N % 10) System.Console.WriteLine(1);
      else System.Console.WriteLine(0);
    }
  }
}