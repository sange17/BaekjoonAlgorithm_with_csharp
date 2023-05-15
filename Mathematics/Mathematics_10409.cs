using System;

namespace baekjoon
{
  class Mathematics_10409
  {
    public void solve()
    {
      String str = Console.ReadLine();

      int n = Int16.Parse(str.Split(' ')[0]);
      int T = Int16.Parse(str.Split(' ')[1]);

      String[] array = Console.ReadLine().Split(' ');

      int count = 0;
      int sum = 0;
      for(int i = 0; i < n; i++){

        sum += Int16.Parse(array[i]);

        if(sum > T) break;

        count++;
      }

      System.Console.WriteLine(count);
    }
  }
}