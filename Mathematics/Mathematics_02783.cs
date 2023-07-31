using System;

namespace baekjoon
{
  class Mathematics_02783
  {
    public void solve()
    {
      string line = Console.ReadLine();

      double X = double.Parse(line.Split(' ')[0]);
      double Y = double.Parse(line.Split(' ')[1]);
      double price = 1000.0 / Y * X;

      double xi = 0;
      double yi = 0;
      double priceI = 0;
      double min = price;
      int N = Int32.Parse(Console.ReadLine());

      for(int i = 0; i < N; i++)
      {
        line = Console.ReadLine();

        xi = double.Parse(line.Split(' ')[0]);
        yi = double.Parse(line.Split(' ')[1]);
        priceI = 1000 / yi * xi;

        if(priceI < min)
        {
          min = priceI;
        }
      }

      System.Console.WriteLine(String.Format("{0:0.00}", min));
    }
  }
}