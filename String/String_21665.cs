using System;

namespace baekjoon
{
  class String_21665
  {
    public void solve()
    {
      string line = Console.ReadLine();

      int x = Int32.Parse(line.Split(" ")[0]);
      int y = Int32.Parse(line.Split(" ")[1]);
      int count = 0;
      char[,] array = new char[x,y]; 

      for(int i = 0; i < x; i++)
      {
        line = Console.ReadLine();
        for(int j = 0; j < y; j++)
        {
          array[i,j] = line[j];
        }
      }

      Console.ReadLine();

      for(int i = 0; i < x; i++)
      {
        line = Console.ReadLine();
        for(int j = 0; j < y; j++)
        {
          if(array[i,j] == line[j]) count++;
        }
      }

      System.Console.WriteLine(count);
    }
  }
}