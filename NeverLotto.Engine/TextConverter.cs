#region
using System;

#endregion

namespace NeverLotto.Engine
{
    public class TextConverter
    {
        #region singleton
        private static TextConverter _instance;

        public static TextConverter Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TextConverter();
                return _instance;
            }
        }

        private TextConverter()
        {
        }
        #endregion

        public string this[Rate rate]
        {
            get
            {
                switch (rate)
                {
                    case Rate.ZeroSix:
                        return "0:6";
                    case Rate.OneFive:
                        return "1:5";
                    case Rate.TwoFour:
                        return "2:4";
                    case Rate.ThreeThree:
                        return "3:3";
                    case Rate.FourTwo:
                        return "4:2";
                    case Rate.FiveOne:
                        return "5:1";
                    case Rate.SixZero:
                        return "6:0";
                }

                throw new NotImplementedException("TextConverter.this");
            }
        }

        public string GetSeriesCountText(int seriesCount)
        {
            switch (seriesCount)
            {
                case 0:
                    return "없음";
                case 1:
                    return "1 쌍";
                case 2:
                    return "2 쌍";
                case 3:
                    return "3 쌍";
            }

            throw new NotImplementedException("TextConverter.this");
        }

        public string GetAnalysisTypeText(AnalysisType analysisType)
        {
            switch (analysisType)
            {
                case AnalysisType.TotalSum:
                    return "총합";
                case AnalysisType.LowSum:
                    return "123합";
                case AnalysisType.HighSum:
                    return "456합";
                case AnalysisType.FirstDigitSum:
                    return "첫수합";
                case AnalysisType.LastDigitSum:
                    return "끝수합";
                case AnalysisType.EdgeSum:
                    return "간격합";
                case AnalysisType.EdgeSubtraction:
                    return "간격차";
                case AnalysisType.LowHighRate:
                    return "저고 비율";
                case AnalysisType.OddEvenRate:
                    return "홀짝 비율";
                case AnalysisType.SeriesCount:
                    return "연번 갯수";
                case AnalysisType.Number:
                    return "출현 번호";
                default:
                    throw new NotImplementedException("TextConverter.GetAnalysisTypeText");
            }
        }
    }
}