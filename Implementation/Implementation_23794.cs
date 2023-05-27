using System;
using System.Text;

namespace baekjoon
{
  class Implementation_23794
  {
    public void solve()
    {
      int N = Convert.ToInt32(Console.ReadLine());
      StringBuilder sb = new StringBuilder();

      for(int i = 0; i < N + 2; i++){

        sb.Append("@");
      }

      sb.Append("\n");
      for(int i = 1; i < N + 1; i++){

        sb.Append("@");
        for(int j = 0; j < N; j++){

          sb.Append(" ");
        }
        sb.Append("@\n");
      }
      
      for(int i = 0; i < N + 2; i++){

        sb.Append("@");
      }

      System.Console.WriteLine(sb);
    }
  }
}