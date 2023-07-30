using System;

namespace baekjoon
{
  class Mathematics_02975
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = string.Empty;

      int money1 = 0;
      string type = string.Empty;
      int money2 = 0;

      while(true)
      {
        line = Console.ReadLine();

        if(line.Equals("0 W 0")) 
        {
          sr.Close();
          sw.Close();
          break;
        }

        money1 = Int32.Parse(line.Split(' ')[0]);
        type = line.Split(' ')[1];
        money2 = Int32.Parse(line.Split(' ')[2]);

        if(type.Equals("D"))
        {
          sw.WriteLine(money1 + money2);
        }
        else if(type.Equals("W"))
        {
          if(money1 - money2 < -200)
          {
            sw.WriteLine("Not allowed");
          }
          else
          {
            sw.WriteLine(money1 - money2);
          }
        }
      }
    }
  }
}