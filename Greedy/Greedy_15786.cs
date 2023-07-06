using System;

namespace baekjoon
{
  class Greedy_15786
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string str = sr.ReadLine();

      int N = Int32.Parse(str.Split(' ')[0]);
      int M = Int32.Parse(str.Split(' ')[1]);

      string S = sr.ReadLine();

      string line;
      int lineLength;
      int count;
      int idx;
      for(int i = 0; i < M; i++)
      {

        line = sr.ReadLine();
        lineLength = line.Length;
        count = 0;
        idx = 0;

        for(int j = 0; j < lineLength; j++)
        {
          if(S[idx] == line[j])
          {
            count++;
            idx++;

            if(count == N) break;
          }
        }

        if(count == N) sw.Write("true\n");
        else sw.Write("false\n");
      }

      sr.Close();
      sw.Close();
    }
  }
}