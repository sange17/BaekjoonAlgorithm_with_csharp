using System;
using System.Xml.XPath;

namespace baekjoon
{
  class Mathematics_02863
  {
    public void solve()
    {
      string line = Console.ReadLine();
      int a = Int32.Parse(line.Split(' ')[0]);
      int b = Int32.Parse(line.Split(' ')[1]);
      line = Console.ReadLine();
      int c = Int32.Parse(line.Split(' ')[0]);
      int d = Int32.Parse(line.Split(' ')[1]);

      double[] array= {a, b, c, d};

      double temp = 0;
      double t = 0;
      double max = 0;
      int result = 0;
      for(int i = 0; i < 4; i++)
      {
        temp = (double)(array[0]/array[3] + array[1]/array[2]);

        if(temp > max)
        {
          max = temp;
          result = i;
        }

        t = array[3];
        array[3] = array[2];
        array[2] = array[1];
        array[1] = array[0];
        array[0] = t;
      }
      
      System.Console.WriteLine(result);
    }
  }
}