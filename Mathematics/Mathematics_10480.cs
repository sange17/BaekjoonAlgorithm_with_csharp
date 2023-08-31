using System;

namespace baekjoon
{
  class Mathematics_10480
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      int n = Int32.Parse(sr.ReadLine());

      int num = 0;
      for(int i = 0; i < n; i++)
      {
        num = Int32.Parse(sr.ReadLine());

        if(num % 2 == 0)
        {
          sw.WriteLine(num + " is even");
        }
        else
        {
          sw.WriteLine(num + " is odd");
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}