using System;

// 형변환에 주의할 것
namespace baekjoon
{
  class Greedy_15001
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());
      int[] array = new int[N];

      long sum = 0;

      for(int i = 0; i < N; i++)
      {

        array[i] = Int32.Parse(Console.ReadLine());
      }

      for(int i = 1; i < N; i++)
      {

        sum += (long)Math.Pow(array[i - 1] - array[i], 2);
      }

      System.Console.WriteLine(sum);
    }
  }
}