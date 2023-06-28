using System;

namespace baekjoon
{
  class Mathematics_26307
  {
    public void solve()
    {
      string str = Console.ReadLine();
      int hh = Int32.Parse(str.Split(' ')[0]);
      int mm = Int32.Parse(str.Split(' ')[1]);

      System.Console.WriteLine((hh * 60 + mm) - 540);

    }
  }
}