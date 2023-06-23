using System;

namespace baekjoon
{
  class Greedy_27106
  {
    public void solve()
    {
      int num = 100 - Int32.Parse(Console.ReadLine());

      int temp = num;
      int cent25 = temp / 25;
      temp = temp % 25;
      int cent10 = temp / 10;
      temp = temp % 10;
      int cent5 = temp / 5;
      temp = temp % 5;
      int cent1 = temp;

      System.Console.WriteLine(cent25 + " " + cent10 + " " + cent5 + " " + cent1);
    }
  }
}