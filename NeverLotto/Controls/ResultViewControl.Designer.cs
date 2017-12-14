using System.Windows.Forms;

namespace NeverLotto.Controls
{
    partial class ResultViewControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonusNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsList = new System.Windows.Forms.BindingSource(this.components);
            this.lblNumbers = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.Number1,
            this.Number2,
            this.Number3,
            this.Number4,
            this.Number5,
            this.Number6,
            this.BonusNumber,
            this.totalSumDataGridViewTextBoxColumn,
            this.lowSumDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsList;
            this.dgvList.Location = new System.Drawing.Point(3, 37);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(778, 585);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvList_CellFormatting);
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.noDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.noDataGridViewTextBoxColumn.HeaderText = "순번";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Number1
            // 
            this.Number1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number1.DataPropertyName = "Number1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Number1.HeaderText = "1";
            this.Number1.Name = "Number1";
            this.Number1.ReadOnly = true;
            this.Number1.Width = 30;
            // 
            // Number2
            // 
            this.Number2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number2.DataPropertyName = "Number2";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Number2.HeaderText = "2";
            this.Number2.Name = "Number2";
            this.Number2.ReadOnly = true;
            this.Number2.Width = 30;
            // 
            // Number3
            // 
            this.Number3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number3.DataPropertyName = "Number3";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number3.DefaultCellStyle = dataGridViewCellStyle4;
            this.Number3.HeaderText = "3";
            this.Number3.Name = "Number3";
            this.Number3.ReadOnly = true;
            this.Number3.Width = 30;
            // 
            // Number4
            // 
            this.Number4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number4.DataPropertyName = "Number4";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number4.DefaultCellStyle = dataGridViewCellStyle5;
            this.Number4.HeaderText = "4";
            this.Number4.Name = "Number4";
            this.Number4.ReadOnly = true;
            this.Number4.Width = 30;
            // 
            // Number5
            // 
            this.Number5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number5.DataPropertyName = "Number5";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number5.DefaultCellStyle = dataGridViewCellStyle6;
            this.Number5.HeaderText = "5";
            this.Number5.Name = "Number5";
            this.Number5.ReadOnly = true;
            this.Number5.Width = 30;
            // 
            // Number6
            // 
            this.Number6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number6.DataPropertyName = "Number6";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Number6.DefaultCellStyle = dataGridViewCellStyle7;
            this.Number6.HeaderText = "6";
            this.Number6.Name = "Number6";
            this.Number6.ReadOnly = true;
            this.Number6.Width = 30;
            // 
            // BonusNumber
            // 
            this.BonusNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BonusNumber.DataPropertyName = "BonusNumber";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.BonusNumber.DefaultCellStyle = dataGridViewCellStyle8;
            this.BonusNumber.HeaderText = "보";
            this.BonusNumber.Name = "BonusNumber";
            this.BonusNumber.ReadOnly = true;
            this.BonusNumber.Width = 30;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "MatchedCount";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "일치";
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lowSumDataGridViewTextBoxColumn
            // 
            this.lowSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lowSumDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lowSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.lowSumDataGridViewTextBoxColumn.HeaderText = "등수";
            this.lowSumDataGridViewTextBoxColumn.Name = "lowSumDataGridViewTextBoxColumn";
            this.lowSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bdsList
            // 
            this.bdsList.DataSource = typeof(NeverLotto.Engine.Result);
            // 
            // lblNumbers
            // 
            this.lblNumbers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumbers.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblNumbers.Location = new System.Drawing.Point(129, 5);
            this.lblNumbers.Name = "lblNumbers";
            this.lblNumbers.Size = new System.Drawing.Size(654, 23);
            this.lblNumbers.TabIndex = 3;
            this.lblNumbers.Text = "567회 당첨번호";
            this.lblNumbers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(5, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(118, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "제 1,234 회 당첨번호";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sfdFile
            // 
            this.sfdFile.DefaultExt = "xlsx";
            this.sfdFile.Filter = "Excel files|*.xlsx";
            // 
            // ResultViewControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNumbers);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvList);
            this.Name = "ResultViewControl";
            this.Size = new System.Drawing.Size(784, 625);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsList;
        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Number1;
        private DataGridViewTextBoxColumn Number2;
        private DataGridViewTextBoxColumn Number3;
        private DataGridViewTextBoxColumn Number4;
        private DataGridViewTextBoxColumn Number5;
        private DataGridViewTextBoxColumn Number6;
        private DataGridViewTextBoxColumn BonusNumber;
        private DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lowSumDataGridViewTextBoxColumn;

    }
}
