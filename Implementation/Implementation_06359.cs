using System;
using System.Text;

namespace baekjoon
{
  class Implementation_06359
  {
    public void solve()
    {
      int T = Int16.Parse(Console.ReadLine());
      StringBuilder sb = new StringBuilder();
      int n = 0;
      Boolean[] array;
      
      for(int i = 0; i < T; i++){

        n = Int16.Parse(Console.ReadLine());

        array = new Boolean[n];

        if(array.Length == 0) {
          System.Console.WriteLine(0);
        }

        for(int j = 1; j <= n; j++){

          for(int k = j; k <= n; k += j){

            if(array[k - 1]){

              array[k - 1] = false;
            }else{

              array[k - 1] = true;
            }
          }
        }
        
        int count = 0;
        for(int j = 0; j < n; j++){

          if(array[j]){
            count++;
          }
        }

        if(i == T - 1){
          sb.Append(count);
        }else{
          sb.Append(count + "\n");
        }
      }

      System.Console.WriteLine(sb);
    }
  }
}