using System;

// 입력의 두번째 line의 N은 주파수가 아닌 주파수의 개수이다.
namespace baekjoon
{
  class Greedy_03135
  {
    public void solve()
    {
      string str = Console.ReadLine();
      int N = Int32.Parse(Console.ReadLine());

      int A = Int32.Parse(str.Split(' ')[0]);
      int B = Int32.Parse(str.Split(' ')[1]);

      int between = Math.Abs(A - B);
      int min = between;

      int num = 0;
      for(int i = 0; i < N; i++)
      {

        num = Int32.Parse(Console.ReadLine());

        if(Math.Abs(B - num) + 1 < min)
          min = Math.Abs(B - num) + 1;
      }

      System.Console.WriteLine(min);
    }
  }
}