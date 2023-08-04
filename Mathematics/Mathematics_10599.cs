using System;

namespace baekjoon
{
  class Mathematics_10599
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = string.Empty;

      int a = 0;
      int b = 0;
      int c = 0;
      int d = 0;
      
      #pragma warning restore format
      while(true)
      {
        line = sr.ReadLine();

        a = Int32.Parse(line.Split(' ')[0]);
        b = Int32.Parse(line.Split(' ')[1]);
        c = Int32.Parse(line.Split(' ')[2]);
        d = Int32.Parse(line.Split(' ')[3]);

        if(a == 0 && b == 0 && c == 0 && d == 0)
        {
          sr.Close();
          sw.Close();
          break;
        }

        sw.WriteLine((c - b) + " " + (d - a));
      }
    }
  }
}