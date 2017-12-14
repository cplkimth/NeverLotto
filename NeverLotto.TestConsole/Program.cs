#region
using System;
using System.Collections.Generic;
using System.Diagnostics;
using NeverLotto.Engine;

#endregion

namespace NeverLotto.TestConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int count = 1;
            const int size = 1;

            for (int i = 0; i <= count / size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int value = (i * size + j);

                    if (value == count)
                        break;

                    Console.WriteLine(value);
                }
            }
            return;


            var results = AnalyzerHelper.Instance.Generate(new List<ResultCriteria>(), 10000, 100000000, new List<int>(), new List<int>(), new List<int>(), null, OnAdded);
        }

        private static void OnAdded(decimal percent, List<Result> results)
        {
            if (percent.IsInteger())
                Console.WriteLine("{0} % : {1:N0} : {2:N0}", percent, results.Count, Process.GetCurrentProcess().WorkingSet64 / 1024);
        }
    }
}