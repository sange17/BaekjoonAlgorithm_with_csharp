using System;

namespace baekjoon
{
  class Mathematics_11648
  {
    public void solve()
    {
      string num = Console.ReadLine();
      int numLength = num.Length;
      int result = 0;
      int count = 0;

      while(numLength != 1)
      {
        result = 1;

        for(int i = 0; i < numLength; i++)
        {
          result *= (num[i] - 48);
        }

        num = result.ToString();
        numLength = num.Length;

        count++;
      }

      System.Console.WriteLine(count);
    }
  }
}