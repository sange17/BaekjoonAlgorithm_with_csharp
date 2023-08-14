using System;

namespace baekjoon
{
  class Mathematics_27328
  {
    public void solve()
    {
      int A = Int32.Parse(Console.ReadLine());
      int B = Int32.Parse(Console.ReadLine());

      if(A == B) System.Console.WriteLine(0);
      else if(A > B) System.Console.WriteLine(1);
      else System.Console.WriteLine(-1);
    }
  }
}