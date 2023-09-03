using System;

namespace baekjoon
{
  class Mathematics_09772
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string str;
      double a, b;

      while(true)
      {
        if((str = sr.ReadLine()) == null || str.Length == 0)
        {
          sr.Close();
          sw.Close();

          break;
        }

        a = double.Parse(str.Split(' ')[0]);
        b = double.Parse(str.Split(' ')[1]);

        if(a == 0 || b == 0)
        {
          sw.Write("AXIS\n");
        }else if(a > 0 && b > 0)
        {
          sw.Write("Q1\n");
        }else if(a < 0 && b > 0)
        {
          sw.Write("Q2\n");
        }else if(a < 0 && b < 0)
        {
          sw.Write("Q3\n");
        }else if(a > 0 && b < 0)
        {
          sw.Write("Q4\n");
        }
      }
    }
  }
}