using System;
using System.Text;

namespace baekjoon
{
  class String_06321
  {
    public void solve()
    {

      String strN = Console.ReadLine();
      StringBuilder sb = new StringBuilder();

      int n = Int16.Parse(strN);

      String line = "";
      int lineLength = 0;
      for(int i = 0; i < n; i++){

        line = Console.ReadLine();
        lineLength = line.Length;

        sb.Append("String #" + (i + 1) + "\n");
        
        for(int j = 0; j < lineLength; j++){

          // 65 ~ 90
          sb.Append((Char)(line[j] + 1 > 90 ? 65 : line[j] + 1));
        }

        sb.Append("\n");

        if(i != n - 1)
        {
          sb.Append("\n");
        }
      }

      System.Console.WriteLine(sb);
    }
  }
}