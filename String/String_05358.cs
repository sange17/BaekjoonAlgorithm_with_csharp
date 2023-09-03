using System;

namespace baekjoon
{
  class String_05358
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      string line = string.Empty;

      while(true)
      {
        if((line = sr.ReadLine()) == null || line.Length == 0)
        {
          sr.Close();
          sw.Close();
          break;
        }

        for(int i = 0; i < line.Length; i++)
        {
          if(line[i] == 'e') sw.Write('i');
          else if(line[i] == 'i') sw.Write('e');
          else if(line[i] == 'E') sw.Write('I');
          else if(line[i] == 'I') sw.Write('E');
          else sw.Write(line[i]);
        }

        sw.WriteLine();
      }
    }
  }
}