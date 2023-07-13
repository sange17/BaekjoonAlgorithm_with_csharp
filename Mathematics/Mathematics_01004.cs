using System;

// 삼항연산자에 후위연산자가 포함된 연산을 할 경우 값이 어떻게 변화되는지 확인해야된다.
// result++를 했더니 계속 0의 값만 들어가는 현상이 생겨서 문제가 생겼었다.
namespace baekjoon
{
  class Mathematics_01004
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int T = Int32.Parse(sr.ReadLine());

      int x1, y1, x2, y2, cx, cy, cr, result, N;
      double distance1, distance2;
      bool check1, check2;

      string[] array1;
      string[] array2;
      for(int i = 0; i < T; i++)
      {

        array1 = sr.ReadLine().Split(' ');

        x1 = Int32.Parse(array1[0]);
        y1 = Int32.Parse(array1[1]);
        x2 = Int32.Parse(array1[2]);
        y2 = Int32.Parse(array1[3]);

        result = 0;

        N = Int32.Parse(sr.ReadLine());

        for(int j = 0; j < N; j++)
        {

          array2 = sr.ReadLine().Split(' ');

          cx = Int32.Parse(array2[0]);
          cy = Int32.Parse(array2[1]);
          cr = Int32.Parse(array2[2]);

          distance1 = Math.Pow(cx - x1, 2) + Math.Pow(cy - y1, 2);
          check1 = distance1 > Math.Pow(cr, 2) ? false : true;

          distance2 = Math.Pow(cx - x2, 2) + Math.Pow(cy - y2, 2);
          check2 = distance2 > Math.Pow(cr, 2) ? false : true;

          result = check1 != check2 ? result + 1 : result;
        }

        sw.WriteLine(result);
      }

      sr.Close();
      sw.Close();
    }
  }
}