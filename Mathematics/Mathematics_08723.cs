using System;

namespace baekjoon
{
  class Mathematics_08723
  {
    public void solve()
    {
      string str = Console.ReadLine();

      string[] array1 = str.Split(' ');
      int[] array2 = new int[3];
      array2[0] = Int32.Parse(array1[0]);
      array2[1] = Int32.Parse(array1[1]); 
      array2[2] = Int32.Parse(array1[2]);

      // 문자열 배열과 정수 배열 정렬은 결과가 다르다...
      Array.Sort(array2);

      int a = array2[0];
      int b = array2[1];
      int c = array2[2];
      
      // 정삼각형만 만들 수 있는 경우
      if(a == b && b == c)
      {
        System.Console.Write(2);
      }
      // 직각삼각형만 만들 수 있는 경우
      else if((c * c) == ((a * a) + (b * b)))
      {
        System.Console.Write(1);
      }
      // 정삼각형, 직각삼각형을 만들 수 없는 경우
      else
      {
        System.Console.Write(0);
      }
    }
  }
}