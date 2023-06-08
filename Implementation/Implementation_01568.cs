using System;

namespace baekjoon
{
  class Implementation_01568
  {
    public void solve()
    {
      int num = Convert.ToInt32(Console.ReadLine());
      int songCnt = 1;
      int time = 0;

      while(true)
      {

        if(num < songCnt)
        {
          songCnt = 1;
        }

        num -= songCnt;

        if(num <= 0) 
        {
          time++;
          break;
        }
        
        songCnt++;
        time++;

      }

      System.Console.WriteLine(time);
    }
  }
}