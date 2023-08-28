using System;

namespace baekjoon
{
  class Mathematics_08760
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      string line = string.Empty;
      int a = 0;
      int b = 0;
      for(int i = 0; i < n; i++)
      {
        line = Console.ReadLine();

        a = Int32.Parse(line.Split(' ')[0]);
        b = Int32.Parse(line.Split(' ')[1]);

        System.Console.WriteLine(a * b / 2);
      }
    }
  }
}