using System;
using System.Text;

namespace baekjoon
{
  class Mathematics_16504
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      int N = Int32.Parse(sr.ReadLine());
      String[] array;

      long sum = 0;
      for(int i = 0; i < N; i++)
      {
        
        array = sr.ReadLine().Split(" ");
        for(int j = 0; j < N; j++)
        {
          
          sum += long.Parse(array[j]);
        }
      }

      sw.WriteLine(sum);

      sr.Close();
      sw.Close();
    }
  }
}