using System.Windows.Forms;

namespace NeverLotto.Controls
{
    partial class AnalysisControl
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chtChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bdsList = new System.Windows.Forms.BindingSource();
            this.rdbButton0 = new System.Windows.Forms.RadioButton();
            this.rdbButton1 = new System.Windows.Forms.RadioButton();
            this.rdbButton9 = new System.Windows.Forms.RadioButton();
            this.rdbButton8 = new System.Windows.Forms.RadioButton();
            this.rdbButton7 = new System.Windows.Forms.RadioButton();
            this.rdbButton6 = new System.Windows.Forms.RadioButton();
            this.rdbButton5 = new System.Windows.Forms.RadioButton();
            this.rdbButton4 = new System.Windows.Forms.RadioButton();
            this.rdbButton3 = new System.Windows.Forms.RadioButton();
            this.rdbButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbButton10 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chtChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNo)).BeginInit();
            this.SuspendLayout();
            // 
            // chtChart
            // 
            this.chtChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chtChart.ChartAreas.Add(chartArea1);
            this.chtChart.DataSource = this.bdsList;
            this.chtChart.Location = new System.Drawing.Point(3, 57);
            this.chtChart.Name = "chtChart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            series1.ToolTip = "#VALX (#VAL)";
            series1.XValueMember = "Name";
            series1.YValueMembers = "Count";
            this.chtChart.Series.Add(series1);
            this.chtChart.Size = new System.Drawing.Size(1031, 480);
            this.chtChart.TabIndex = 1;
            this.chtChart.Text = "chart1";
            // 
            // bdsList
            // 
            this.bdsList.DataSource = typeof(NeverLotto.Engine.Bar);
            // 
            // rdbButton0
            // 
            this.rdbButton0.AutoSize = true;
            this.rdbButton0.Checked = true;
            this.rdbButton0.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton0.Location = new System.Drawing.Point(7, 20);
            this.rdbButton0.Name = "rdbButton0";
            this.rdbButton0.Size = new System.Drawing.Size(47, 16);
            this.rdbButton0.TabIndex = 0;
            this.rdbButton0.TabStop = true;
            this.rdbButton0.Tag = "0";
            this.rdbButton0.Text = "총합";
            this.rdbButton0.UseVisualStyleBackColor = true;
            this.rdbButton0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton1
            // 
            this.rdbButton1.AutoSize = true;
            this.rdbButton1.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton1.Location = new System.Drawing.Point(60, 20);
            this.rdbButton1.Name = "rdbButton1";
            this.rdbButton1.Size = new System.Drawing.Size(53, 16);
            this.rdbButton1.TabIndex = 1;
            this.rdbButton1.Tag = "1";
            this.rdbButton1.Text = "123합";
            this.rdbButton1.UseVisualStyleBackColor = true;
            this.rdbButton1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton9
            // 
            this.rdbButton9.AutoSize = true;
            this.rdbButton9.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton9.Location = new System.Drawing.Point(600, 20);
            this.rdbButton9.Name = "rdbButton9";
            this.rdbButton9.Size = new System.Drawing.Size(75, 16);
            this.rdbButton9.TabIndex = 9;
            this.rdbButton9.Tag = "9";
            this.rdbButton9.Text = "연번 갯수";
            this.rdbButton9.UseVisualStyleBackColor = true;
            this.rdbButton9.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton8
            // 
            this.rdbButton8.AutoSize = true;
            this.rdbButton8.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton8.Location = new System.Drawing.Point(519, 20);
            this.rdbButton8.Name = "rdbButton8";
            this.rdbButton8.Size = new System.Drawing.Size(75, 16);
            this.rdbButton8.TabIndex = 8;
            this.rdbButton8.Tag = "8";
            this.rdbButton8.Text = "홀짝 비율";
            this.rdbButton8.UseVisualStyleBackColor = true;
            this.rdbButton8.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton7
            // 
            this.rdbButton7.AutoSize = true;
            this.rdbButton7.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton7.Location = new System.Drawing.Point(438, 20);
            this.rdbButton7.Name = "rdbButton7";
            this.rdbButton7.Size = new System.Drawing.Size(75, 16);
            this.rdbButton7.TabIndex = 7;
            this.rdbButton7.Tag = "7";
            this.rdbButton7.Text = "저고 비율";
            this.rdbButton7.UseVisualStyleBackColor = true;
            this.rdbButton7.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton6
            // 
            this.rdbButton6.AutoSize = true;
            this.rdbButton6.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton6.Location = new System.Drawing.Point(373, 20);
            this.rdbButton6.Name = "rdbButton6";
            this.rdbButton6.Size = new System.Drawing.Size(59, 16);
            this.rdbButton6.TabIndex = 6;
            this.rdbButton6.Tag = "6";
            this.rdbButton6.Text = "간격차";
            this.rdbButton6.UseVisualStyleBackColor = true;
            this.rdbButton6.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton5
            // 
            this.rdbButton5.AutoSize = true;
            this.rdbButton5.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton5.Location = new System.Drawing.Point(308, 20);
            this.rdbButton5.Name = "rdbButton5";
            this.rdbButton5.Size = new System.Drawing.Size(59, 16);
            this.rdbButton5.TabIndex = 5;
            this.rdbButton5.Tag = "5";
            this.rdbButton5.Text = "간격합";
            this.rdbButton5.UseVisualStyleBackColor = true;
            this.rdbButton5.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton4
            // 
            this.rdbButton4.AutoSize = true;
            this.rdbButton4.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton4.Location = new System.Drawing.Point(243, 20);
            this.rdbButton4.Name = "rdbButton4";
            this.rdbButton4.Size = new System.Drawing.Size(59, 16);
            this.rdbButton4.TabIndex = 4;
            this.rdbButton4.Tag = "4";
            this.rdbButton4.Text = "끝수합";
            this.rdbButton4.UseVisualStyleBackColor = true;
            this.rdbButton4.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton3
            // 
            this.rdbButton3.AutoSize = true;
            this.rdbButton3.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton3.Location = new System.Drawing.Point(178, 20);
            this.rdbButton3.Name = "rdbButton3";
            this.rdbButton3.Size = new System.Drawing.Size(59, 16);
            this.rdbButton3.TabIndex = 3;
            this.rdbButton3.Tag = "3";
            this.rdbButton3.Text = "첫수합";
            this.rdbButton3.UseVisualStyleBackColor = true;
            this.rdbButton3.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdbButton2
            // 
            this.rdbButton2.AutoSize = true;
            this.rdbButton2.ForeColor = System.Drawing.Color.Blue;
            this.rdbButton2.Location = new System.Drawing.Point(119, 20);
            this.rdbButton2.Name = "rdbButton2";
            this.rdbButton2.Size = new System.Drawing.Size(53, 16);
            this.rdbButton2.TabIndex = 2;
            this.rdbButton2.Tag = "2";
            this.rdbButton2.Text = "456합";
            this.rdbButton2.UseVisualStyleBackColor = true;
            this.rdbButton2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbButton10);
            this.groupBox1.Controls.Add(this.rdbButton2);
            this.groupBox1.Controls.Add(this.rdbButton3);
            this.groupBox1.Controls.Add(this.rdbButton4);
            this.groupBox1.Controls.Add(this.rdbButton5);
            this.groupBox1.Controls.Add(this.rdbButton6);
            this.groupBox1.Controls.Add(this.rdbButton0);
            this.groupBox1.Controls.Add(this.rdbButton7);
            this.groupBox1.Controls.Add(this.rdbButton1);
            this.groupBox1.Controls.Add(this.rdbButton8);
            this.groupBox1.Controls.Add(this.rdbButton9);
            this.groupBox1.Location = new System.Drawing.Point(137, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "분석 종류";
            // 
            // rdbButton10
            // 
            this.rdbButton10.AutoSize = true;
            this.rdbButton10.ForeColor = System.Drawing.Color.Red;
            this.rdbButton10.Location = new System.Drawing.Point(681, 20);
            this.rdbButton10.Name = "rdbButton10";
            this.rdbButton10.Size = new System.Drawing.Size(75, 16);
            this.rdbButton10.TabIndex = 10;
            this.rdbButton10.Tag = "10";
            this.rdbButton10.Text = "출현 번호";
            this.rdbButton10.UseVisualStyleBackColor = true;
            this.rdbButton10.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.nudNo);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 48);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "분석 기간";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "회";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "최근";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNo
            // 
            this.nudNo.Location = new System.Drawing.Point(44, 17);
            this.nudNo.Maximum = new decimal(new int[] {
            567,
            0,
            0,
            0});
            this.nudNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNo.Name = "nudNo";
            this.nudNo.Size = new System.Drawing.Size(50, 21);
            this.nudNo.TabIndex = 14;
            this.nudNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudNo.Value = new decimal(new int[] {
            567,
            0,
            0,
            0});
            // 
            // AnalysisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chtChart);
            this.Name = "AnalysisControl";
            this.Size = new System.Drawing.Size(1037, 540);
            ((System.ComponentModel.ISupportInitialize)(this.chtChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdsList;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtChart;
        private System.Windows.Forms.RadioButton rdbButton0;
        private System.Windows.Forms.RadioButton rdbButton1;
        private System.Windows.Forms.RadioButton rdbButton9;
        private System.Windows.Forms.RadioButton rdbButton8;
        private System.Windows.Forms.RadioButton rdbButton7;
        private System.Windows.Forms.RadioButton rdbButton6;
        private System.Windows.Forms.RadioButton rdbButton5;
        private System.Windows.Forms.RadioButton rdbButton4;
        private System.Windows.Forms.RadioButton rdbButton3;
        private System.Windows.Forms.RadioButton rdbButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbButton10;
        private System.Windows.Forms.GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private NumericUpDown nudNo;
    }
}
