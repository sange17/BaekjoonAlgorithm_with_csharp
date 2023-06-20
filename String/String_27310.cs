using System;

namespace baekjoon
{
  class String_27310
  {
    public void solve()
    {
      string str = Console.ReadLine();
      int strLength = str.Length;

      int colonCnt = 0;
      int underbarCnt = 0;
      for(int i = 0; i < strLength; i++){

        if(str[i] == ':') colonCnt++;
        if(str[i] == '_') underbarCnt++;
      }
      
      System.Console.WriteLine(strLength + colonCnt + underbarCnt * 5);
    }
  }
}

