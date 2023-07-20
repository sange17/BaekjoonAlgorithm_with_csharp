using System;

namespace baekjoon
{
  class Mathematics_08710
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int k = Int32.Parse(line.Split(' ')[0]);
      int w = Int32.Parse(line.Split(' ')[1]);
      int m = Int32.Parse(line.Split(' ')[2]);
      int count = 0;

      while(k < w)
      {

        k += m;
        count++;  
      }

      System.Console.WriteLine(count);
    }
  }
}