using System;

namespace baekjoon
{
  class Bruteforce_20529
  {
    static int get_distance(string a, string b)
    {
      int distance = 0;
      for(int i = 0; i < 4; i++)
      {
        if(a[i] != b[i])
        {
          distance += 1;
        }
      }
      return distance;
    }
    
    public void solve()
    {
      
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));

      int T = Int32.Parse(sr.ReadLine());

      int N = 0;
      string tmp = string.Empty;
      List<string> list = new List<string>();;
      int min_distance = 0;

      for(int t = 0; t < T; t++)
      {
        list = new List<string>();
        N = Int32.Parse(sr.ReadLine());

        if(N > 32)
        {
          sw.WriteLine(0);
          tmp = sr.ReadLine();
        }
        else
        {
          tmp = sr.ReadLine();
          for(int i = 0; i < N; i++)
          {
            list.Add(tmp.Split(" ")[i]);
          }

          min_distance = 100;
          for(int i = 0; i < N - 2; i++)
          {
            for(int j = i + 1; j < N - 1; j++)
            {
              for(int k = j + 1; k < N; k++)
              {
                min_distance = Math.Min(min_distance, 
                  get_distance(list[i], list[j]) 
                + get_distance(list[j], list[k]) 
                + get_distance(list[i], list[k]));
              }
            }
          }
          sw.WriteLine(min_distance);
        }
      }
      

      sr.Close();
      sw.Close();
    }
  }
}