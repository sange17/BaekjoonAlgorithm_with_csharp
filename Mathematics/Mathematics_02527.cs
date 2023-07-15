using System;

namespace baekjoon
{
  class Mathematics_02527
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string str;

      int x1, y1, x2, y2, X1, Y1, X2, Y2;
      while(true)
      {
        str = sr.ReadLine();

        if(str == null || str.Length == 0)
        {
          sr.Close();
          sw.Close();
          break;
        }

        x1 = Int32.Parse(str.Split(' ')[0]);
        y1 = Int32.Parse(str.Split(' ')[1]);
        x2 = Int32.Parse(str.Split(' ')[2]);
        y2 = Int32.Parse(str.Split(' ')[3]);
        X1 = Int32.Parse(str.Split(' ')[4]);
        Y1 = Int32.Parse(str.Split(' ')[5]);
        X2 = Int32.Parse(str.Split(' ')[6]);
        Y2 = Int32.Parse(str.Split(' ')[7]);

        // 완전히 분리된 경우
        if(x1 > X2 || y2 < Y1 || x2 < X1 || y1 > Y2)
        {
          sw.WriteLine('d');
        }
        // 꼭짓점만 겹치는 경우
        else if((x1 == X2 && y1 == Y2) || (x2 == X1 && y1 == Y2) || (x2 == X1 && y2 == Y1) || (x1 == X2 && y2 == Y1))
        {
          sw.WriteLine('c');
        }
        // 선분이 겹치는 경우
        else if(x1 == X2 || y2 == Y1 || x2 == X1 || y1 == Y2)
        {
          sw.WriteLine('b');
        }
        // 속하거나 겹치는 경우
        else
        {
          sw.WriteLine('a');
        }
      }
    }
  }
}