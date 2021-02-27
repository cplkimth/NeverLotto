using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using OfficeOpenXml;

namespace NeverLotto.Engine
{
    public class ResultDownloader
    {
        #region singleton
        private static ResultDownloader _instance;

        public static ResultDownloader Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ResultDownloader();
                return _instance;
            }
        }

        private ResultDownloader()
        {
        }
        #endregion

        public List<Result> Download(int fromNo = 1, int toNo = 9999)
        {
            string url = $"https://dhlottery.co.kr/gameResult.do?method=allWinExel&nowPage=1&drwNoStart={fromNo}&drwNoEnd={toNo}";

            WebClient web = new WebClient();
            var html = web.DownloadString(url);
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);

            var trs = document.DocumentNode.SelectNodes("//tr").Skip(3).ToList();

            List<Result> results = new List<Result>(trs.Count);
            foreach (var tr in trs)
            {
                var tds = tr.SelectNodes("td");
                int padding = tds.Count == 20 ? 0 : -1;

                int no = int.Parse(tds[1 + padding].InnerText);
                int bonus = int.Parse(tds[19 + padding].InnerText);
                int[] numbers = new int[6];
                for (int i = 0; i < numbers.Length; i++)
                    numbers[i] = int.Parse(tds[13 + i + padding].InnerText);

                Result result = new Result(no, numbers, bonus);
                results.Add(result);
            }

            return results;
        }
    }
}
