using System;

namespace baekjoon
{
  class Greedy_28062
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());
      string[] str = Console.ReadLine().Split(' ');
      int strLength = str.Length;

      int[] array = new int[N];

      for(int i = 0; i < N; i++)
      {
        array[i] = Int32.Parse(str[i]);
      }

      int sum = 0;
      int max = 0;
      for(int i = 0; i < N - i; i++)
      {
        for(int j = 0; j <= i; j++)
        {
          sum += array[j];
        }
      }
    }
  }
}