using System;

namespace baekjoon
{
    class Mathematics_28701
    {
        public void solve()
        {
            int a = Int32.Parse(Console.ReadLine());
       
            int sum1 = 0;
            int sum2 = 0;
            for(int i = 1; i <= a; i++)
            {
                sum1 += i;
                sum2 += i * i * i;
            }
            
            System.Console.WriteLine(sum1);
            System.Console.WriteLine(sum2);
            System.Console.WriteLine(sum2);
        }
    }
}