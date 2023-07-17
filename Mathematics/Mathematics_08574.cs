using System;

namespace baekjoon
{
  class Mathematics_08574
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = sr.ReadLine();

      int n = Int32.Parse(line.Split(' ')[0]);
      int k = Int32.Parse(line.Split(' ')[1]);
      int x = Int32.Parse(line.Split(' ')[2]);
      int y = Int32.Parse(line.Split(' ')[3]);

      int x1 = 0;
      int y1 = 0;
      int distX = 0;
      int distY = 0;
      int count = 0;
      for(int i = 0; i < n; i++)
      {
        line = sr.ReadLine();

        x1 = Int32.Parse(line.Split(' ')[0]);
        y1 = Int32.Parse(line.Split(' ')[1]);

        distX = Math.Abs(x - x1);
        distY = Math.Abs(y - y1);

        if(distX * distX + distY * distY > k * k)
        {
          count++;
        }
      }

      sw.Write(count);

      sr.Close();
      sw.Close();
    }
  }
}