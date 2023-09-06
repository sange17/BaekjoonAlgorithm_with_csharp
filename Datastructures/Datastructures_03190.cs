using System;
using System.Data;
using System.Drawing;

namespace baekjoon
{
  class Datastructures_03190
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      
      int N = Int32.Parse(sr.ReadLine());

      int[,] board = new int[N, N];

      int K = Int32.Parse(sr.ReadLine());

      ApplePoint[] applePoint= new ApplePoint[K];

      string line = string.Empty;
      int appleX = 0;
      int appleY = 0;
      for(int i = 0; i < K; i++)
      {
        appleX = Int32.Parse(line.Split(" ")[0]) - 1;
        appleY = Int32.Parse(line.Split(" ")[1]) - 1;

        board[appleX,appleY] = 1;
        applePoint[i] = new ApplePoint(appleX, appleY);
      }

      int L = Int32.Parse(sr.ReadLine());
      SnakePoint[] snakeDirect = new SnakePoint[L];
      int len = 0;
      string dir = string.Empty;
      for(int i = 0; i < L; i++)
      {
        line = sr.ReadLine();
        len = Int32.Parse(line.Split(" ")[0]);
        dir = line.Split(" ")[1];

        snakeDirect[i] = new SnakePoint(len, dir);
      }

      
    }
  }
}
class ApplePoint
{
  public int x;
  public int y;
  public ApplePoint(int x, int y)
  {
    this.x = x;
    this.y = y;
  }
}

class SnakePoint
{
  public int x;
  public string y;
  public SnakePoint(int x, string y)
  {
    this.x = x;
    this.y = y;
  }
}