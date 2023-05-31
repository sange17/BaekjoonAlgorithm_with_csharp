using System;
using System.Text;

namespace baekjoon
{
  class Datastructures_05608
  {
    public void solve()
    {
      int n = Convert.ToInt32(Console.ReadLine());
      Dictionary<String, String> dictionary = new Dictionary<string, string>();
      StringBuilder sb = new StringBuilder();

      String str;
      for(int i = 0; i < n; i++){
        
        str = Console.ReadLine();

        dictionary.Add(str.Split(' ')[0], str.Split(' ')[1]);
      }

      int m = Convert.ToInt32(Console.ReadLine());
      for(int i = 0; i < m; i++){

        str = Console.ReadLine();

        if(dictionary.ContainsKey(str)){

          sb.Append(dictionary[str]);
        }else{

          sb.Append(str);
        }
      }

      System.Console.WriteLine(sb);
    }
  }
}