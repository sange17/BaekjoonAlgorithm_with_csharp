using System;

namespace baekjoon
{
  class String_18409
  {
    public void solve()
    {
      int N = Int32.Parse(Console.ReadLine());
      string str = Console.ReadLine();

      int count = 0;
      for(int i = 0; i < N; i++)
      {

        switch(str[i])
        {
          case 'a':
            count++;
            break;
          case 'e':
            count++;
            break;
          case 'i':
            count++;
            break;
          case 'o':
            count++;
            break;
          case 'u':
            count++;
            break;
        }
      }

      System.Console.WriteLine(count);
    }
  }
}