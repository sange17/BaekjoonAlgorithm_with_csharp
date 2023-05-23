using System;

namespace baekjoon
{
  class Backtracking_09663
  {
    static int N;
    static int[] row = new int[15];
    static bool CanPlace(int bound)
    {

      for (int r = 0; r < bound; ++r)
      {

        if (row[bound] == row[r])
          return false;

        else if (Math.Abs(row[bound] - row[r]) == Math.Abs(bound - r))
          return false;
      }

      return true;
    }

    static int Queen(int r)
    {

      int toSet = 0;

      if (r == N)

          return 1;
      else
      {
        for (int c = 0; c < N; ++c)
        {

          row[r] = c;

          if (CanPlace(r))
            toSet += Queen(r + 1);
        }
      }

      row[r] = 0;

      return toSet;
    }

    public void solve()
    {

      N = Int32.Parse(Console.ReadLine());

      Console.WriteLine(Queen(0));
    }
  }
}