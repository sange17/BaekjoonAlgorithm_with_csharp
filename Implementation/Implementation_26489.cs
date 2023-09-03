using System;

namespace baekjoon
{
  class Implementation_26489
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string str;
      int count = 0;

      while(true)
      {
        if((str = sr.ReadLine()) == null || str.Length == 0)
        {
          sw.Write(count);
          sr.Close();
          sw.Close();
          break;
        }

        if(str.Equals("gum gum for jay jay")) count++;
      }
    }
  }
}