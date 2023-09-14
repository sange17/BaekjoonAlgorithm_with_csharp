using System;

namespace baekjoon
{
  class Mathematics_24075
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int A = Int32.Parse(line.Split(" ")[0]);
      int B = Int32.Parse(line.Split(" ")[1]);

      System.Console.WriteLine(Math.Max((A + B), (A - B)));
      System.Console.WriteLine(Math.Min((A + B), (A - B)));
    }
  }
}