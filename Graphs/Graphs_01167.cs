using System;

namespace baekjoon
{
  class Graphs_01167
  {
    static bool[] visited;
    static List<List<int[]>> graph;
    static int maxcost;
    static int maxcostV;

    static void DFS(int i, int c)
    {
      visited[i] = true;

      foreach(int[] next in graph[i])
      {
        if(visited[next[0]]) continue;

        visited[next[0]] = true;
        DFS(next[0], c + next[1]);
      }

      if(maxcost < c)
      {
        maxcost = c;
        maxcostV = i;
      }
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int V = Int32.Parse(sr.ReadLine());

      graph = new List<List<int[]>>();
      visited = new bool[V + 1];

      for(int i = 0; i < V + 1; i++)
      {
        graph.Add(new List<int[]>());
      }

      for(int i = 0; i < V; i++)
      {
        int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

        for(int j = 1; j < input.Length; j += 2)
        {
          if(input[j] == -1) break;

          graph[input[0]].Add(new int[] {input[j], input[j + 1]});
          graph[input[j]].Add(new int[] {input[0], input[j + 1]});
        }
      }

      maxcost = 0;
      maxcostV = 1;

      DFS(1, 0);
      Array.Fill(visited, false);
      DFS(maxcostV, 0);

      sw.WriteLine(maxcost);
      sr.Close();
      sw.Close();
    }
  }
}