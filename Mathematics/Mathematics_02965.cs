using System;

namespace baekjoon
{
  class Mathematics_02965
  {
    public void solve()
    {
      String str = Console.ReadLine();

      int a = Int16.Parse(str.Split(' ')[0]);
      int b = Int16.Parse(str.Split(' ')[1]);
      int c= Int16.Parse(str.Split(' ')[2]);

      System.Console.WriteLine(Math.Max(b-a-1, c-b-1));
      
    }
  }
}