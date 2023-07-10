using System;

namespace baekjoon
{
  class Implementation_28235
  {
    public void solve()
    {
      string str = Console.ReadLine();

      if(str.Equals("SONGDO")){
        System.Console.WriteLine("HIGHSCHOOL");
      }else if(str.Equals("CODE")){
        System.Console.WriteLine("MASTER");
      }else if(str.Equals("2023")){
        System.Console.WriteLine("0611");
      }else{
        System.Console.WriteLine("CONTEST");
      }
    }
  }
}