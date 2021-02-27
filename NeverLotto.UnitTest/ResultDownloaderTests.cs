using Microsoft.VisualStudio.TestTools.UnitTesting;
using NeverLotto.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeverLotto.Engine.Tests
{
    [TestClass()]
    public class ResultDownloaderTests
    {
        [TestMethod()]
        public void DownloadTest()
        {
            var results = ResultDownloader.Instance.Download();
            var no952 = results.FirstOrDefault(x => x.No == 952);
            var no1 = results.LastOrDefault();

            Assert.IsNotNull(no952);
            Assert.IsNotNull(no1);

            Assert.AreEqual(4, no952.Number1);
            Assert.AreEqual(12, no952.Number2);
            Assert.AreEqual(22, no952.Number3);
            Assert.AreEqual(24, no952.Number4);
            Assert.AreEqual(33, no952.Number5);
            Assert.AreEqual(41, no952.Number6);
            Assert.AreEqual(38, no952.BonusNumber);

            Assert.AreEqual(10, no1.Number1);
            Assert.AreEqual(23, no1.Number2);
            Assert.AreEqual(29, no1.Number3);
            Assert.AreEqual(33, no1.Number4);
            Assert.AreEqual(37, no1.Number5);
            Assert.AreEqual(40, no1.Number6);
            Assert.AreEqual(16, no1.BonusNumber);
        }
    }
}