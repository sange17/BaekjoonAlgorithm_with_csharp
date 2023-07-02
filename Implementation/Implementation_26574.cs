using System;

namespace baekjoon
{
  class Implementation_26574
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      string str;
      for(int i = 0; i < n; i++)
      {
        str = Console.ReadLine();

        System.Console.WriteLine(str + " " + str);
      }
    }
  }
}