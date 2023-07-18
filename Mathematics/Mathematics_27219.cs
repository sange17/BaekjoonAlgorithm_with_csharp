using System;

namespace baekjoon
{
  class Mathematics_27219
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int n = Int32.Parse(sr.ReadLine());

      for(int i = 0; i < n / 5; i++)
      {
        sw.Write("V");
      }

      for(int i = 0; i < n % 5; i++)
      {
        sw.Write("I");
      }

      sr.Close();
      sw.Close();
    }
  }
}