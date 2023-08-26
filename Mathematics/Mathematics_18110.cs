using System;

// C#에서의 Round 반올림은 1.5인 경우는 2, 2.5인 경우는 2이다.
// 이는 c#의 기본 round 함수가 파이썬과 같이 오사오입으로 4 이하인 수는 버리고 6 이상인 수는 올리되
// 5인 경우 5의 앞자리가 짝수인 경우 버리고 홀수인 경우 올려 짝수로 만들기 때문이라고 생각한다. 실제로 값을 출력했보아도 그렇다. 주의할 것
namespace baekjoon
{
  class Mathematics_18110
  {
    public void solve()
    {
      double n = double.Parse(Console.ReadLine());
      double except = Math.Round(n * 0.15, MidpointRounding.AwayFromZero);
      double notExcept = n - except * 2;
      double sum = 0;
      double avg = 0;

      int[] array = new int[(int)n];

      if(n == 0)
      {
        System.Console.WriteLine(0);
      }
      else
      {
        for(int i = 0; i < n; i++) 
        {
          array[i] = Int32.Parse(Console.ReadLine());
        }

        Array.Sort(array);

        for(int i = (int)except; i < n - (int)except; i++)
        {
          sum += (double)array[i];
        }

        avg = Math.Round(sum / notExcept, MidpointRounding.AwayFromZero);
        System.Console.WriteLine(avg);
      }
    }
  }
}