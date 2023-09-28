using System;
using baekjoon;

class Program
{
  static void Main(string[] args)
  {
    Datastructures_01918 func = new Datastructures_01918();

    func.solve();
  }
}

// using System;

// namespace baekjoon
// {
//   class Mathematics_22015
//   {
//     public void solve()
//     {
//       string line = Console.ReadLine();

//       int A = Int32.Parse(line.Split(" ")[0]);
//       int B = Int32.Parse(line.Split(" ")[1]);
//       int C = Int32.Parse(line.Split(" ")[2]);

//       int max = Math.Max(Math.Max(A, B), C);

//       int sum = (max - A) + (max - B) + (max - C);

//       System.Console.WriteLine(sum);
//     }
//   }
// }