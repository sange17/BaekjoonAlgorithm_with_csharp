using System;

namespace baekjoon
{
  class Mathematics_01225
  {
    public void solve()
    {
      string str = Console.ReadLine();
      string strA = str.Split(' ')[0];
      string strB = str.Split(' ')[1];

      int strALength = strA.Length;
      int strBLength = strB.Length;
      int sum = 0;
      long result = 0;

      if(strA.Equals("0") || strB.Equals("0"))
      {
        System.Console.WriteLine(0);
      }
      else
      {
        for(int i = 0; i < strBLength; i++)
        {
          sum += (strB[i] - 48);
        }

        for(int j = 0; j < strALength; j++)
        {
          result += ((strA[j] - 48) * sum);
        }

        System.Console.WriteLine(result);
      }
    }
  }
}