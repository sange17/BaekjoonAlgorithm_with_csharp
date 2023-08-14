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
      int[] rowArray = new int[N];
      int[] colArray = new int[M];
      int rowCheck = 0;
      int colCheck = 0;

      for(int i = 0; i < N; i++)
      {
        
        line = Console.ReadLine();
        rowCheck = 0;
        for(int j = 0; j < M; j++)
        {
          array[i, j] = line.Split(' ')[j];
          if(array[i, j] == "X")
          {
            rowCheck++;

            colArray[j] = 1;
          }
          else
          {
            colArray[j] = 0;
          }
        }

        if(rowCheck == 0)
        {
          rowArray[i] = 0;
        }
        else
        {
          rowArray[i] = 1;
        }
      }

      for(int i = 0; i < N; i++)
      {
        
        for(int j = 0; j < M; j++)
        {
          
        }
      }
    }
  }
}