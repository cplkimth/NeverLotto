#region
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

#endregion

namespace NeverLotto.Engine
{
    public class ResultParser
    {
        #region singleton
        private static ResultParser _instance;

        public static ResultParser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ResultParser();
                return _instance;
            }
        }

        private ResultParser()
        {
        }
        #endregion

        public Result[] GenerateFull()
        {
            Result[] list = new Result[8303765625];
            long index = 0;

            for (int i = 1; i <= 45; i++)
            {
                for (int j = 1; j <= 45; j++)
                {
                    if (j == i)
                        continue;

                    for (int k = 1; k <= 45; k++)
                    {
                        if (k == j || k == i)
                            continue;

                        for (int l = 1; l <= 45; l++)
                        {
                            if (l == k || l == j || l == i)
                                continue;

                            for (int m = 1; m <= 45; m++)
                            {
                                if (m == l || m == k || m == j || m == i)
                                    continue;

                                for (int n = 1; n <= 45; n++)
                                {
                                    if (n == m || n == l || n == k || n == j || n == i)
                                        continue;
    
                                    Result result = new Result(i, j, k, l, m, n);
                                    list[index++] = result;
                                }
                            }
                        }
                    }
                }
            }

            var array = new Result[list.LongLength];
            Array.Copy(list, 0, array, 0, index);

            return array;
        }

        public List<Result> Parse(string[] lines)
        {
            List<Result> results = new List<Result>(lines.Length);

            foreach (var line in lines)
            {
                var tokens = line.Split(new[] {'\t'}, StringSplitOptions.RemoveEmptyEntries);
                var parsedTokens = Array.ConvertAll(tokens, x => int.Parse(x));

                Result result = new Result(parsedTokens[0], parsedTokens.Skip(1).Take(6), parsedTokens[7]);
                results.Add(result);
            }

            return results;
        }
    }
}