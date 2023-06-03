using System;
using System.Text;

namespace baekjoon
{
  class Implementation_05656
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      String str;

      int a = 0;
      int b = 0;
      String op = "";
      int i = 0;
      while(true)
      {
        str = sr.ReadLine();

        a = Int32.Parse(str.Split(" ")[0]);
        op = str.Split(" ")[1];
        b = Int32.Parse(str.Split(" ")[2]);
        i++;

        if(op.Equals(">")){
          if(a > b) sw.Write("Case " + i + ": true\n");
          else sw.Write("Case " + i + ": false\n");
        }else if(op.Equals(">=")){
          if(a >= b) sw.Write("Case " + i + ": true\n");
          else sw.Write("Case " + i + ": false\n");
        }else if(op.Equals("<")){
          if(a < b) sw.Write("Case " + i + ": true\n");
          else sw.Write("Case " + i + ": false\n");
        }else if(op.Equals("<=")){
          if(a <= b) sw.Write("Case " + i + ": true\n");
          else sw.Write("Case " + i + ": false\n");
        }else if(op.Equals("==")){
          if(a == b) sw.Write("Case " + i + ": true\n");
          else sw.Write("Case " + i + ": false\n");
        }else if(op.Equals("!=")){
          if(a != b) sw.Write("Case " + i + ": true\n");
          else sw.Write("Case " + i + ": false\n");
        }else if(op.Equals("E")){
          sr.Close();
          sw.Close();
          break;
        }
      }
    }
  }
}
