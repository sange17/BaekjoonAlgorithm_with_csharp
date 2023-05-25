using System;
using System.Text;

namespace baekjoon
{
  class Datastructures_09056
  {
    public void solve()
    {
      int T = Int16.Parse(Console.ReadLine());
      StringBuilder sb = new StringBuilder();
      
      String inStr;
      String str1;
      String str2;
      int str1Length = 0;
      int str2Length = 0;
      Boolean flag1;
      Boolean flag2;
      Dictionary<char, int> dictionary;
      for(int i = 0; i < T; i++){

        inStr = Console.ReadLine();
        str1 = inStr.Split(' ')[0];
        str2 = inStr.Split(' ')[1];
        str1Length = str1.Length;
        str2Length = str2.Length;
        flag1 = true;
        flag2 = true;
        for(int j = 0; j < str2Length; j++){

          if(str1.Contains(str2[j])){
            
            continue;
          }else {

            flag1 = false;
            break;
          }
        }

         for(int j = 0; j < str1Length; j++){

          if(str2.Contains(str1[j])){
            
            continue;
          }else {

            flag2 = false;
            break;
          }
        }

        if(flag1 && flag2) sb.Append("YES\n");
        else sb.Append("NO\n");

      }
      System.Console.WriteLine(sb);
    }
  }
}