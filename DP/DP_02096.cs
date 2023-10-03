using System;

namespace baekjoon
{
  class DP_02096
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int n = Int32.Parse(sr.ReadLine());
      int[] map = new int[3];
      int[] maxCnt = new int[3];
      int[] minCnt = new int[3];

      string line = string.Empty;
      for(int i = 0; i < n; i++)
      {
        line = sr.ReadLine();

        map[0] = Int32.Parse(line.Split(" ")[0]);
        map[1] = Int32.Parse(line.Split(" ")[1]);
        map[2] = Int32.Parse(line.Split(" ")[2]);

        if(i == 0)
        {
          maxCnt[0] = map[0];
          maxCnt[1] = map[1];
          maxCnt[2] = map[2];
          minCnt[0] = map[0];
          minCnt[1] = map[1];
          minCnt[2] = map[2];
        }
        else
        {
          int[] preMaxCnt = new int[3]{maxCnt[0], maxCnt[1], maxCnt[2]};
          maxCnt[0] = Math.Max(preMaxCnt[0], preMaxCnt[1]) + map[0];
          maxCnt[1] = Math.Max(Math.Max(preMaxCnt[0], preMaxCnt[1]), preMaxCnt[2]) + map[1];
          maxCnt[2] = Math.Max(preMaxCnt[1], preMaxCnt[2]) + map[2];

          int[] preMinCnt = new int[3]{minCnt[0], minCnt[1], minCnt[2]};
          minCnt[0] = Math.Min(preMinCnt[0], preMinCnt[1]) + map[0];
          minCnt[1] = Math.Min(Math.Min(preMinCnt[0], preMinCnt[1]), preMinCnt[2]) + map[1];
          minCnt[2] = Math.Min(preMinCnt[1], preMinCnt[2]) + map[2];
        }
      }

      System.Console.WriteLine(Math.Max(Math.Max(maxCnt[0], maxCnt[1]), maxCnt[2]) + " " + Math.Min(Math.Min(minCnt[0], minCnt[1]), minCnt[2]));
    }
  }
}