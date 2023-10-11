using System;

namespace baekjoon
{
  class Graphs_01043
  {
    static int[] parents;
    static List<int> eList = new List<int>();

    static int find(int x)
    {
      if(parents[x] == x) return x;
      return find(parents[x]);
    }

    static void union(int x, int y)
    {
      int rx = find(x);
      int ry = find(y);
      if(eList.contains(ry))
      {
        int tmp = rx;
        rx = ry;
        ry = tmp;
      }

      parents[ry] = rx;
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = Console.ReadLine();
      int n = Int32.Parse(line.Split(" ")[0]);
      int m = Int32.Parse(line.Split(" ")[1]);

      parents = new int[n + 1];
      for(int i = 1; i < n + 1; i++)
      {
        parents[i] = i;
      }
    }
  }
}