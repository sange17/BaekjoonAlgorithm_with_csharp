using System;

namespace baekjoon
{
  class Implementation_10996
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      int N = Int32.Parse(sr.ReadLine());
      int quotient = 0;
      int remainder = 0;

      if(N % 2 == 0)
      {
        quotient = N / 2;
        remainder = N / 2;
      }
      else
      {
        quotient = N / 2 + 1;
        remainder = N / 2;
      }

      for(int i = 0; i < N; i++)
      {

        for(int j = 0; j < quotient; j++)
        {
          sw.Write("*");

          if(j != quotient - 1)
          {
            sw.Write(" ");
          }
        }

        sw.WriteLine();

        for(int j = 0; j < remainder; j++)
        {
          sw.Write(" *");
        }

        if(i != N - 1)
        {
          sw.WriteLine();
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}