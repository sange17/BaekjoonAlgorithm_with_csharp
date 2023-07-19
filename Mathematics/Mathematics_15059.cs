using System;

namespace baekjoon
{
  class Mathematics_15059
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int ca = Int32.Parse(line.Split(' ')[0]);
      int ba = Int32.Parse(line.Split(' ')[1]);
      int pa = Int32.Parse(line.Split(' ')[2]);

      line = Console.ReadLine();

      int cr = Int32.Parse(line.Split(' ')[0]);
      int br = Int32.Parse(line.Split(' ')[1]);
      int pr = Int32.Parse(line.Split(' ')[2]);

      int c = ca >= cr ? 0 : cr - ca;
      int b = ba >= br ? 0 : br - ba;
      int p = pa >= pr ? 0 : pr - pa;

      int sum = c + b + p;

      System.Console.WriteLine(sum);
    }
  }
}