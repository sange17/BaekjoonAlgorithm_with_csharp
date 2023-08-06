using System;

namespace baekjoon
{
  class Mathematics_11320
  {
    public void solve()
    {
      int T = Int32.Parse(Console.ReadLine());

      string line = string.Empty;
      int A = 0;
      int B = 0;
      int sum = 0;
      for(int i = 0; i < T; i++)
      {
        line = Console.ReadLine();

        A = Int32.Parse(line.Split(' ')[0]);
        B = Int32.Parse(line.Split(' ')[1]);

        if(A % B == 0)
        {
          for(int j = 0; j < A / B; j++)
          {
            sum += (j * 2 + 1);
          }
        }

        System.Console.WriteLine(sum);

        sum = 0;
      }
    }
  }
}