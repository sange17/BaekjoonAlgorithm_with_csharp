using System;
using System.Text;

namespace baekjoon
{
  class Backtracking_14534
  {
    static StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

    static char[] line;

    public void permutation(int len, String str, Boolean[] visit)
    {
      if(len == line.Length)
      {
        
        sw.WriteLine(str);
        return;
      }

      int n = line.Length;
      for(int i = 0; i < n; i++)
      {
        if(visit[i]) continue;

        visit[i] = true;
        permutation(len + 1, str + line[i], visit);
        visit[i] = false;
      }
    }

    public void solve()
    {
      
      int N = Convert.ToInt32(Console.ReadLine());

      for(int i = 1; i <= N; i++)
      {
        line = Console.ReadLine().ToCharArray();
        
        sw.Write("Case # {0}:\n", i);
        permutation(0, "", new Boolean[line.Length]);
      }

      sw.Close();
    }
  }
}