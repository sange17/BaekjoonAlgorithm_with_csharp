using System;

namespace baekjoon
{
  class Implementation_01236
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int N = Int32.Parse(line.Split(' ')[0]);
      int M = Int32.Parse(line.Split(' ')[1]);

      string[,] array = new string[N, M];
      int rowCount = 0;
      int colCount = 0;
      int rowCheck = 0;
      int[] colArray = new int[M];

      for(int i = 0; i < N; i++)
      {
        
        line = Console.ReadLine();
        rowCheck = 0;
        for(int j = 0; j < M; j++)
        {
          array[i, j] = line[j].ToString();
          if(array[i, j] == "X")
          {
            rowCheck++;

            colArray[j] = 1;
          }
        }

        if(rowCheck == 0) rowCount++;
      }

      for(int i = 0; i < M; i++)
      {
        if(colArray[i] == 0) colCount++;
      }

      System.Console.WriteLine(rowCount + colCount - Math.Min(rowCount, colCount));
    }
  }
}