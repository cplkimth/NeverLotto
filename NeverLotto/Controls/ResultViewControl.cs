#region
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using NeverLotto.Engine;
using OfficeOpenXml;

#endregion

namespace NeverLotto.Controls
{
    public partial class ResultViewControl : UserControl
    {
        public ResultViewControl()
        {
            InitializeComponent();

            bdsList.DataSource = new List<Result>();
        }

        public void SetResult(Result result)
        {
            lblTitle.Text = string.Format("제 {0:N0} 회 당첨번호", result.No);
            lblNumbers.Text = result.GetNumberText();
        }

        public void AddResults(List<Result> results)
        {
            List<Result> source = new List<Result>(((List<Result>)bdsList.List));

            results.Reverse();
            source.InsertRange(0, results);

            bdsList.DataSource = source;

            dgvList.FirstDisplayedScrollingRowIndex = 0;
        }

        public void ClearResult()
        {
            bdsList.Clear();
        }

        private void dgvList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null || e.ColumnIndex != 9)
                return;

            int rank = (int)e.Value;

            switch (rank)
            {
                case 1:
                    dgvList[0, e.RowIndex].Style.BackColor = Color.Gold;
                    break;
                case 2:
                    dgvList[0, e.RowIndex].Style.BackColor = Color.Coral;
                    break;
                case 3:
                    dgvList[0, e.RowIndex].Style.BackColor = Color.LightBlue;
                    break;
                case 4:
                    dgvList[0, e.RowIndex].Style.BackColor = Color.RoyalBlue;
                    break;
                case 5:
                    dgvList[0, e.RowIndex].Style.BackColor = Color.BurlyWood;
                    break;
            }
        }

        public void ExportToExcel()
        {
            if (sfdFile.ShowDialog() != DialogResult.OK)
                return;

            var list = (List<Result>) bdsList.List;

            FileInfo newFile = new FileInfo(sfdFile.FileName);
            using (ExcelPackage package = new ExcelPackage(newFile))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(DateTime.Now.ToString());

                worksheet.SetValue(1, 1, "순번");
                worksheet.SetValue(1, 2, "번호 1");
                worksheet.SetValue(1, 3, "번호 2");
                worksheet.SetValue(1, 4, "번호 3");
                worksheet.SetValue(1, 5, "번호 4");
                worksheet.SetValue(1, 6, "번호 5");
                worksheet.SetValue(1, 7, "번호 6");
                worksheet.SetValue(1, 8, "보너스");
                worksheet.SetValue(1, 9, "일치");
                worksheet.SetValue(1, 10, "등수");

                for (int i = 0; i < list.Count; i++)
                {
                    worksheet.SetValue(i + 2, 1, list[i].No);
                    worksheet.SetValue(i + 2, 2, list[i].Number1);
                    worksheet.SetValue(i + 2, 3, list[i].Number2);
                    worksheet.SetValue(i + 2, 4, list[i].Number3);
                    worksheet.SetValue(i + 2, 5, list[i].Number4);
                    worksheet.SetValue(i + 2, 6, list[i].Number5);
                    worksheet.SetValue(i + 2, 7, list[i].Number6);
                    worksheet.SetValue(i + 2, 8, list[i].BonusNumber);
                    worksheet.SetValue(i + 2, 9, list[i].MatchedCount);
                    worksheet.SetValue(i + 2, 10, list[i].Rank);
                }

                package.Save();
            }

            if (MessageBox.Show("엑셀 파일로 저장하였습니다. 저장한 파일을 열겠습니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                Process.Start(sfdFile.FileName);
        }
    }
}