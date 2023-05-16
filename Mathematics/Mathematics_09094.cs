using System;
using System.Text;

namespace baekjoon
{
  class Mathematics_09094
  {
    public void solve()
    {
      StringBuilder sb = new StringBuilder();

      int T = Int16.Parse(Console.ReadLine());
      int n = 0;
      int m = 0;
      int count = 0;

      for(int i = 0; i < T; i++){

        String line = Console.ReadLine();

        n = Int16.Parse(line.Split(' ')[0]);
        m = Int16.Parse(line.Split(' ')[1]);
        count = 0;

        for(int a = 1; a < n; a++){

          for(int b = a + 1; b < n; b++){

            if((a * a + b * b + m) % (a * b) == 0){

              count++;
            }
          }
        }

        sb.Append(count + "\n");
      }

      System.Console.WriteLine(sb);
    }
  }
}