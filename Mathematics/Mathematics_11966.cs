using System;

namespace baekjoon
{
  class Mathematics_11966
  {
    public void solve()
    {
      int n = Int32.Parse(Console.ReadLine());

      int[] array = new int[32];

      array[0] = 1;
      for (int i = 1; i <= 31; i++) 
      {
        array[i] = array[i - 1] * 2;
      }

      Boolean isCheck = false;
      for (int i = 0; i <= 31; i++) 
      {
        if (array[i] == n) 
        {
          isCheck = true;
          break;
        }
      }

      if(isCheck)
      {
        System.Console.WriteLine(1);
      }
      else
      {
        System.Console.WriteLine(0);
      }
    }
  }
}