using System;
using System.Xml.Serialization;

namespace baekjoon
{
  class Backtracking_15686
  {
    static int N = 0;
    static int M = 0;
    static int [,] node = new int[51,51];
    static bool [,] isChecked = new bool[51,51];
    static int ans = Int32.MaxValue;

    static List<List<int>> chicken = new List<List<int>>();
    static List<List<int>> house = new List<List<int>>();
    static List<List<int>> chosen = new List<List<int>>();

    static void func(int cnt, int idx)
    {
      if(cnt == M)
      {
        int CDist = 0;
        int HDist = 0;
        int x = 0;
        int y = 0;
        foreach(List<int> h in house)
        {
          HDist = Int32.MaxValue;
          foreach(List<int> ch in chosen)
          {
            x = Math.Abs(ch[0] - h[0]);
            y = Math.Abs(ch[1] - h[1]);
            HDist = Math.Min(HDist, x + y);
          }
          CDist += HDist;
        }
        ans = Math.Min(ans, CDist);
        return;
      }

      int chickenCount = chicken.Count;
      for(int i = idx; i < chickenCount; i++)
      {
        List<int> x = chicken[i];

        if(chickenCount - i < M - cnt) return;
        if(isChecked[x[0], x[1]]) continue;
        
        isChecked[x[0], x[1]] = true;
        chosen.Add(x);

        func(cnt + 1, idx + 1);

        chosen.RemoveAt(chosen.Count - 1);
        isChecked[x[0], x[1]] = false;
      }
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = sr.ReadLine();
      N = Int32.Parse(line.Split(" ")[0]);
      M = Int32.Parse(line.Split(" ")[1]);

      for(int i = 1; i <= N; i++)
      {
        line = sr.ReadLine();
        for(int j = 1; j <= N; j++)
        {
          node[i,j] = Int32.Parse(line.Split(" ")[j - 1]);
          if(node[i,j] == 1) house.Add(new List<int>{i,j});
          else if(node[i,j] == 2) chicken.Add(new List<int>{i,j});
        }
      }

      func(0,0);

      System.Console.WriteLine(ans);
    }
  }
}