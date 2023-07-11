using System;

namespace baekjoon
{
  class Mathematics_06825
  {
    public void solve()
    {
      double weight = double.Parse(Console.ReadLine());
      double height = double.Parse(Console.ReadLine());

      double bmi = weight / (height * height);

      if(bmi > 25)
      {
        System.Console.WriteLine("Overweight");
      }
      else if(bmi >= 18.5 && bmi <= 25)
      {
        System.Console.WriteLine("Normal weight");
      }else if(bmi < 18.5)
      {
        System.Console.WriteLine("Underweight");
      }
    }
  }
}