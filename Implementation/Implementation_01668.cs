using System;

namespace baekjoon
{
  class Implementation_01668
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());

      int[] array = new int[N];
      int leftCount = 1;
      int rightCount = 1;

      for(int i = 0; i < N; i++) 
      {
        array[i] = Int32.Parse(Console.ReadLine());
      }

      int temp1 = array[0];
      for(int i = 1; i < N; i++)
      {

        if(temp1 < array[i])
        {
          leftCount++;
          temp1 = array[i];
        }
      }

      int temp2 = array[N - 1];
      for(int i = N - 2; i >= 0; i--)
      {
        if(temp2 < array[i])
        {
          rightCount++;
          temp2 = array[i];
        }
      }
      
      System.Console.WriteLine(leftCount);
      System.Console.WriteLine(rightCount);
    }
  }
}