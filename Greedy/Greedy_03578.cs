using System;
using System.Text;

namespace baekjoon
{
  class Greedy_03578
  {
    public void solve()
    {
      int h = Int32.Parse(Console.ReadLine());

      StringBuilder sb = new StringBuilder();

      int twoHole = 0;
      int oneHole = 0;


      // h가 0인 경우
      if(h == 0)
      {
        sb.Append("1");
      }
      // h가 1인 경우
      else if(h == 1)
      {
        sb.Append("0");
      }
      // h가 2이상인 경우
      else
      {
        // h가 홀수인 경우
        if(h % 2 != 0)
        {
          sb.Append("4");

          for(int i = 0; i < h / 2; i++)
          {
            sb.Append("8");
          }
        }
        // h가 짝수인 경우
        else
        {
          for(int i = 0; i < h / 2; i++)
          {
            sb.Append("8");
          }
        }
      }

      System.Console.WriteLine(sb);
    }
  }
}