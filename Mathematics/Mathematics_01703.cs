using System;

namespace baekjoon
{
  class Mathematics_01703
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = string.Empty;

      int a = 0;
      int sf = 0;
      int cut = 0;
      long sum = 1;
      while(true)
      {
        line = sr.ReadLine();

        if(line.Equals("0")) 
        {
          sr.Close();
          sw.Close();
          break;
        }

        a = Int32.Parse(line.Split(' ')[0]);
        
        for(int i = 0; i < a; i++)
        {
          sf = Int32.Parse(line.Split(' ')[i * 2 + 1]);
          cut = Int32.Parse(line.Split(' ')[i * 2 + 2]);

          sum *= sf;
          sum -= cut;
        }

        sw.WriteLine(sum);
        sum = 1;
      }
    }
  }
}