using System;
using System.Diagnostics.Contracts;

namespace baekjoon
{
  class Mathematics_05666
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = string.Empty;
      double H = 0;
      double P = 0;
      while(true)
      {
        if((line = sr.ReadLine()) == null || line.Length == 0)
        {
          sr.Close();
          sw.Close();
          break;
        }

        H = double.Parse(line.Split(" ")[0]);
        P = double.Parse(line.Split(" ")[1]);

        sw.WriteLine((H / P).ToString("0.00"));
      }
    }
  }
}