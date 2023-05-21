using System;

namespace baekjoon
{
  class Implementation_01333
  {
    public void solve()
    {
      String str = Console.ReadLine();
      int N = Int16.Parse(str.Split(' ')[0]);
      int L = Int16.Parse(str.Split(' ')[1]);
      int D = Int16.Parse(str.Split(' ')[2]);

      int sum = 0;
      Boolean flag = false;
      int result = 0;
      int idx = 1;

      // 노래 수 만큼 반복
      for(int i = 1; i <= N; i++){

        sum += L;     // 한 곡을 들은 시간 더하기

        // 전화벨을 들을 수 있는 시간까지 반복
        while(N * L / D + 1 >= idx){

          // 전화벨이 울리는 시간이 노래가 끝난 시간 이상이고 무음 구간이 끝난 시간 미만이면
          if(sum <= (D * idx) && (D * idx) < (sum + 5)){
            
            result = D * idx;   // result에 전화벨이 울린 시간을 저장
            flag = true;        // 전화벨이 들렸을 때 모든 곡을 듣기 전에 반복문 나가기 위해 필요
          }

          idx++;
        }
        
        // 모든 곡을 듣기 전에 반복 나가기
        if(flag) break;
        
        // 무음 구간 시간 더하기
        sum += 5;
      }

      if(flag){

        System.Console.WriteLine(result);
      }
      else{
        System.Console.WriteLine(sum + " " + D);
        System.Console.WriteLine(sum % D == 0 ? D * (sum / D) : D * (sum / D + 1));
      }
    }
  }
}