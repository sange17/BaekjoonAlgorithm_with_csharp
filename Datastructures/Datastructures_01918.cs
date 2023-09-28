using System;

namespace baekjoon
{
  class Datastructures_01918
  {
    public void solve()
    {
      string line = Console.ReadLine();
      int lineLength = line.Length;
      Stack<char> stack = new Stack<char>();

      for(int i = 0; i < lineLength; i++)
      {
        if(line[i] >= 'A' && line[i] <= 'Z')
        {
          System.Console.Write(line[i]);
        }
        else
        {
          if(line[i] == '(')
          {
            stack.Push(line[i]);
          }
          else if(line[i] == '*' || line[i] == '/')
          {
            while(stack.Count > 0 && (stack.Peek() == '*' || stack.Peek() == '/'))
            {
              System.Console.Write(stack.Peek());
              stack.Pop();
            }
            stack.Push(line[i]);
          }
          else if(line[i] == '+' || line[i] == '-')
          {
            while(stack.Count > 0 && stack.Peek() != '(')
            {
              System.Console.Write(stack.Peek());
              stack.Pop();
            }
            stack.Push(line[i]);
          }
          else if(line[i] == ')')
          {
            while(stack.Count > 0 && stack.Peek() != '(')
            {
              System.Console.Write(stack.Peek());
              stack.Pop();
            }
            stack.Pop();
          }
        }
      }

      while(stack.Count > 0)
      {
        System.Console.Write(stack.Peek());
        stack.Pop();
      }
    }
  }
}