using System;

namespace baekjoon
{
  class Mathematics_27959
  {
    public void solve()
    {
      String str = Console.ReadLine();

      int N = Convert.ToInt32(str.Split(' ')[0]);
      int M = Convert.ToInt32(str.Split(' ')[1]);

      if(N * 100 >= M){
        System.Console.WriteLine("Yes");
      }else{
        System.Console.WriteLine("No");
      }
    }
  }
}