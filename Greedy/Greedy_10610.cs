using System;

// 배수 판정법에 대해서 알게된 문제
namespace baekjoon
{
  class Greedy_10610
  {
    public void solve()
    {
      string line = Console.ReadLine();
      int lineLength = line.Length;

      char[] array = line.ToCharArray();

      long sum = 0;

      if(!line.Contains('0')) System.Console.WriteLine(-1);
      else 
      {
        for(int i = 0; i < lineLength; i++)
        {
          sum += (array[i] - 48);
        }

        if(sum % 3 == 0)
        {
          System.Console.Write(String.Concat(line.OrderByDescending(c => c)));
        }
        else
        {
          System.Console.WriteLine(-1);
        }
      }
    }
  }
}