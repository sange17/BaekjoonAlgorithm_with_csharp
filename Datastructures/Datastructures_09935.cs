using System;
using System.Text;

namespace baekjoon
{
  class Datastructures_09935
  {
    static string Word, Bomb;
    static int sbLength, wordLength, bombLength;

    static bool CanExplode(StringBuilder sb)
    {
      sbLength = sb.Length;
      bombLength = Bomb.Length;

      if(sbLength < bombLength) return false;
      if(sb[sbLength - 1] != Bomb[bombLength - 1]) return false;

      for(int i = 0; i < bombLength; ++i)
      {
        if(sb[sbLength - 1 - i] != Bomb[bombLength - 1 - i]) return false;
      }

      return true;
    }

    public void solve()
    {
      Word = Console.ReadLine();
      Bomb = Console.ReadLine();
      StringBuilder sb = new StringBuilder();

      wordLength = Word.Length;
      for(int i = 0; i < wordLength; ++i)
      {
        sb.Append(Word[i]);

        if(CanExplode(sb))
          sb.Remove(sbLength - bombLength, bombLength);
      }

      if(sb.ToString().Length == 0)
      {
        System.Console.WriteLine("FRULA");
      }
      else
      {
        System.Console.WriteLine(sb.ToString());
      }
    }
  }
}