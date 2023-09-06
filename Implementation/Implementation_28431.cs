using System;

namespace baekjoon
{
  class Implementation_28431
  {
    public void solve()
    {
      int[] array = new int[10];

      for(int i = 0; i < 5; i++)
      {
        array[Int32.Parse(Console.ReadLine())]++;
      }

      for(int i = 0; i < 10; i++)
      {
        if(array[i] % 2 == 1)
        {
          System.Console.WriteLine(i);
        }
      }
    }
  }
}