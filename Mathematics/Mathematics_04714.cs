using System;

namespace baekjoon
{
  class Mathematics_04714
  {
    public void solve()
    {
      StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
      StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput()));
      double weight = 0.0;

      while(true)
      {

        weight = double.Parse(sr.ReadLine());

        if(weight < 0.0) 
        {
          sr.Close();
          sw.Close();
          break;
        }

        sw.WriteLine("Objects weighing " + string.Format("{0:0.#0}", weight) + " on Earth will weigh " + string.Format("{0:0.#0}", 0.167 * weight) + " on the moon.");
      }
    }
  }
}