using System;

namespace baekjoon
{
  class Mathematics_02875
  {
    public void solve()
    {
      String str = Console.ReadLine();

      int N = Int16.Parse(str.Split(' ')[0]);
      int M = Int16.Parse(str.Split(' ')[1]);
      int K = Int16.Parse(str.Split(' ')[2]);

      int max = 0;
      int compare1 = 0;
      int compare2 = 0;
      if(N + M <= K) max = 0;
      else
      {
        for(int i = 0; i <= K; i++){

          compare1 = (N - i) / 2;
          compare2 = M - (K - i);
          if(compare1 != 0 && compare2 != 0)
          {
              if(max < Math.Min(compare1, compare2)){
                
                max = Math.Min(compare1, compare2);
              }
          }
        }
      }

      System.Console.WriteLine(max);
    }
  }
}