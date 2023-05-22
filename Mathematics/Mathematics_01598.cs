using System;

namespace baekjoon
{
  class Mathematics_01598
  {
    public void solve()
    {
      String str = Console.ReadLine();

      // int8   num1 = -128;                    // 8비트(1바이트) 크기의 부호 있는 정수형 변수 선언
      // int16  num2 = 32767;                  // 16비트(2바이트) 크기의 부호 있는 정수형 변수 선언 
      // int32  num3 = 2147483647;             // 32비트(4바이트) 크기의 부호 있는 정수형 변수 선언
      // int64  num4 = 9223372036854775807;    // 64비트(8바이트) 크기의 부호 있는 정수형 변수 선언
      int a = Int32.Parse(str.Split(' ')[0]);
      int b = Int32.Parse(str.Split(' ')[1]);

      int a_width = (a + 3) / 4;
      int a_height = a % 4 == 0 ? 4 : a % 4;
      int b_width = (b + 3) / 4;
      int b_height = b % 4 == 0 ? 4 : b % 4;

      int width = Math.Abs(a_width - b_width);
      int height = Math.Abs(a_height - b_height);

      System.Console.WriteLine(width + height);
    }
  }
}