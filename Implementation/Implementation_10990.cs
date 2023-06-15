using System;

namespace baekjoon
{
  class Implementation_10990
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      String str;

      int N = Int32.Parse(sr.ReadLine());

      for(int i = 1; i <= N; i++)
      {

        for(int j = 1; j <= N - i; j++)
        {
          sw.Write(" ");
        }

        if(i > 1)
        {
          sw.Write("*");

          for(int j = 1; j <= (i - 1) * 2 - 1; j++)
          {
            sw.Write(" ");
          }

          sw.Write("*");
        }
        else
        {
          sw.Write("*");
        }

        sw.WriteLine();
      }

      sw.Close();
    }
  }
}