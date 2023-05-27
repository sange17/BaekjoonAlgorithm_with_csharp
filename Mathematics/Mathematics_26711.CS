using System;
using System.Numerics;
 
namespace baekjoon
{
  class Mathsmetics_26711
  {
    public void solve()
    {
      BigInteger a = BigInteger.Parse(Console.ReadLine());
      BigInteger b = BigInteger.Parse(Console.ReadLine());

       System.Console.WriteLine(BigInteger.Add(b, a));
    }
  }
}