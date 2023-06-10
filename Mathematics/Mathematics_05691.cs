using System;
using System.Text;

namespace baekjoon
{
  class Mathematics_05691
  {
    public void solve()
    {
      StringBuilder sb = new StringBuilder();
      string str;
      int a = 0;
      int b = 0;
      int x = 0;

      while(true)
      {
        str = Console.ReadLine();

        a = Convert.ToInt32(str.Split(' ')[0]);
        b = Convert.ToInt32(str.Split(' ')[1]);

        if(a == 0 && b == 0)
        {
          System.Console.WriteLine(sb);
          break;
        }

        sb.Append(a * 3 - a - b + "\n");
      }
    }
  }
}