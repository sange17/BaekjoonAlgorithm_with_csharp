using System;

namespace baekjoon
{
  class Implementation_28691
  {
    public void solve()
    {
      string line = Console.ReadLine();

      if(line.Equals("M")) System.Console.WriteLine("MatKor");
      if(line.Equals("W")) System.Console.WriteLine("WiCys");
      if(line.Equals("C")) System.Console.WriteLine("CyKor");
      if(line.Equals("A")) System.Console.WriteLine("AlKor");
      if(line.Equals("$")) System.Console.WriteLine("$clear");
    }
  }
}