using System;

namespace baekjoon
{
  class Mathematics_11444
  {
    static long MOD = 1000000007;

    public static long[,] multiply(long[,] o1, long[,] o2)
    {
      long[,] ret = new long[2,2];

      ret[0, 0] = ((o1[0,0] * o2[0,0]) + (o1[0,1] * o2[1,0])) % MOD;
      ret[0, 1] = ((o1[0,0] * o2[0,1]) + (o1[0,1] * o2[1,1])) % MOD;
      ret[1, 0] = ((o1[1,0] * o2[0,0]) + (o1[1,1] * o2[1,0])) % MOD;
      ret[1, 1] = ((o1[1,0] * o2[0,1]) + (o1[1,1] * o2[1,1])) % MOD;

      return ret;
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      long N = long.Parse(sr.ReadLine());

      if(N == 1 || N == 0)
      {
        System.Console.WriteLine(N);
        return;
      }

      N--;

      long[,] origin = new long[,]{{1, 1}, {1, 0}};
      long[,] A = new long[,]{{1, 0}, {0, 1}};

      while(N > 0)
      {
        if(N % 2 == 1)
        {
          A = multiply(A, origin);
        }
        origin = multiply(origin, origin);

        N /= 2;
      }

      System.Console.WriteLine(A[0,0]);
    }
  }
}