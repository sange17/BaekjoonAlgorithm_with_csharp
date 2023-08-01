using System;

namespace baekjoon
{
  class Mathematics_03029
  {
    public void solve()
    {
      string time1 = Console.ReadLine();
      string time2 = Console.ReadLine();
      int secondTime1 = 0;
      int secondTime2 = 0;
      int resultSecondTime = 0;
      string resultTime = string.Empty;

      int hh1 = Int32.Parse(time1.Split(':')[0]);
      int mm1 = Int32.Parse(time1.Split(':')[1]);
      int ss1 = Int32.Parse(time1.Split(':')[2]);
      int hh2 = Int32.Parse(time2.Split(':')[0]);
      int mm2 = Int32.Parse(time2.Split(':')[1]);
      int ss2 = Int32.Parse(time2.Split(':')[2]);
      int resultHH = 0;
      int resultMM = 0;
      int resultSS = 0;

      secondTime1 = hh1 * 3600 + mm1 * 60 + ss1;
      secondTime2 = hh2 * 3600 + mm2 * 60 + ss2;

      if(secondTime1 > secondTime2)
      {
        resultSecondTime = 86400 - (secondTime1 - secondTime2);
      }
      else if(secondTime1 < secondTime2)
      {   
        resultSecondTime = secondTime2 - secondTime1;
      }
      else if(secondTime1 == secondTime2)
      {
        resultSecondTime = 86400;
      }

      int temp = 0;
      resultHH = resultSecondTime / 3600;
      temp = resultSecondTime % 3600;
      resultMM = temp / 60;
      temp = temp % 60;
      resultSS = temp;

      System.Console.WriteLine(string.Format("{0:00}", resultHH)
                      + ":" + string.Format("{0:00}", resultMM)
                      + ":" + string.Format("{0:00}", resultSS));
    }
  }
}