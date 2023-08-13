using System;

namespace baekjoon
{
  class Bruteforce_06131
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());
      int count = 0;

      for(int i = 1; i < 500; i++)
      {
        for(int j = 1; j < 500; j++)
        {
          if((j * j) - (i * i) == N)
          {
            count++;
          }
        }
      }

      System.Console.WriteLine(count);
    }
  }
}