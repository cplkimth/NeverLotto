namespace NeverLotto
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.uscAnalysis = new NeverLotto.Controls.AnalysisControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uscList = new NeverLotto.Controls.GridControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.uscCriteria = new NeverLotto.Controls.CriteriaControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.uscGeneration = new NeverLotto.Controls.GenerationControl();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.uscResultView = new NeverLotto.Controls.ResultViewControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uscSummary = new NeverLotto.Controls.SummaryControl();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.도구OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcTab
            // 
            this.tbcTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTab.Controls.Add(this.tabPage1);
            this.tbcTab.Controls.Add(this.tabPage2);
            this.tbcTab.Location = new System.Drawing.Point(0, 27);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(992, 662);
            this.tbcTab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(984, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "분석";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.uscAnalysis, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(978, 630);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // uscAnalysis
            // 
            this.uscAnalysis.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscAnalysis.Location = new System.Drawing.Point(3, 318);
            this.uscAnalysis.Name = "uscAnalysis";
            this.uscAnalysis.Size = new System.Drawing.Size(972, 309);
            this.uscAnalysis.TabIndex = 1;
            this.uscAnalysis.ChartShowing += new System.EventHandler<NeverLotto.Controls.AnalysisControl.ChartShowingEventArgs>(this.uscAnalysis_ChartShowing);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.uscList);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 309);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "역대 당첨 번호";
            // 
            // uscList
            // 
            this.uscList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uscList.Location = new System.Drawing.Point(9, 20);
            this.uscList.Name = "uscList";
            this.uscList.Size = new System.Drawing.Size(957, 270);
            this.uscList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(984, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "생성";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.uscCriteria);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(386, 459);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "생성 조건";
            // 
            // uscCriteria
            // 
            this.uscCriteria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscCriteria.Location = new System.Drawing.Point(5, 19);
            this.uscCriteria.Name = "uscCriteria";
            this.uscCriteria.Size = new System.Drawing.Size(376, 435);
            this.uscCriteria.TabIndex = 0;
            this.uscCriteria.SummaryShowing += new System.EventHandler<NeverLotto.Controls.CriteriaControl.SummaryShowingEventArgs>(this.uscSimulatorCriteria_SummaryShowing);
            this.uscCriteria.SelectClicked += new System.EventHandler<NeverLotto.Controls.CriteriaControl.SelectClickedEventArgs>(this.uscCriteria_SelectClicked);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.uscGeneration);
            this.groupBox4.Location = new System.Drawing.Point(6, 471);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(386, 159);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "생성";
            // 
            // uscGeneration
            // 
            this.uscGeneration.BatchProgress = 0;
            this.uscGeneration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscGeneration.EachProgress = 0;
            this.uscGeneration.Location = new System.Drawing.Point(3, 17);
            this.uscGeneration.Name = "uscGeneration";
            this.uscGeneration.Size = new System.Drawing.Size(380, 139);
            this.uscGeneration.TabIndex = 2;
            this.uscGeneration.ClearClicked += new System.EventHandler<NeverLotto.Controls.GenerationControl.ClearClickedEventArgs>(this.uscGeneration_ClearClicked);
            this.uscGeneration.OnceClicked += new System.EventHandler<NeverLotto.Controls.GenerationControl.OnceClickedEventArgs>(this.uscGeneration_OnceClicked);
            this.uscGeneration.EachClicked += new System.EventHandler<NeverLotto.Controls.GenerationControl.EachClickedEventArgs>(this.uscGeneration_EachClicked);
            this.uscGeneration.BatchClicked += new System.EventHandler<NeverLotto.Controls.GenerationControl.BatchClickedEventArgs>(this.uscGeneration_BatchClicked);
            this.uscGeneration.CancelClicked += new System.EventHandler<NeverLotto.Controls.GenerationControl.CancelClickedEventArgs>(this.uscGeneration_CancelClicked);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.uscResultView);
            this.groupBox5.Location = new System.Drawing.Point(398, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 624);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "생성 번호";
            // 
            // uscResultView
            // 
            this.uscResultView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscResultView.Location = new System.Drawing.Point(3, 17);
            this.uscResultView.Name = "uscResultView";
            this.uscResultView.Size = new System.Drawing.Size(309, 604);
            this.uscResultView.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.uscSummary);
            this.groupBox3.Location = new System.Drawing.Point(719, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 624);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "요약";
            // 
            // uscSummary
            // 
            this.uscSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uscSummary.Location = new System.Drawing.Point(3, 17);
            this.uscSummary.Name = "uscSummary";
            this.uscSummary.Size = new System.Drawing.Size(248, 604);
            this.uscSummary.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.도구OToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(992, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuExit.Size = new System.Drawing.Size(155, 22);
            this.mnuExit.Text = "종료((&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // 도구OToolStripMenuItem
            // 
            this.도구OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExport,
            this.mnuOption});
            this.도구OToolStripMenuItem.Name = "도구OToolStripMenuItem";
            this.도구OToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.도구OToolStripMenuItem.Text = "도구(&T)";
            // 
            // mnuExport
            // 
            this.mnuExport.Name = "mnuExport";
            this.mnuExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExport.Size = new System.Drawing.Size(174, 22);
            this.mnuExport.Text = "내보내기(&E)";
            this.mnuExport.Click += new System.EventHandler(this.mnuExport_Click);
            // 
            // mnuOption
            // 
            this.mnuOption.Name = "mnuOption";
            this.mnuOption.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOption.Size = new System.Drawing.Size(174, 22);
            this.mnuOption.Text = "설정(&O)";
            this.mnuOption.Click += new System.EventHandler(this.mnuOption_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelp.Size = new System.Drawing.Size(142, 22);
            this.mnuHelp.Text = "도움말(&H)";
            this.mnuHelp.Click += new System.EventHandler(this.mnuHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 689);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tbcTab);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 709);
            this.Name = "MainForm";
            this.Text = "네버 로또";
            this.tbcTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.GridControl uscList;
        private Controls.AnalysisControl uscAnalysis;
        private System.Windows.Forms.TabControl tbcTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private Controls.CriteriaControl uscCriteria;
        private Controls.ResultViewControl uscResultView;
        private Controls.GenerationControl uscGeneration;
        private Controls.SummaryControl uscSummary;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem 도구OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExport;
        private System.Windows.Forms.ToolStripMenuItem mnuOption;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;

    }
}

