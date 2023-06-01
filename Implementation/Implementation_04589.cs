using System;
using System.Text;

namespace baekjoon
{
  class Implementation_04589
  {
    public void solve()
    {
      int N = Convert.ToInt32(Console.ReadLine());
      StringBuilder sb = new StringBuilder();

      String str;
      int a = 0;
      int b = 0;
      int c = 0;

      sb.Append("Gnomes:\n");
      for(int i = 0; i < 3; i++){

        str = Console.ReadLine();
        a = Convert.ToInt32(str.Split(' ')[0]);
        b = Convert.ToInt32(str.Split(' ')[1]);
        c = Convert.ToInt32(str.Split(' ')[2]);

        if((b - a) * (c - b) > 0) {
          sb.Append("Ordered");
        }else{
          sb.Append("Unordered");
        }

        if(i == N - 1) break;
        else sb.Append("\n");
      }
      System.Console.WriteLine(sb);
    }
  }
}