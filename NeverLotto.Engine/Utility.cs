using System;
using System.Collections.Generic;
using System.Linq;

namespace NeverLotto.Engine
{
    public static class Utility
    {
        public static bool IsInteger(this decimal value)
        {
            return decimal.ToInt32(value) == value;
        }

        public static List<CountItem> CountNumbers(List<Result> results)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            foreach (var result in results)
            {
                foreach (var number in result.Numbers)
                {
                    if (dictionary.ContainsKey(number))
                        dictionary[number]++;
                    else
                        dictionary.Add(number, 1);
                }
            }

            for (int i = 0; i < 45; i++)
                if (dictionary.ContainsKey(i + 1) == false)
                    dictionary.Add(i + 1, 0);

            return dictionary.Select(x => new CountItem {Number = x.Key, Count = x.Value}).ToList();
        }

        public static List<List<int>> Split(List<int> list, int size)
        {
            List<List<int>> returnList = new List<List<int>>();

            if (list == null || list.Count == 0)
                return returnList;

            int i = 0;

            do
            {
                int count = Math.Min(size, list.Count - i);
                int[] subList = new int[count];
                list.CopyTo(i, subList, 0, count);
                returnList.Add(subList.ToList());
                i += count;
            } while (i < list.Count);

            return returnList;
        }
    }
}