using System;

namespace baekjoon
{
  class Mathematics_10419
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      int T = Int32.Parse(sr.ReadLine());
      int d = 0;
      int max = 0;

      for(int i = 0; i < T; i++)
      {
        max = 0;

        d = Int32.Parse(sr.ReadLine());

        for(int j = 0; j < Math.Sqrt(d); j++)
        {
          if((j + j * j) <= d) max = j;
        }

        sw.WriteLine(max);
      }

      sr.Close();
      sw.Close();
    }
  }
}