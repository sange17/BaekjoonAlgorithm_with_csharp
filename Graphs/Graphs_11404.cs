using System;

namespace baekjoon
{
  class Graphs_11404
  {
    static int INT_MAX = 10000001;
    static int vertex = 0;
    static int edge = 0;
    static int[,] array = new int[101, 101];
    static string line = string.Empty;
    static int from = 0;
    static int to = 0;
    static int weight = 0;

    void floyd_warshall()
    {
      for(int i = 1; i <= vertex; i++)
      {
        for(int j = 1; j <= vertex; j++)
        {
          for(int k = 1; k <= vertex; k++)
          {
            if(array[j,i] != INT_MAX && array[i,k] != INT_MAX)
            {
              array[j,k] = Math.Min(array[j,k], array[j,i] + array[i,k]);
            }
          }
        }
      }
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      vertex = Int32.Parse(sr.ReadLine());
      edge = Int32.Parse(sr.ReadLine());
      for(int i = 1; i <= vertex; i++)
      {
        for(int j = 1; j <= vertex; j++)
        {
          if(i != j) array[i,j] = INT_MAX;
        }
      }
      for(int i = 0; i < edge; i++)
      {
        line = sr.ReadLine();
        from = Int32.Parse(line.Split(" ")[0]);
        to = Int32.Parse(line.Split(" ")[1]);
        weight = Int32.Parse(line.Split(" ")[2]);
        if(array[from,to] > weight) array[from,to] = weight;
      }
      floyd_warshall();
      for(int i = 1; i <= vertex; i++)
      {
        for(int j = 1; j <= vertex; j++)
        {
          sw.Write(array[i,j] != INT_MAX ? array[i,j] + " " : 0 + " ");
        }
        sw.WriteLine();
      }

      sr.Close();
      sw.Close();
    }
  }
}