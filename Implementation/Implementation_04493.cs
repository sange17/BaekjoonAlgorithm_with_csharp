using System;
using System.Text;

namespace baekjoon
{
  class Implementation_04493
  {
    public void solve()
    {
      int T = Int32.Parse(Console.ReadLine());
      StringBuilder sb = new StringBuilder();

      int n = 0;
      int player1 = 0;
      int player2 = 0;
      for(int i = 0; i < T; i++){

        n = Int32.Parse(Console.ReadLine());
        player1 = 0;
        player2 = 0;

        for(int j = 0; j < n; j++){

          string str = Console.ReadLine();

          if(str.Split(' ')[0].Equals(str.Split(' ')[1])){

            continue;
          }else if(str.Split(' ')[0].Equals("P") && str.Split(' ')[1].Equals("R")){
            
            player1++;
          }else if(str.Split(' ')[0].Equals("R") && str.Split(' ')[1].Equals("S")){
            
            player1++;
          }else if(str.Split(' ')[0].Equals("S") && str.Split(' ')[1].Equals("P")){
            
            player1++;
          }else if(str.Split(' ')[0].Equals("R") && str.Split(' ')[1].Equals("P")){
            
            player2++;
          }else if(str.Split(' ')[0].Equals("S") && str.Split(' ')[1].Equals("R")){
            
            player2++;
          }else if(str.Split(' ')[0].Equals("P") && str.Split(' ')[1].Equals("S")){
            
            player2++;
          }
        }
        
        if(player1 > player2){

          sb.Append("Player 1\n");
        }else if(player1 < player2){

          sb.Append("Player 2\n");
        }else{

          sb.Append("TIE\n");
        }
      }

      System.Console.WriteLine(sb);
    }
  }
}