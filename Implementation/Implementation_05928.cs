using System;

namespace baekjoon
{
  class Implementation_05928
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int startTime = 11*24*60 + 11*60 + 11;

      int D = Int32.Parse(line.Split(' ')[0]);
      int H = Int32.Parse(line.Split(' ')[1]);
      int M = Int32.Parse(line.Split(' ')[2]);

      int endTime = D*24*60 + H*60 + M;

      if(startTime > endTime) System.Console.WriteLine(-1);
      else
      {
        System.Console.WriteLine(endTime - startTime);
      }
    }
  }
}