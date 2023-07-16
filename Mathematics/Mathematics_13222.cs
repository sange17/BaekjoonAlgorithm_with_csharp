using System;

namespace baekjoon
{
  class Mathematics_13222
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int N = Int32.Parse(line.Split(' ')[0]);
      int W = Int32.Parse(line.Split(' ')[1]);
      int H = Int32.Parse(line.Split(' ')[2]);
      int R = W * W + H * H;    // 빗변

      int num = 0;
      for(int i = 0; i < N; i++)
      {

        num = Int32.Parse(Console.ReadLine());

        if(R >= num * num)
        {
          System.Console.WriteLine("YES");
        }
        else
        {
          System.Console.WriteLine("NO");
        }
      }      
    }
  }
}