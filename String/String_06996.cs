using System;
using System.Text;

namespace baekjoon
{
  class String_06996
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      String str;

      int T = Int32.Parse(sr.ReadLine());

      char[] array1;
      char[] array2;
      string str1;
      string str2;
      int arrLength = 0;
      Boolean flag;
      for(int i = 0; i < T; i++)
      {
        
        str = sr.ReadLine();

        str1 = str.Split(" ")[0];
        str2 = str.Split(" ")[1];
        array1 = str1.ToCharArray();
        array2 = str2.ToCharArray();
        arrLength = array1.Length;
        flag = false;

        Array.Sort(array1);
        Array.Sort(array2);

        if(array1.Length == array2.Length)
        {

          for(int j = 0; j < arrLength; j++)
          {

            if(array1[j] == array2[j]) continue;
            else flag = true;

            if(flag){

              sw.WriteLine(str1 + " & " + str2 + " are NOT anagrams.");
              break;
            }
          }

          if(!flag) sw.WriteLine(str1 + " & " + str2 + " are anagrams.");
        }else
        {

          sw.WriteLine(str1 + " & " + str2 + " are NOT anagrams.");
        }
      }

      sr.Close();
      sw.Close();
    }
  }
}