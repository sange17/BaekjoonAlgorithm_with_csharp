using System;
using System.Text;

namespace baekjoon
{
  class Implementation_18883
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      String str = sr.ReadLine();

      int N = Int32.Parse(str.Split(' ')[0]);
      int M = Int32.Parse(str.Split(' ')[1]);

      for(int i = 1; i <= N * M; i++){

        if(i % M == 0) 
        {
          sw.Write(i + "\n");
        }
        else
        {
          sw.Write(i + " ");
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}