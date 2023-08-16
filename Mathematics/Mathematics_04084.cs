using System;

namespace baekjoon
{
  class Mathematics_04084
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = string.Empty;

      int ta = 0;
      int a = 0;
      int b = 0;
      int c = 0;
      int d = 0;
      int count;

      while(true)
      {
        line = sr.ReadLine();
        count = 0;

        if(line.Equals("0 0 0 0"))
        {
          sr.Close();
          sw.Close();
          break;
        }

        a = Int32.Parse(line.Split(" ")[0]);
        b = Int32.Parse(line.Split(" ")[1]);
        c = Int32.Parse(line.Split(" ")[2]);
        d = Int32.Parse(line.Split(" ")[3]);

        while(!(a == b && b == c && c == d)) 
        {
          ta = Math.Abs(a);
          a = Math.Abs(a - b);
          b = Math.Abs(b - c);
          c = Math.Abs(c - d);
          d = Math.Abs(d - ta);

          count++;
        }

        sw.WriteLine(count);
      }
    }
  }
}