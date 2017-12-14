namespace NeverLotto.Controls
{
    partial class GridControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.noDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumbersText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstDigitSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastDigitSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edgeSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edgeSubtractionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowHighRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oddEvenRateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdsList = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsList)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noDataGridViewTextBoxColumn,
            this.NumbersText,
            this.totalSumDataGridViewTextBoxColumn,
            this.lowSumDataGridViewTextBoxColumn,
            this.highSumDataGridViewTextBoxColumn,
            this.firstDigitSumDataGridViewTextBoxColumn,
            this.lastDigitSumDataGridViewTextBoxColumn,
            this.edgeSumDataGridViewTextBoxColumn,
            this.edgeSubtractionDataGridViewTextBoxColumn,
            this.lowHighRateDataGridViewTextBoxColumn,
            this.oddEvenRateDataGridViewTextBoxColumn,
            this.seriesCountDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bdsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvList.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(1162, 679);
            this.dgvList.TabIndex = 0;
            // 
            // noDataGridViewTextBoxColumn
            // 
            this.noDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.noDataGridViewTextBoxColumn.DataPropertyName = "No";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.noDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.noDataGridViewTextBoxColumn.HeaderText = "회차";
            this.noDataGridViewTextBoxColumn.Name = "noDataGridViewTextBoxColumn";
            this.noDataGridViewTextBoxColumn.ReadOnly = true;
            this.noDataGridViewTextBoxColumn.Width = 60;
            // 
            // NumbersText
            // 
            this.NumbersText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NumbersText.DataPropertyName = "NumbersText";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NumbersText.DefaultCellStyle = dataGridViewCellStyle2;
            this.NumbersText.HeaderText = "당첨 번호";
            this.NumbersText.Name = "NumbersText";
            this.NumbersText.ReadOnly = true;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.totalSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "총합";
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSumDataGridViewTextBoxColumn.Width = 60;
            // 
            // lowSumDataGridViewTextBoxColumn
            // 
            this.lowSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lowSumDataGridViewTextBoxColumn.DataPropertyName = "LowSum";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lowSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.lowSumDataGridViewTextBoxColumn.HeaderText = "123합";
            this.lowSumDataGridViewTextBoxColumn.Name = "lowSumDataGridViewTextBoxColumn";
            this.lowSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowSumDataGridViewTextBoxColumn.Width = 70;
            // 
            // highSumDataGridViewTextBoxColumn
            // 
            this.highSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.highSumDataGridViewTextBoxColumn.DataPropertyName = "HighSum";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.highSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.highSumDataGridViewTextBoxColumn.HeaderText = "456합";
            this.highSumDataGridViewTextBoxColumn.Name = "highSumDataGridViewTextBoxColumn";
            this.highSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.highSumDataGridViewTextBoxColumn.Width = 70;
            // 
            // firstDigitSumDataGridViewTextBoxColumn
            // 
            this.firstDigitSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.firstDigitSumDataGridViewTextBoxColumn.DataPropertyName = "FirstDigitSum";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.firstDigitSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.firstDigitSumDataGridViewTextBoxColumn.HeaderText = "첫수합";
            this.firstDigitSumDataGridViewTextBoxColumn.Name = "firstDigitSumDataGridViewTextBoxColumn";
            this.firstDigitSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstDigitSumDataGridViewTextBoxColumn.Width = 70;
            // 
            // lastDigitSumDataGridViewTextBoxColumn
            // 
            this.lastDigitSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lastDigitSumDataGridViewTextBoxColumn.DataPropertyName = "LastDigitSum";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lastDigitSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.lastDigitSumDataGridViewTextBoxColumn.HeaderText = "끝수합";
            this.lastDigitSumDataGridViewTextBoxColumn.Name = "lastDigitSumDataGridViewTextBoxColumn";
            this.lastDigitSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastDigitSumDataGridViewTextBoxColumn.Width = 70;
            // 
            // edgeSumDataGridViewTextBoxColumn
            // 
            this.edgeSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edgeSumDataGridViewTextBoxColumn.DataPropertyName = "EdgeSum";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.edgeSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.edgeSumDataGridViewTextBoxColumn.HeaderText = "간격합";
            this.edgeSumDataGridViewTextBoxColumn.Name = "edgeSumDataGridViewTextBoxColumn";
            this.edgeSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.edgeSumDataGridViewTextBoxColumn.Width = 70;
            // 
            // edgeSubtractionDataGridViewTextBoxColumn
            // 
            this.edgeSubtractionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edgeSubtractionDataGridViewTextBoxColumn.DataPropertyName = "EdgeSubtraction";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.edgeSubtractionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.edgeSubtractionDataGridViewTextBoxColumn.HeaderText = "간격차";
            this.edgeSubtractionDataGridViewTextBoxColumn.Name = "edgeSubtractionDataGridViewTextBoxColumn";
            this.edgeSubtractionDataGridViewTextBoxColumn.ReadOnly = true;
            this.edgeSubtractionDataGridViewTextBoxColumn.Width = 70;
            // 
            // lowHighRateDataGridViewTextBoxColumn
            // 
            this.lowHighRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.lowHighRateDataGridViewTextBoxColumn.DataPropertyName = "LowHighRateText";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.lowHighRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle10;
            this.lowHighRateDataGridViewTextBoxColumn.HeaderText = "저고 비율";
            this.lowHighRateDataGridViewTextBoxColumn.Name = "lowHighRateDataGridViewTextBoxColumn";
            this.lowHighRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lowHighRateDataGridViewTextBoxColumn.Width = 90;
            // 
            // oddEvenRateDataGridViewTextBoxColumn
            // 
            this.oddEvenRateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.oddEvenRateDataGridViewTextBoxColumn.DataPropertyName = "OddEvenRateText";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.oddEvenRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.oddEvenRateDataGridViewTextBoxColumn.HeaderText = "홀짝 비율";
            this.oddEvenRateDataGridViewTextBoxColumn.Name = "oddEvenRateDataGridViewTextBoxColumn";
            this.oddEvenRateDataGridViewTextBoxColumn.ReadOnly = true;
            this.oddEvenRateDataGridViewTextBoxColumn.Width = 90;
            // 
            // seriesCountDataGridViewTextBoxColumn
            // 
            this.seriesCountDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.seriesCountDataGridViewTextBoxColumn.DataPropertyName = "SeriesCount";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.seriesCountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.seriesCountDataGridViewTextBoxColumn.HeaderText = "연번 갯수";
            this.seriesCountDataGridViewTextBoxColumn.Name = "seriesCountDataGridViewTextBoxColumn";
            this.seriesCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.seriesCountDataGridViewTextBoxColumn.Width = 90;
            // 
            // bdsList
            // 
            this.bdsList.DataSource = typeof(NeverLotto.Engine.Result);
            // 
            // GridControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Name = "GridControl";
            this.Size = new System.Drawing.Size(1162, 679);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.BindingSource bdsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn noDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumbersText;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstDigitSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastDigitSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edgeSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edgeSubtractionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowHighRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oddEvenRateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesCountDataGridViewTextBoxColumn;
    }
}
