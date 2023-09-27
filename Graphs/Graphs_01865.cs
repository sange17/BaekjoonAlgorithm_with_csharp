using System;
using System.Net.Sockets;
using System.Numerics;

namespace baekjoon
{
  class Graphs_01865
  {
    static int n, m, w, INF = 987654321;
    static List<int[]>[] list;
    static int[] dist;

    static Boolean bellmanford(int s)
    {
      Array.Fill(dist, INF);
      dist[s] = 0;

      Boolean isUpdated = false;
      for(int i = 0; i < n; i++)
      {
        isUpdated = false;
        for(int j = 1; j < n + 1; j++)
        {
          int cur = j;
          foreach(int[] route in list[j])
          {
            int nxt = route[0];
            int cost = route[1];

            if(dist[cur] == INF) continue;

            if(dist[nxt] > dist[cur] + cost)
            {
              dist[nxt] = dist[cur] + cost;
              isUpdated = true;
              if(i == n - 1)
              {
                return true;
              }
            }
          }
        }

        if(!isUpdated) break;
      }

      return false;
    }


    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int tc = Int32.Parse(Console.ReadLine());

      string line = string.Empty;
      while(tc != 0)
      {
        line = Console.ReadLine();
        n = Int32.Parse(line.Split(" ")[0]);
        m = Int32.Parse(line.Split(" ")[1]);
        w = Int32.Parse(line.Split(" ")[2]);

        list = new List<int[]>[n + 1];
        dist = new int[n + 1];
        for(int i = 1; i < n + 1; i++)
        {
          list[i] = new List<int[]>();
        }

        int s, e, t;
        for(int i = 0; i < m + w; i++)
        {
          line = Console.ReadLine();

          s = Int32.Parse(line.Split(" ")[0]);
          e = Int32.Parse(line.Split(" ")[1]);
          t = Int32.Parse(line.Split(" ")[2]);

          if(i > m - 1)
          {
            list[s].Add(new int[] {e, -t});
          }
          else
          {
            list[s].Add(new int[] {e, t});
            list[e].Add(new int[] {s, t});
          }
        }

        Boolean f = false;
        for(int i = 1; i <= n; i++)
        {
          if(bellmanford(i)){
            f = true;
            break;
          }
        }

        if(f)
        {
          sw.WriteLine("YES");
        }
        else
        {
          sw.WriteLine("NO");
        }

        tc--;
      }

      sr.Close();
      sw.Close();
    }
  }
}