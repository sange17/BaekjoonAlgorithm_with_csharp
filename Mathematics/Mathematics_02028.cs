using System;

namespace baekjoon
{
  class Mathematics_02028
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());

      string line = string.Empty;
      int lineLength = 0;
      Boolean check;
      int num = 0;
      int powNum = 0;
      for(int i = 0; i < N; i++)
      {
        line = Console.ReadLine();
        lineLength = line.Length;
        check = false;

        num = Int32.Parse(line);

        powNum = num * num;

        if(lineLength == 1)
        {
          if(powNum % 10 == num) check = true;
        }
        else if(lineLength == 2)
        {
          if(powNum % 100 == num) check = true;
        }
        else if(lineLength == 3)
        {
          if(powNum % 1000 == num) check = true;
        }
        else if(line.Length == 4)
        {
          if(powNum % 10000 == num) check = true;
        }

        if(check) System.Console.WriteLine("YES");
        else System.Console.WriteLine("NO");
      }
    }
  }
}