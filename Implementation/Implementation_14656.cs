using System;

namespace baekjoon
{
  class Implementation_14656
  {
    public void solve()
    {
      int n = Int16.Parse(Console.ReadLine());

      String str = Console.ReadLine();

      string[] array = str.Split(' ');
      int count = 0;
      for(int i = 1; i <= n; i++){
        
        // 주의사항 참고:
        // Split함수는 매번 호출될 때마다 그 결과를 새로운 배열로 다시 할당합니다.  이 경우 for 문에서 Split 함수를 매번 다시 호출하고 있기 때문에, 
        // 최악의 경우 반복문의 매 스텝마다 100만개짜리 배열이 다시 생성이 될 것이고, 그게 누적이 돼서 메모리 초과가 발생하는 것 같습니다.
        // 메모리 초과가 아니더라도, Split 함수를 매번 다시 호출하는 건 결과적으로 시간 복잡도가 O(N^2)이 되기 때문에, 시간 상으로도 통과할 수 없는 방법입니다.
        if(array[i - 1].Equals(i.ToString())) continue;

        count++;
      }

      System.Console.WriteLine(count);
    }
  }
}