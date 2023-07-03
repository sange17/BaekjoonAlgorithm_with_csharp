using System;

namespace baekjoon
{
  class Greedy_15881
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());
      string str = Console.ReadLine();

      int count = 0;
      for(int i = 0; i < n - 3; i++)
      {
        if(str[i] == 'p' && str[i + 1] == 'P' && str[i + 2] == 'A' && str[i + 3] == 'p')
        {
          count++;
          i += 3;
        }
      }

      System.Console.WriteLine(count);
    }
  }
}