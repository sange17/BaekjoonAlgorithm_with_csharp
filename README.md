# BaekjoonAlgorithm_with_csharp
Studying algorithm with c#🔥

## 목차
1. [C# 빠른 입출력 예제](#C# 빠른 입출력 예제)

### C# 빠른 입출력 예제
```
StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
String str = sr.ReadLine();

int N = Int32.Parse(str.Split(' ')[0]);
int M = Int32.Parse(str.Split(' ')[1]);

for(int i = 1; i <= N * M; i++){

  if(i % M == 0) 
  {
    sw.Write(i + "\n");
  }
  else
  {
    sw.Write(i + " ");
  }
}

// Close 메소드에는 Flush가 포함되어있다.
sr.Close();   
sw.Close();
```