using System;

namespace baekjoon
{
  class Mathematics_14920
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      int count = 1;
      int temp = n;
      while(true)
      {
        if(temp == 1) 
        {
          System.Console.WriteLine(count);
          break;
        }
        
        if(temp % 2 == 0)
        {
          temp /= 2;
        }
        else
        {
          temp = 3 * temp + 1;
        }

        count++;
      }
    }
  }
}