using System;

namespace baekjoon
{
  class Mathematics_02712
  {
    public void solve()
    {
      int T = Int32.Parse(Console.ReadLine());

      string line = string.Empty;
      double num = 0.0;
      string unit = string.Empty;
      for(int i = 0; i < T; i++)
      {
        line = Console.ReadLine();

        num = Double.Parse(line.Split(' ')[0]);
        unit = line.Split(' ')[1];

        if(unit.Equals("kg"))
        {
          System.Console.WriteLine(String.Format("{0:0.0000} lb", num * 2.2046));
        }
        else if(unit.Equals("lb"))
        {
          System.Console.WriteLine(String.Format("{0:0.0000} kg", num * 0.4536));
        }
        else if(unit.Equals("l"))
        {
          System.Console.WriteLine(String.Format("{0:0.0000} g", num * 0.2642));
        }
        else if(unit.Equals("g"))
        {
          System.Console.WriteLine(String.Format("{0:0.0000} l", num * 	3.7854));
        }
      }
    }
  }
}