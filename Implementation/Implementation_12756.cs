using System;

namespace baekjoon
{
  class Implementation_12756
  {
    public void solve()
    {
      string player1 = Console.ReadLine();
      string player2 = Console.ReadLine();

      int p1_attack = Convert.ToInt32(player1.Split(' ')[0]);
      int p1_life = Convert.ToInt32(player1.Split(' ')[1]);
      int p2_attack = Convert.ToInt32(player2.Split(' ')[0]);
      int p2_life = Convert.ToInt32(player2.Split(' ')[1]);

      while(true)
      {
        if(p1_life <= 0 && p2_life > 0)
        {
          System.Console.WriteLine("PLAYER B");
          break;
        }
        else if(p1_life > 0 && p2_life <= 0)
        {
          System.Console.WriteLine("PLAYER A");
          break;
        }
        else if(p1_life <= 0 && p2_life <= 0)
        {
          System.Console.WriteLine("DRAW");
          break;
        }

        p1_life -= p2_attack;
        p2_life -= p1_attack;
      }
    }
  }
}