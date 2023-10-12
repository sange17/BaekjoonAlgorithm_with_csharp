using System;

namespace baekjoon
{
  class Mathematics_28938
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int n = Int32.Parse(sr.ReadLine());

      int sum = 0;

      string[] line = sr.ReadLine().Split(" ");
      for(int i = 0; i < n; i++)
      {
        sum += Int32.Parse(line[i]);
      }

      if(sum > 0) System.Console.WriteLine("Right");
      else if(sum < 0) System.Console.WriteLine("Left");
      else System.Console.WriteLine("Stay");
    }
  }
}