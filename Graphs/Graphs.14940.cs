using System;
using System.Collections;

namespace baekjoon
{
  class Graphs_14940
  {
    static int N, M;
    static int[,] map = new int[1000, 1000];
    static int[,] visit = new int[1000, 1000];

    static int[] dx = {1,-1,0,0};
    static int[] dy = {0,0,1,-1};

    static Queue<int[]> queue = new Queue<int[]>();

    // static void bfs()
    // {
    //   while(!(queue.Count == 0))
    //   {
    //     int x = queue.
    //   }
    // }

    public void solve()
    {
      string line = Console.ReadLine();

      int A = Int32.Parse(line.Split(" ")[0]);
      int B = Int32.Parse(line.Split(" ")[1]);
      int C = Int32.Parse(line.Split(" ")[2]);

      int max = Math.Max(Math.Max(A, B), C);

      int sum = (max - A) + (max - B) + (max - C);

      System.Console.WriteLine(sum);
    }
  }
}