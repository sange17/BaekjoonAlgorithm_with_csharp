using System;

namespace baekjoon
{
  class Implementation_18408
  {
    public void solve()
    {
      string line = Console.ReadLine();
      int lineLength = line.Length;

      int count1 = 0;
      int count2 = 0;
      for(int i = 0; i < lineLength; i++)
      {
        if(line[i] == '1') count1++;
        else if(line[i] == '2') count2++;
      }

      if(count1 > count2) System.Console.WriteLine(1);
      else System.Console.WriteLine(2);
    }
  }
}