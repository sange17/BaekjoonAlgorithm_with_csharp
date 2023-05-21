using System;

namespace baekjoon
{
  class Implementation_13698
  {
    public void solve()
    {
      String str = Console.ReadLine();
      int strLength = str.Length;

      int[] array = new int[4];
      array[0] = 1;
      array[3] = 2;

      char ch;
      int temp = 0;
      for(int i = 0; i < strLength; i++){

        ch = str[i];

        switch(ch)
        {
          case 'A':
            temp = array[0];
            array[0] = array[1];
            array[1] = temp;
            break;
          case 'B':
            temp = array[0];
            array[0] = array[2];
            array[2] = temp;
            break;
          case 'C':
            temp = array[0];
            array[0] = array[3];
            array[3] = temp;
            break;
          case 'D':
            temp = array[1];
            array[1] = array[2];
            array[2] = temp;
            break;
          case 'E':
            temp = array[1];
            array[1] = array[3];
            array[3] = temp;
            break;
          case 'F':
            temp = array[2];
            array[2] = array[3];
            array[3] = temp;
            break;
        }

      }

      int pos1 = 0;
      int pos2 = 0;
      for(int i = 0; i < 4; i++){
        if(array[i] == 1) pos1 = i + 1;
        if(array[i] == 2) pos2 = i + 1;
      }

      System.Console.WriteLine(pos1);
      System.Console.WriteLine(pos2);
    }
  }
}