using System;

namespace baekjoon
{
  class Graphs_21736
  {
    static int N, M;
    static int startRow = 0;
    static int startCol = 0;
    static char[,] map = new char[600, 600];
    static bool[,] visit = new bool[600, 600];

    static int[] dy = {0,0,1,-1};
    static int[] dx = {1,-1,0,0};

    static int[] temp = new int[1];
    static int px = 0;
    static int py = 0;
    static int nx = 0;
    static int ny = 0;
    static bool isCheck1 = false;
    static bool isCheck2 = false;
    static Queue<int[]> queue = new Queue<int[]>();

    static string bfs()
    {
      int ans = 0;
      queue.Enqueue(new int[]{startRow, startCol});
      visit[startRow, startCol] = true;
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
          isCheck1 = nx >= 0 && nx < N ? true : false;
          isCheck2 = ny >= 0 && ny < M ? true : false;
          if(isCheck1 && isCheck2)
          {
            if(visit[nx, ny] || map[nx, ny] == 'X') continue;
            if(map[nx, ny] == 'P') ans++;
            visit[nx, ny] = true;
            queue.Enqueue(new int[]{nx, ny});
          }
        }
      }

      if(ans == 0) return "TT";
      return ans.ToString();
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
          map[x,y] = line[y];
          if(map[x,y] == 'I') {
            startRow = x;
            startCol = y;
          }
        }
      }

      System.Console.WriteLine(bfs());
    }
  }
}