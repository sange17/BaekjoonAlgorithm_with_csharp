using System;

namespace baekjoon
{
  class Mathematics_15474
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int n = Int32.Parse(line.Split(" ")[0]);
      int a = Int32.Parse(line.Split(" ")[1]);
      int b = Int32.Parse(line.Split(" ")[2]);
      int c = Int32.Parse(line.Split(" ")[3]);
      int d = Int32.Parse(line.Split(" ")[4]);

      int ab = (n % a == 0 ? n / a : n / a + 1);
      int cd = (n % c == 0 ? n / c : n / c + 1);

      System.Console.WriteLine(Math.Min(ab * b, cd * d));
    }
  }
}
