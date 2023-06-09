using System;

namespace baekjoon
{
  class Mathematics_02997
  {
    public void solve()
    {
      string str = Console.ReadLine();

      string[] strArray = str.Split(' ');
      int strArrayLength = strArray.Length;
      int[] intArray = new int[strArrayLength];

      for(int i = 0; i < strArrayLength; i++){

        intArray[i] = Convert.ToInt32(strArray[i]);
      }

      Array.Sort(intArray);

      int num = Math.Min(intArray[1] - intArray[0], intArray[2] - intArray[1]);

      if(intArray[1] - intArray[0] == intArray[2] - intArray[1]){

        System.Console.WriteLine(intArray[2] * 2 - intArray[1]);
      }
      else if(intArray[1] - intArray[0] > intArray[2] - intArray[1]){

        System.Console.WriteLine(intArray[1] * 2 - intArray[2]);
      }
      else{

        System.Console.WriteLine(intArray[1] * 2 - intArray[0]);
      }
    }
  }
}