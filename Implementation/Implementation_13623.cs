using System;

namespace baekjoon
{
  class Implementation_13623
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int a = Int32.Parse(line.Split(' ')[0]);
      int b = Int32.Parse(line.Split(' ')[1]);
      int c = Int32.Parse(line.Split(' ')[2]);

      if(a == b && b == c)
      {
        System.Console.WriteLine("*");
      }
      else if(a == b && b != c)
      {
        System.Console.WriteLine("C");
      }
      else if(a == c && b != c)
      {
        System.Console.WriteLine("B");
      }
      else if(a != b && b == c)
      {
        System.Console.WriteLine("A");
      }
    }
  }
}