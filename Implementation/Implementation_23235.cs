using System;
using System.Text;

namespace baekjoon
{
  class Implementation_23235
  {
    public void solve()
    {
      string str;
      int idx = 1;
      StringBuilder sb = new StringBuilder();


      while(true)
      {
        
        str = Console.ReadLine();

        if(str.Equals("0")) break;

        sb.Append("Case " + idx + ": Sorting... done!\n");
        idx++;

      }

      System.Console.WriteLine(sb);
    }
  }
}