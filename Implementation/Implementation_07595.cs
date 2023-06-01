using System;
using System.Text;

namespace baekjoon
{
  class Implementation_07595
  {
    public void solve()
    {
      StringBuilder sb = new StringBuilder();

      int n = 0;
      while(true){

        n = Convert.ToInt32(Console.ReadLine());

        if(n == 0) {
          System.Console.WriteLine(sb);
          break;
        }

        for(int i = 1; i <= n; i++){

          for(int j = 0; j < i; j++){

            sb.Append("*");
          }

          sb.Append("\n");
        }
      }
    }
  }
}