using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace baekjoon
{
  class Graphs_02206
  {
    static int[] dx = new int[4]{-1,1,0,0};
    static int[] dy = new int[4]{0,0,-1,1};
    static char[,] array = new char[1000,1000];
    static int[,,] visited = new int[1000,1000,2];
    static int nx = 0;
    static int ny = 0;
    static int r = 0;
    static int c = 0;

    struct Position
    {
      public int x;
      public int y;
      public int wall;
    }

    static int BFS(int _x, int _y)
    {
      Queue<Position> queue = new Queue<Position>();
      Position position = new Position();

      position.x = _x;
      position.y = _y;
      position.wall = 0;

      queue.Enqueue(position);
      visited[_x,_y,0] = 1;

      while(queue.Count != 0)
      {
        var cur = queue.Peek();
        int w = cur.wall;
        queue.Dequeue();

        if(cur.x == r - 1 && cur.y == c - 1)
          return visited[cur.x, cur.y, w];

        for(int dir = 0; dir < 4; dir++)
        {
          nx = cur.x + dx[dir];
          ny = cur.y + dy[dir];

          if(nx < 0 || nx >= r || ny < 0 || ny >= c) continue;

          if(array[nx, ny] == '1' && w == 0)
          {
            Position temp = new Position();
            temp.x = nx;
            temp.y = ny;
            temp.wall = w + 1;

            queue.Enqueue(temp);
            visited[nx,ny,w+1] = visited[cur.x,cur.y,w] + 1;
          }
          else if(array[nx,ny] == '0' && visited[nx,ny,w] == 0)
          {
            Position temp = new Position();
            temp.x = nx;
            temp.y = ny;
            temp.wall = w;

            queue.Enqueue(temp);
            visited[nx,ny,w] = visited[cur.x,cur.y,w] + 1;
          }
        }
      }
      return -1;
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));

      int[] rc = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
      r = rc[0];
      c = rc[1];

      string str = string.Empty;
      for(int i = 0; i < r; i++)
      {
        str = sr.ReadLine();
        for(int j = 0; j < c; j++)
        {
          array[i,j] = str[j];
        }
      }

      sr.Close();
      Console.WriteLine(BFS(0,0));
    }
  }
}