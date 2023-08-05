using System;

namespace baekjoon
{
  class Implementation_10865
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = sr.ReadLine();
      int N = Int32.Parse(line.Split(' ')[0]);
      int M = Int32.Parse(line.Split(' ')[1]);
      int[] array = new int[N + 1];

      int A = 0;
      int B = 0;
      for(int i = 0; i < M; i++)
      {
        line = sr.ReadLine();

        A = Int32.Parse(line.Split(' ')[0]);
        B = Int32.Parse(line.Split(' ')[1]);

        array[A]++;
        array[B]++;
      }

      for(int i = 1; i <= N; i++)
      {
        sw.WriteLine(array[i]);
      }

      sr.Close();
      sw.Close();
    }
  }
}