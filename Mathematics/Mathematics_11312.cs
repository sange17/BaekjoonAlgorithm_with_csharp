using System;

// 길이가 2, 3... 배가 늘어나면 넓이는 2^2, 3^3...로 눌어난다.
// 길이비와 넓이비를 사용한 문제
// 정수형 범위 주의하기
namespace baekjoon
{
  class Mathematics_11312
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      int T = Int32.Parse(sr.ReadLine());

      string line = string.Empty;
      long A = 0;
      long B = 0;
      for(int i = 0; i < T; i++)
      {
        line = sr.ReadLine();

        A = long.Parse(line.Split(' ')[0]);
        B = long.Parse(line.Split(' ')[1]);

        sw.WriteLine((A / B) * (A / B));
      }

      sr.Close();
      sw.Close();
    }
  }
}