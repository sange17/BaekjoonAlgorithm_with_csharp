using System;

namespace baekjoon
{
  class Greedy_16755
  {
    public void solve()
    {
      string str = Console.ReadLine();
      int strLength = str.Length;
      string word = "HONI";

      int alphaCnt = 0;
      int resultCnt = 0;
      int idx = 0;
      for(int i = 0; i < strLength; i++)
      {
        if(word[idx] == str[i])
        {
          idx++;

          if(idx == 4)
          {
            resultCnt++;
            idx = 0;
          }
        }
      }

      System.Console.WriteLine(resultCnt);
    }
  }
}