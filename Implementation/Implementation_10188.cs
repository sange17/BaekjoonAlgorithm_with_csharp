using System;

namespace baekjoon
{
  class Implementation_10188
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int n = Int32.Parse(Console.ReadLine());

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
          sw.WriteLine();
          if(i != (n - 1)) sw.WriteLine();
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}