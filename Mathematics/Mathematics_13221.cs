using System;

namespace baekjoon
{
  class Mathematics_13221
  {
    public void solve()
    {
      string line;

      line = Console.ReadLine();
      int x1 = Int32.Parse(line.Split(' ')[0]);
      int y1 = Int32.Parse(line.Split(' ')[1]);
      int cnt = Int32.Parse(Console.ReadLine());

      int x2, y2, distance;
      int resultX = 0;
      int resultY = 0;
      int min = int.MaxValue;
      for(int i = 0; i < cnt; i++)
      {

        line = Console.ReadLine();

        x2 = Int32.Parse(line.Split(' ')[0]);
        y2 = Int32.Parse(line.Split(' ')[1]);
        distance = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);

        if(min > distance)
        {
          min = distance;
          resultX = x2;
          resultY = y2;
        }
      }

      System.Console.WriteLine(resultX + " " + resultY);
    }
  }
}