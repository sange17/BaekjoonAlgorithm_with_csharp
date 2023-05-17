using System;

namespace baekjoon
{
  class Mathematics_15633
  {
    public void solve()
    {
      int n = Int16.Parse(Console.ReadLine());
      int sum = 0;

      for(int i = 1; i <= (n / 2); i++){

        if(n % i == 0){

          sum += i;
        }
      }

      System.Console.WriteLine((sum + n) * 5 - 24);
    }
  }
}