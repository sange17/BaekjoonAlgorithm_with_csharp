using System;

namespace baekjoon
{
  class String_17350
  {
    public void solve()
    {
      int N = Convert.ToInt32(Console.ReadLine());

      string line;
      bool check = false;
      for(int i = 0; i < N; i++){

        if(Console.ReadLine().Equals("anj")) check = true;
      }

      if(check){
        System.Console.WriteLine("뭐야;");
      }else{
        System.Console.WriteLine("뭐야?");
      }
    }
  }
}