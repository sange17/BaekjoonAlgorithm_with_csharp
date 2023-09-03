using System;

namespace baekjoon
{
  class Greedy_06550
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string str;
      char[] sArray;
      int[] sCountArray;
      string sStr;
      string tStr;
      int sLength = 0;
      int tLength = 0;
      int idx = 0;
      int count = 0;
      while(true)
      {
        if((str = sr.ReadLine()) == null || str.Length == 0){

          sr.Close();
          sw.Close();
          break;
        }

        sStr = str.Split(' ')[0];
        tStr = str.Split(' ')[1];
        sLength = sStr.Length;
        tLength = tStr.Length;
        sArray = sStr.ToCharArray();
        sCountArray = new int[sLength];
        idx = 0;
        count = 0;

        if(sLength > tLength) {
          sw.Write("No\n");
          continue;
        }

        for(int i = 0; i < tLength; i++){
          
          if(idx == sLength) break;

          if((sArray[idx] == tStr[i]) && (sCountArray[idx] == 0))
          {
            sCountArray[idx]++;
            idx++;
            count++;
          }
        }

        if(count == sLength)
        {
          sw.Write("Yes\n");
        }
        else
        {
          sw.Write("No\n");
        }
      }
    }
  }
}