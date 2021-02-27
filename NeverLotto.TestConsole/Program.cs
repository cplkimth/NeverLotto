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
            var results = ResultDownloader.Instance.Download();

            // Console.WriteLine(results.Count);
        }

        private static void OnAdded(decimal percent, List<Result> results)
        {
            if (percent.IsInteger())
                Console.WriteLine("{0} % : {1:N0} : {2:N0}", percent, results.Count, Process.GetCurrentProcess().WorkingSet64 / 1024);
        }
    }
}