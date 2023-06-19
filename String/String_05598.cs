using System;
using System.Text;

namespace baekjoon
{
  class String_05598
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      String str = sr.ReadLine();
      int strLength = str.Length;

      for(int i = 0; i < strLength; i++){

        if(90 - (90 - str[i]) - 3 < 65){
          sw.Write((char)(88 + (str[i] - 65)));
        }else{
          sw.Write((char)(90 - (90 - str[i]) - 3));
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}