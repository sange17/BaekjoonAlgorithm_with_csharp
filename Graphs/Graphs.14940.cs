using System;
using System.Collections;

namespace baekjoon
{
  class Graphs_14940
  {
    static int N, M;
    static int[,] map = new int[1000, 1000];
    static bool[,] visit = new bool[1000, 1000];

    static int[] dx = {1,-1,0,0};
    static int[] dy = {0,0,1,-1};

    static int[] temp = new int[1];
    static int px = 0;
    static int py = 0;
    static int nx = 0;
    static int ny = 0;
    static bool isCheck1 = false;
    static bool isCheck2 = false;

    static Queue<int[]> queue = new Queue<int[]>();

    static void bfs()
    {
      while(queue.Count != 0)
      {
        temp = queue.Peek();
        px = temp[0];
        py = temp[1];
        queue.Dequeue();

        for(int i = 0; i < 4; i++)
        {
          nx = px + dx[i];
          ny = py + dy[i];
          isCheck1 = (nx >= 0 && nx < N) ? true : false;
          isCheck2 = (ny >= 0 && ny < M) ? true : false;
          if(isCheck1 && isCheck2)
          {
            if(visit[nx, ny] == false)
            {
              map[nx, ny] = map[px, py] + 1;
              visit[nx, ny] = true;
              queue.Enqueue(new int[]{nx, ny});
            }
          }
        }
      }
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = sr.ReadLine();

      N = Int32.Parse(line.Split(" ")[0]);
      M = Int32.Parse(line.Split(" ")[1]);

      for(int x = 0; x < N; x++)
      {
        line = sr.ReadLine();
        for(int y = 0; y < M; y++)
        {
          map[x,y] = line.Split(" ")[y][0] - 48;
          if(map[x,y] == 2)
          {
            map[x,y] = 0;
            queue.Enqueue(new int[]{x, y});
            visit[x, y] = true;
          }
          else if(map[x, y] == 0)
          {
            visit[x, y] = true;
          }
        }
      }

      bfs();

      for(int x = 0; x < N; x++)
      {
        for(int y = 0; y < M; y++)
        {
          if(!visit[x, y])
          {
            sw.Write("-1 ");
          }else
          {
            sw.Write(map[x, y] + " ");
          }
        }
        sw.WriteLine();
      }

      sr.Close();
      sw.Close();
    }
  }
}