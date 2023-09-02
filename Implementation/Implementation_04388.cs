using System;

namespace baekjoon
{
  class Implementation_04388
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = string.Empty;
      char[] arrayA;
      char[] arrayB;
      while(true)
      {
        line = sr.ReadLine();

        if(line.Equals("0 0")) break;

        arrayA = line.Split(" ")[0].PadLeft(10, '0').ToArray();
        arrayB = line.Split(" ")[1].PadLeft(10, '0').ToArray();

        int count = 0;
        Boolean isCheck = false;
        int sum = 0;
        for(int i = 9; i >= 0; i--)
        {
          if(isCheck) 
          {
            sum = arrayA[i] - 48 + arrayB[i] - 48 + 1;
            isCheck = false;
          }
          else sum = arrayA[i] - 48 + arrayB[i] - 48;

          if(sum > 9)
          {
            count++;
            isCheck = true;
          }
        }

        sw.WriteLine(count);
      }

      sr.Close();
      sw.Close();
    }
  }
}