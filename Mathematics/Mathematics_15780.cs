using System;

namespace baekjoon
{
  class Mathematics_15780
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int N = Int32.Parse(line.Split(' ')[0]);
      int K = Int32.Parse(line.Split(' ')[1]);
      int hole = 0;

      line = Console.ReadLine();
      for(int i = 0; i < K; i++)
      {
        hole = Int32.Parse(line.Split(' ')[i]);

        if(hole % 2 == 0)
        {
          N -= (hole / 2);
        }
        else
        {
          N -= (hole / 2) + 1;
        }
      }

      if(N > 0)
      {
        System.Console.WriteLine("NO");
      }
      else
      {
        System.Console.WriteLine("YES");
      }
    }
  }
}