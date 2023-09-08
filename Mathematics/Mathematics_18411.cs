using System;

namespace baekjoon
{
  class Mathematics_18411
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int[] array = new int[3];

      array[0] = Int32.Parse(line.Split(" ")[0]);
      array[1] = Int32.Parse(line.Split(" ")[1]);
      array[2] = Int32.Parse(line.Split(" ")[2]);
      
      Array.Sort(array);

      System.Console.WriteLine(array[1] + array[2]);
    }
  }
}