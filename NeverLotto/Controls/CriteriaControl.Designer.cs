using System.Windows.Forms;

namespace NeverLotto.Controls
{
    partial class CriteriaControl
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNo = new System.Windows.Forms.NumericUpDown();
            this.btnMaximum = new Button();
            this.btnMinimum = new Button();
            this.btnSelectNone = new Button();
            this.btnSelectAll = new Button();
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.tbpCriteria = new System.Windows.Forms.TabPage();
            this.uscSecotr0 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr2 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr7 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr1 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr3 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr6 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr4 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr9 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr8 = new NeverLotto.Controls.SectorControl();
            this.uscSecotr5 = new NeverLotto.Controls.SectorControl();
            this.tbpInclude = new System.Windows.Forms.TabPage();
            this.uscInclude = new NeverLotto.Controls.NumberSelectionControl();
            this.tbpExclude = new System.Windows.Forms.TabPage();
            this.uscExclude = new NeverLotto.Controls.NumberSelectionControl();
            ((System.ComponentModel.ISupportInitialize)(this.nudNo)).BeginInit();
            this.tbcTab.SuspendLayout();
            this.tbpCriteria.SuspendLayout();
            this.tbpInclude.SuspendLayout();
            this.tbpExclude.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(98, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "회의 당첨 번호를 기반으로 번호를 생성합니다.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "최근";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudNo
            // 
            this.nudNo.Location = new System.Drawing.Point(42, 6);
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
            this.nudNo.ValueChanged += new System.EventHandler(this.nudNo_ValueChanged);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Location = new System.Drawing.Point(170, 373);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(75, 23);
            this.btnMaximum.TabIndex = 19;
            this.btnMaximum.Text = "모두 최다";
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // btnMinimum
            // 
            this.btnMinimum.Location = new System.Drawing.Point(251, 373);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(75, 23);
            this.btnMinimum.TabIndex = 20;
            this.btnMinimum.Text = "모두 최소";
            this.btnMinimum.Click += new System.EventHandler(this.btnMinimum_Click);
            // 
            // btnSelectNone
            // 
            this.btnSelectNone.Location = new System.Drawing.Point(89, 373);
            this.btnSelectNone.Name = "btnSelectNone";
            this.btnSelectNone.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNone.TabIndex = 22;
            this.btnSelectNone.Text = "모두 해제";
            this.btnSelectNone.Click += new System.EventHandler(this.btnSelectNone_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(8, 373);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 21;
            this.btnSelectAll.Text = "모두 적용";
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // tbcTab
            // 
            this.tbcTab.Controls.Add(this.tbpCriteria);
            this.tbcTab.Controls.Add(this.tbpInclude);
            this.tbcTab.Controls.Add(this.tbpExclude);
            this.tbcTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcTab.Location = new System.Drawing.Point(0, 0);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(406, 483);
            this.tbcTab.TabIndex = 23;
            // 
            // tbpCriteria
            // 
            this.tbpCriteria.Controls.Add(this.uscSecotr0);
            this.tbpCriteria.Controls.Add(this.label2);
            this.tbpCriteria.Controls.Add(this.btnSelectNone);
            this.tbpCriteria.Controls.Add(this.label1);
            this.tbpCriteria.Controls.Add(this.uscSecotr2);
            this.tbpCriteria.Controls.Add(this.nudNo);
            this.tbpCriteria.Controls.Add(this.btnSelectAll);
            this.tbpCriteria.Controls.Add(this.btnMinimum);
            this.tbpCriteria.Controls.Add(this.uscSecotr7);
            this.tbpCriteria.Controls.Add(this.btnMaximum);
            this.tbpCriteria.Controls.Add(this.uscSecotr1);
            this.tbpCriteria.Controls.Add(this.uscSecotr3);
            this.tbpCriteria.Controls.Add(this.uscSecotr6);
            this.tbpCriteria.Controls.Add(this.uscSecotr4);
            this.tbpCriteria.Controls.Add(this.uscSecotr9);
            this.tbpCriteria.Controls.Add(this.uscSecotr8);
            this.tbpCriteria.Controls.Add(this.uscSecotr5);
            this.tbpCriteria.Location = new System.Drawing.Point(4, 22);
            this.tbpCriteria.Name = "tbpCriteria";
            this.tbpCriteria.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCriteria.Size = new System.Drawing.Size(398, 457);
            this.tbpCriteria.TabIndex = 0;
            this.tbpCriteria.Text = "당첨 번호";
            this.tbpCriteria.UseVisualStyleBackColor = true;
            // 
            // uscSecotr0
            // 
            this.uscSecotr0.Analyzer = null;
            this.uscSecotr0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr0.Location = new System.Drawing.Point(8, 33);
            this.uscSecotr0.Name = "uscSecotr0";
            this.uscSecotr0.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr0.TabIndex = 0;
            // 
            // uscSecotr2
            // 
            this.uscSecotr2.AnalysisTypeIndex = 2;
            this.uscSecotr2.Analyzer = null;
            this.uscSecotr2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr2.Location = new System.Drawing.Point(8, 101);
            this.uscSecotr2.Name = "uscSecotr2";
            this.uscSecotr2.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr2.TabIndex = 12;
            // 
            // uscSecotr7
            // 
            this.uscSecotr7.AnalysisTypeIndex = 7;
            this.uscSecotr7.Analyzer = null;
            this.uscSecotr7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr7.Location = new System.Drawing.Point(8, 271);
            this.uscSecotr7.Name = "uscSecotr7";
            this.uscSecotr7.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr7.TabIndex = 17;
            // 
            // uscSecotr1
            // 
            this.uscSecotr1.AnalysisTypeIndex = 1;
            this.uscSecotr1.Analyzer = null;
            this.uscSecotr1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr1.Location = new System.Drawing.Point(8, 67);
            this.uscSecotr1.Name = "uscSecotr1";
            this.uscSecotr1.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr1.TabIndex = 13;
            // 
            // uscSecotr3
            // 
            this.uscSecotr3.AnalysisTypeIndex = 3;
            this.uscSecotr3.Analyzer = null;
            this.uscSecotr3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr3.Location = new System.Drawing.Point(8, 135);
            this.uscSecotr3.Name = "uscSecotr3";
            this.uscSecotr3.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr3.TabIndex = 11;
            // 
            // uscSecotr6
            // 
            this.uscSecotr6.AnalysisTypeIndex = 6;
            this.uscSecotr6.Analyzer = null;
            this.uscSecotr6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr6.Location = new System.Drawing.Point(8, 237);
            this.uscSecotr6.Name = "uscSecotr6";
            this.uscSecotr6.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr6.TabIndex = 8;
            // 
            // uscSecotr4
            // 
            this.uscSecotr4.AnalysisTypeIndex = 4;
            this.uscSecotr4.Analyzer = null;
            this.uscSecotr4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr4.Location = new System.Drawing.Point(8, 169);
            this.uscSecotr4.Name = "uscSecotr4";
            this.uscSecotr4.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr4.TabIndex = 10;
            // 
            // uscSecotr9
            // 
            this.uscSecotr9.AnalysisTypeIndex = 9;
            this.uscSecotr9.Analyzer = null;
            this.uscSecotr9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr9.Location = new System.Drawing.Point(8, 339);
            this.uscSecotr9.Name = "uscSecotr9";
            this.uscSecotr9.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr9.TabIndex = 15;
            // 
            // uscSecotr8
            // 
            this.uscSecotr8.AnalysisTypeIndex = 8;
            this.uscSecotr8.Analyzer = null;
            this.uscSecotr8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr8.Location = new System.Drawing.Point(8, 305);
            this.uscSecotr8.Name = "uscSecotr8";
            this.uscSecotr8.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr8.TabIndex = 16;
            // 
            // uscSecotr5
            // 
            this.uscSecotr5.AnalysisTypeIndex = 5;
            this.uscSecotr5.Analyzer = null;
            this.uscSecotr5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscSecotr5.Location = new System.Drawing.Point(8, 203);
            this.uscSecotr5.Name = "uscSecotr5";
            this.uscSecotr5.Size = new System.Drawing.Size(384, 28);
            this.uscSecotr5.TabIndex = 9;
            // 
            // tbpInclude
            // 
            this.tbpInclude.Controls.Add(this.uscInclude);
            this.tbpInclude.Location = new System.Drawing.Point(4, 22);
            this.tbpInclude.Name = "tbpInclude";
            this.tbpInclude.Padding = new System.Windows.Forms.Padding(3);
            this.tbpInclude.Size = new System.Drawing.Size(398, 457);
            this.tbpInclude.TabIndex = 1;
            this.tbpInclude.Text = "포함 번호";
            this.tbpInclude.UseVisualStyleBackColor = true;
            // 
            // uscInclude
            // 
            this.uscInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscInclude.Location = new System.Drawing.Point(3, 3);
            this.uscInclude.MaxCheckableCount = 6;
            this.uscInclude.Name = "uscInclude";
            this.uscInclude.Size = new System.Drawing.Size(392, 451);
            this.uscInclude.TabIndex = 0;
            this.uscInclude.SelectClicked += new System.EventHandler<NeverLotto.Controls.NumberSelectionControl.SelectClickedEventArgs>(this.uscIncludeNumber_SelectClicked);
            // 
            // tbpExclude
            // 
            this.tbpExclude.Controls.Add(this.uscExclude);
            this.tbpExclude.Location = new System.Drawing.Point(4, 22);
            this.tbpExclude.Name = "tbpExclude";
            this.tbpExclude.Padding = new System.Windows.Forms.Padding(3);
            this.tbpExclude.Size = new System.Drawing.Size(398, 457);
            this.tbpExclude.TabIndex = 2;
            this.tbpExclude.Text = "제외 번호";
            this.tbpExclude.UseVisualStyleBackColor = true;
            // 
            // uscExclude
            // 
            this.uscExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscExclude.Location = new System.Drawing.Point(3, 3);
            this.uscExclude.MaxCheckableCount = 39;
            this.uscExclude.Name = "uscExclude";
            this.uscExclude.Size = new System.Drawing.Size(392, 451);
            this.uscExclude.TabIndex = 0;
            this.uscExclude.SelectClicked += new System.EventHandler<NeverLotto.Controls.NumberSelectionControl.SelectClickedEventArgs>(this.uscExclude_SelectClicked);
            // 
            // CriteriaControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcTab);
            this.Name = "CriteriaControl";
            this.Size = new System.Drawing.Size(406, 483);
            ((System.ComponentModel.ISupportInitialize)(this.nudNo)).EndInit();
            this.tbcTab.ResumeLayout(false);
            this.tbpCriteria.ResumeLayout(false);
            this.tbpInclude.ResumeLayout(false);
            this.tbpExclude.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SectorControl uscSecotr0;
        private SectorControl uscSecotr6;
        private SectorControl uscSecotr5;
        private SectorControl uscSecotr4;
        private SectorControl uscSecotr3;
        private SectorControl uscSecotr2;
        private SectorControl uscSecotr1;
        private SectorControl uscSecotr7;
        private SectorControl uscSecotr8;
        private SectorControl uscSecotr9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudNo;
        private Button btnMaximum;
        private Button btnMinimum;
        private Button btnSelectNone;
        private Button btnSelectAll;
        private System.Windows.Forms.TabControl tbcTab;
        private System.Windows.Forms.TabPage tbpCriteria;
        private System.Windows.Forms.TabPage tbpInclude;
        private NumberSelectionControl uscInclude;
        private System.Windows.Forms.TabPage tbpExclude;
        private NumberSelectionControl uscExclude;
    }
}
