using System;
using System.Text;

namespace baekjoon
{
  class Mathematics_03733
  {
    public void solve()
    {
      string str = "";
      StringBuilder sb = new StringBuilder();

      int N = 0;
      int S = 0;

      while(true)
      {
        if((str = Console.ReadLine()) == null || str.Length == 0) 
        {
          System.Console.WriteLine(sb);
          break;
        }

        N = Convert.ToInt32(str.Split(' ')[0]);
        S = Convert.ToInt32(str.Split(' ')[1]);

        sb.Append(S / (N + 1) + "\n");
      }
    }
  }
}