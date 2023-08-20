using System;

// 문제 이해를 못하고 낚인 문제
namespace baekjoon
{
  class Mathematics_08674
  {
    public void solve()
    {
      string line = Console.ReadLine();
      long row = long.Parse(line.Split(' ')[0]);
      long column = long.Parse(line.Split(' ')[1]);

      if(row % 2 == 0 || column % 2 == 0) System.Console.WriteLine(0);
      else if(column % 2 == 0 || row % 2 != 0) System.Console.WriteLine(Math.Min(row, column));
    }
  }
}