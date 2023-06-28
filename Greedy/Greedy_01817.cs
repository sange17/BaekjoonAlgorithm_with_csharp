using System;

namespace baekjoon
{
  class Greedy_01817
  {
    public void solve()
    {
      string line1 = Console.ReadLine();
      int n = Int32.Parse(line1.Split(' ')[0]);
      int m = Int32.Parse(line1.Split(' ')[1]);

      string line2;
      string[] array;
      int sum = 0;
      int count = 0;

      if(n != 0)
      {
        line2 = Console.ReadLine();
        array = line2.Split(' ');
        count = 0;

        for(int i = 0; i < n; i++)
        {
          if(sum + Int32.Parse(array[i]) < m)
          {
            sum += Int32.Parse(array[i]);
          }
          else
          {
            count++;
            sum = Int32.Parse(array[i]);
          }

          System.Console.WriteLine(count);
        }

        System.Console.WriteLine(count);

      }
      else
      {
        System.Console.WriteLine(count);
      }
    }
  }
}