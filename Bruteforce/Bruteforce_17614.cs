using System;
using System.Text;

namespace baekjoon
{
  class Bruteforce_17614
  {
    public void solve()
    {
      StringBuilder sb = new StringBuilder();

      int n = Int32.Parse(Console.ReadLine());
      

      int count = 0;
      for(int i = 1; i <= n; i++)
      {
        sb.Append(i.ToString());
      }

      string str = sb.ToString();
      long strLength = str.Length;
      for(int i = 0; i < strLength; i++)
      {
        if(str[i] == '3' || str[i] == '6' || str[i] == '9') count++;
      }

      System.Console.WriteLine(count);
    }
  }
}