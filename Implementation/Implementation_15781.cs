using System;

namespace baekjoon
{
  class Implementation_15781
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int N = Int32.Parse(line.Split(' ')[0]);
      int M = Int32.Parse(line.Split(' ')[1]);

      int[] helmetArray = new int[N];
      int[] bagArray = new int[M];

      line = Console.ReadLine();
      for(int i = 0; i < N; i++)
      {
        helmetArray[i] = Int32.Parse(line.Split(' ')[i]);
      }

      line = Console.ReadLine();
      for(int i = 0; i < M; i++)
      {
        bagArray[i] = Int32.Parse(line.Split(' ')[i]);
      }

      Array.Sort(helmetArray);
      Array.Sort(bagArray);

      System.Console.WriteLine(bagArray[M - 1] + helmetArray[N - 1]);
    }
  }
}