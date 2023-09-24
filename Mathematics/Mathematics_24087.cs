using System;

namespace baekjoon
{
  class Mathematics_24087
  {
    public void solve()
    {

      double S = Int32.Parse(Console.ReadLine());
      double A = Int32.Parse(Console.ReadLine());
      double B = Int32.Parse(Console.ReadLine());

      // 원하는 높이 S가 기본 높이 A보다 작거나 같다면
      if(S <= A)
      {
        // 기본 금액 250원
        System.Console.WriteLine(250);
      }
      // 그렇지 않을 때
      else
      {
        System.Console.WriteLine(250 + 100 * Math.Ceiling((S - A) / B));
      }
    }
  }
}