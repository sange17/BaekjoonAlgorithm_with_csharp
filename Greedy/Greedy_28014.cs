using System;

namespace baekjoon
{
  class Greedy_28014
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());

      string[] strArray = Console.ReadLine().Split(' ');

      int num = 0;
      int temp = Int32.Parse(strArray[0]);
      int count = 0;
      Boolean flag = false;
      for(int i = 1; i < N; i++)
      {
        num = Int32.Parse(strArray[i]);

        if(temp <= num)
        {
          temp = num;
        }
        else
        {
          count++;

          temp = num;
        }
      }

      System.Console.WriteLine(N - count);
    }
  }
}