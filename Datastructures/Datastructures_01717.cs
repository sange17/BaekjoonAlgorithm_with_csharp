using System;
using System.Security.Cryptography;

namespace baekjoon
{
  class Datastructures_01717
  {
    static int[] r = new int[1000001];
    static int n, m;

    static int getParent(int num){
      if(r[num] == num)
        return num;
      else
        return r[num] = getParent(r[num]);
    }

    static void join(int a, int b)
    {
      r[getParent(a)] = getParent(b);
    }

    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      string line = sr.ReadLine();

      n = Int32.Parse(line.Split(" ")[0]);
      m = Int32.Parse(line.Split(" ")[1]);

      for(int i = 0; i <= n; i++)
      {
        r[i] = i;
      }

      while(m-- != 0)
      {
        int cmd, a, b;
        line = sr.ReadLine();

        cmd = Int32.Parse(line.Split(" ")[0]);
        a = Int32.Parse(line.Split(" ")[1]);
        b = Int32.Parse(line.Split(" ")[2]);

        if(cmd == 0)
        {
          join(a, b);
        }
        else
        {
          if(getParent(a) == getParent(b))
            sw.WriteLine("YES");
          else
            sw.WriteLine("NO");
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}