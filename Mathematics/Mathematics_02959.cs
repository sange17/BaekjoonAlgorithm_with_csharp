using System;

namespace baekjoon
{
  class Mathematics_02959
  {
    public void solve()
    {
      string[] strings = Console.ReadLine().Split(' ');

      Array.Sort(strings);

      int width = Int32.Parse(strings[0]);
      int height = Int32.Parse(strings[2]);

      System.Console.WriteLine(width * height);
    }
  }
}