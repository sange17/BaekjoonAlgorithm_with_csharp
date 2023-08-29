using System;

namespace baekjoon
{
  class Implementation_16017
  {
    public void solve()
    {
      int one = Int32.Parse(Console.ReadLine());
      int two = Int32.Parse(Console.ReadLine());
      int three = Int32.Parse(Console.ReadLine());
      int four = Int32.Parse(Console.ReadLine());

      if(((one == 8 && four == 8) 
       || (one == 9 && four == 9) 
       || (one == 8 && four == 9) 
       || (one == 9 && four == 8)) && (two == three)) System.Console.WriteLine("ignore");
      else System.Console.WriteLine("answer");
    }
  }
}