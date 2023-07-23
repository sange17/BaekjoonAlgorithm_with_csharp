using System;

namespace baekjoon
{
  class Implementation_10813
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = sr.ReadLine();

      int n = Int32.Parse(line.Split(' ')[0]);
      int m = Int32.Parse(line.Split(' ')[1]);

      int[] array = new int[n];

      for(int i = 0; i < n; i++)
      {
        array[i] = i + 1;
      }

      int I = 0;
      int J = 0;
      int TEMP = 0;
      for(int i = 0; i < m; i++)
      {
        line = sr.ReadLine();

        I = Int32.Parse(line.Split(' ')[0]);
        J = Int32.Parse(line.Split(' ')[1]);

        TEMP = array[I - 1];
        array[I - 1] = array[J - 1];
        array[J - 1] = TEMP;
      }

      for(int i = 0; i < n; i++)
      {
        sw.Write(array[i] + " ");
      }

      sr.Close();
      sw.Close();
    }
  }
}