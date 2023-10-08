using System;

namespace baekjoon
{
  class DP_17070
  {
    static int N = 0;
    static int[,] map = new int[17,17];
    static int[] dr = new int[3]{0,1,1};
    static int[] dc = new int[3]{1,0,1};
    static int answer = 0;

    static bool check(int r, int c)
    {
      if(r < 1 || r > N || c < 1 || c > N || map[r,c] == 1) return false;
      else return true;
    }

    static void DFS(int r, int c, int dir)
    {
      if(r == N && c == N)
      {
        answer++;
        return;
      }

      for(int i = 0; i < 3; i++)
      {
        if((dir == 0 && i == 1) || (dir == 1 && i == 0)) continue;

        int nr = r + dr[i];
        int nc = c + dc[i];
        if(check(nr, nc) == false) continue;
        if(i == 2 && (map[r + 1, c] == 1 || map[r,c + 1] == 1)) continue;
        DFS(nr, nc, i);
      }
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      N = Int32.Parse(sr.ReadLine());
      string line = string.Empty;

      for(int i = 1; i <= N; i++)
      {
        line = sr.ReadLine();
        for(int j = 1; j <= N; j++)
        {
          map[i,j] = Int32.Parse(line.Split(" ")[j-1]);
        }
      }
      
      DFS(1,2,0);
      System.Console.WriteLine(answer);
    }
  }
}