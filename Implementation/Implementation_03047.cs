using System;
using System.Text;

// 문자열을 정렬하는 것과 숫자를 정렬하는 것의 차이를 잊고 틀린 문제
namespace baekjoon
{
  class Implementation_03047
  {
    public void solve()
    {
      string numStr = Console.ReadLine();
      int[] array = new int[3];
      array[0] = Int32.Parse(numStr.Split(" ")[0]);
      array[1] = Int32.Parse(numStr.Split(" ")[1]);
      array[2] = Int32.Parse(numStr.Split(" ")[2]);

      string str = Console.ReadLine();
      int strLength = str.Length;

      StringBuilder sb = new StringBuilder();

      Array.Sort(array);

      for(int i = 0; i < strLength; i++)
      {
        sb.Append(array[(char)str[i]- 65]);

        if(i != 2){
          sb.Append(" ");
        }
      }

      System.Console.Write(sb);

    }
  }
}