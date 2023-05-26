using System;

namespace baekjoon
{
  class Mathematics_15667
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());
      int flame = 0;
      for(int k = 1; k < 10101; k++){

        flame = 1 + k + k * k;

        if(flame == N){
          System.Console.WriteLine(k);
          break;
        }
      }
    }
  }
}