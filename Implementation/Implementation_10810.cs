using System;
using System.Text;

namespace baekjoon
{
  class Implementation_10810
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      string str;

      str = sr.ReadLine();

      int N = Int32.Parse(str.Split(" ")[0]);
      int M = Int32.Parse(str.Split(" ")[1]);

      int[] array = new int[N + 1];

      string line;
      int i = 0;
      int j = 0;
      int k = 0;
      for(int p = 0; p < M; p++)
      {
        
        line = sr.ReadLine();

        i = Int32.Parse(line.Split(" ")[0]);
        j = Int32.Parse(line.Split(" ")[1]);
        k = Int32.Parse(line.Split(" ")[2]);

        for(int q = i; q <= j; q++){

          array[q] = k;
        }
      }

      for(int x = 1; x <= N; x++)
      {

        sw.Write(array[x] + " ");
      }

      sr.Close();
      sw.Close();
    }
  }
}