using System;

namespace baekjoon
{
  class Graphs_05639
  {
    static int[] tree = new int[10000];

    static void postOrder(int start, int end)
    {
      if(start >= end) return;

      if(start == end - 1)
      {
        System.Console.WriteLine(tree[start]);
        return;
      }

      int idx = start + 1;
      while(idx < end)
      {
        if(tree[start] < tree[idx]) break;
        idx++;
      }

      postOrder(start + 1, idx);
      postOrder(idx, end);
      System.Console.WriteLine(tree[start]);
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string num = string.Empty;
      int inputIdx = 0;
      while(true)
      {
        if((num = sr.ReadLine()) == null || num.Length == 0) break;

        tree[inputIdx++] = Int32.Parse(num);
      }

      postOrder(0, inputIdx);
    }
  }
}