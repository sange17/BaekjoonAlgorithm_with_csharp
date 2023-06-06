using System;

namespace baekjoon
{
  class Implementation_14909
  {
    public void solve()
    {
      String str = Console.ReadLine();
      int strLength = str.Length;
      int count = 0;
      string[] array = str.Split(' ');
      int arrLength = array.Length;

      if(strLength == 1){

        if(Convert.ToInt32(str) > 0)
        {
          count++;
        }
      }
      else
      {
        for(int i = 0; i < arrLength; i++){

          if(Convert.ToInt32(array[i]) > 0){
            count++;
          }
        }
      }

      System.Console.WriteLine(count);
    }
  }
}