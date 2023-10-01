using System;

// Segfault 오류가 발생한 문제 
// 마지막 공백 라인 출력을 뺏고, sr을 사용하여 n을 입력받은 부분만 고쳐서 해결했지만 정확한 원인을 모르겠다.
namespace baekjoon
{
  class Implementation_10188
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int n = Int32.Parse(sr.ReadLine());

      string line = string.Empty;
      int width = 0;
      int height = 0;
      for(int i = 0; i < n; i++)
      {
        line = sr.ReadLine();
        
        width = Int32.Parse(line.Split(" ")[0]);
        height = Int32.Parse(line.Split(" ")[1]);

        for(int j = 0; j < height; j++)
        {
          for(int k = 0; k < width; k++)
          {
            sw.Write("X");
          }
          if(j != (height - 1)) sw.WriteLine();
        }

        if(i != (n - 1)) sw.WriteLine("\n");
      }

      sr.Close();
      sw.Close();
    }
  }
}