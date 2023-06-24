using System;

namespace baekjoon
{
  class Greedy_09636
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      int T = Int32.Parse(sr.ReadLine());

      string str;
      int strLength = 0;

      int x, y, miss;
      for(int i = 0; i < T; i++)
      {

        x = 0 ;
        y = 0;
        miss = 0;

        str = sr.ReadLine();
        strLength = str.Length;

        for(int j = 0; j < strLength; j++)
        {

          if(str[j] == 'U')
          {
            y++;
          }
          else if(str[j] == 'R')
          {
            x++;
          }
          else if(str[j] == 'D')
          {
            y--;
          }
          else if(str[j] == 'L')
          {
            x--;
          }
          else if(str[j] == '?')
          {
            miss++;
          }
        }

        sw.Write((x - miss) + " " + (y - miss) + " " + (x + miss) + " " + (y + miss) + "\n");
      }

      sr.Close();
      sw.Close();
    }
  }
}