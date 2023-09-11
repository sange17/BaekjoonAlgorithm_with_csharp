using System;

namespace baekjoon
{
  class Implementation_27541
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());
      string str = Console.ReadLine();

      if(str[n - 1].Equals('G'))
      {
        System.Console.WriteLine(str.Substring(0, n - 1));
      }
      else
      {
        System.Console.WriteLine(str + "G");
      }
    }
  }
}