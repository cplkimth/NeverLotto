namespace NeverLotto.Controls
{
    partial class GenerationControl
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
            this.btnOnce = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbcTab = new System.Windows.Forms.TabControl();
            this.tbpOnce = new System.Windows.Forms.TabPage();
            this.tbpEach = new System.Windows.Forms.TabPage();
            this.prbEach = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMilliSecond = new System.Windows.Forms.NumericUpDown();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nudEach = new System.Windows.Forms.NumericUpDown();
            this.btnEach = new System.Windows.Forms.Button();
            this.tbpBatch = new System.Windows.Forms.TabPage();
            this.prbBatch = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.nudBatch = new System.Windows.Forms.NumericUpDown();
            this.btnBatch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbcTab.SuspendLayout();
            this.tbpOnce.SuspendLayout();
            this.tbpEach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMilliSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEach)).BeginInit();
            this.tbpBatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOnce
            // 
            this.btnOnce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOnce.Location = new System.Drawing.Point(260, 6);
            this.btnOnce.Name = "btnOnce";
            this.btnOnce.Size = new System.Drawing.Size(75, 23);
            this.btnOnce.TabIndex = 0;
            this.btnOnce.Text = "생성(&G)";
            this.btnOnce.UseVisualStyleBackColor = true;
            this.btnOnce.Click += new System.EventHandler(this.btnOnce_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(277, 193);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbcTab
            // 
            this.tbcTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcTab.Controls.Add(this.tbpOnce);
            this.tbcTab.Controls.Add(this.tbpEach);
            this.tbcTab.Controls.Add(this.tbpBatch);
            this.tbcTab.Location = new System.Drawing.Point(3, 3);
            this.tbcTab.Name = "tbcTab";
            this.tbcTab.SelectedIndex = 0;
            this.tbcTab.Size = new System.Drawing.Size(349, 184);
            this.tbcTab.TabIndex = 3;
            // 
            // tbpOnce
            // 
            this.tbpOnce.Controls.Add(this.btnOnce);
            this.tbpOnce.Location = new System.Drawing.Point(4, 22);
            this.tbpOnce.Name = "tbpOnce";
            this.tbpOnce.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOnce.Size = new System.Drawing.Size(341, 158);
            this.tbpOnce.TabIndex = 0;
            this.tbpOnce.Text = "한번 실행";
            this.tbpOnce.UseVisualStyleBackColor = true;
            // 
            // tbpEach
            // 
            this.tbpEach.Controls.Add(this.prbEach);
            this.tbpEach.Controls.Add(this.label3);
            this.tbpEach.Controls.Add(this.label2);
            this.tbpEach.Controls.Add(this.nudMilliSecond);
            this.tbpEach.Controls.Add(this.lblTotal);
            this.tbpEach.Controls.Add(this.nudEach);
            this.tbpEach.Controls.Add(this.btnEach);
            this.tbpEach.Location = new System.Drawing.Point(4, 22);
            this.tbpEach.Name = "tbpEach";
            this.tbpEach.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEach.Size = new System.Drawing.Size(341, 158);
            this.tbpEach.TabIndex = 1;
            this.tbpEach.Text = "한번씩 실행";
            this.tbpEach.UseVisualStyleBackColor = true;
            // 
            // prbEach
            // 
            this.prbEach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prbEach.Location = new System.Drawing.Point(6, 56);
            this.prbEach.Name = "prbEach";
            this.prbEach.Size = new System.Drawing.Size(329, 23);
            this.prbEach.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "모두";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(70, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "ms(1/1000초)에 한번씩";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudMilliSecond
            // 
            this.nudMilliSecond.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMilliSecond.Location = new System.Drawing.Point(6, 6);
            this.nudMilliSecond.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudMilliSecond.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudMilliSecond.Name = "nudMilliSecond";
            this.nudMilliSecond.Size = new System.Drawing.Size(58, 21);
            this.nudMilliSecond.TabIndex = 19;
            this.nudMilliSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMilliSecond.ThousandsSeparator = true;
            this.nudMilliSecond.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(108, 30);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(142, 23);
            this.lblTotal.TabIndex = 18;
            this.lblTotal.Text = "번 실행합니다.";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudEach
            // 
            this.nudEach.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudEach.Location = new System.Drawing.Point(44, 29);
            this.nudEach.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudEach.Name = "nudEach";
            this.nudEach.Size = new System.Drawing.Size(58, 21);
            this.nudEach.TabIndex = 3;
            this.nudEach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudEach.ThousandsSeparator = true;
            this.nudEach.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnEach
            // 
            this.btnEach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEach.Location = new System.Drawing.Point(260, 6);
            this.btnEach.Name = "btnEach";
            this.btnEach.Size = new System.Drawing.Size(75, 23);
            this.btnEach.TabIndex = 2;
            this.btnEach.Text = "생성(&E)";
            this.btnEach.UseVisualStyleBackColor = true;
            this.btnEach.Click += new System.EventHandler(this.btnEach_Click);
            // 
            // tbpBatch
            // 
            this.tbpBatch.Controls.Add(this.prbBatch);
            this.tbpBatch.Controls.Add(this.label1);
            this.tbpBatch.Controls.Add(this.nudBatch);
            this.tbpBatch.Controls.Add(this.btnBatch);
            this.tbpBatch.Location = new System.Drawing.Point(4, 22);
            this.tbpBatch.Name = "tbpBatch";
            this.tbpBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBatch.Size = new System.Drawing.Size(341, 158);
            this.tbpBatch.TabIndex = 2;
            this.tbpBatch.Text = "일괄 실행";
            this.tbpBatch.UseVisualStyleBackColor = true;
            // 
            // prbBatch
            // 
            this.prbBatch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prbBatch.Location = new System.Drawing.Point(6, 39);
            this.prbBatch.Name = "prbBatch";
            this.prbBatch.Size = new System.Drawing.Size(329, 23);
            this.prbBatch.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(112, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "번 실행합니다.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudBatch
            // 
            this.nudBatch.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBatch.Location = new System.Drawing.Point(6, 6);
            this.nudBatch.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudBatch.Name = "nudBatch";
            this.nudBatch.Size = new System.Drawing.Size(100, 21);
            this.nudBatch.TabIndex = 20;
            this.nudBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudBatch.ThousandsSeparator = true;
            this.nudBatch.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // btnBatch
            // 
            this.btnBatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBatch.Location = new System.Drawing.Point(260, 6);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(75, 23);
            this.btnBatch.TabIndex = 19;
            this.btnBatch.Text = "생성(&B)";
            this.btnBatch.UseVisualStyleBackColor = true;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(7, 193);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "중지";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GenerationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbcTab);
            this.Controls.Add(this.btnClear);
            this.Name = "GenerationControl";
            this.Size = new System.Drawing.Size(355, 219);
            this.tbcTab.ResumeLayout(false);
            this.tbpOnce.ResumeLayout(false);
            this.tbpEach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMilliSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEach)).EndInit();
            this.tbpBatch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBatch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOnce;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TabControl tbcTab;
        private System.Windows.Forms.TabPage tbpOnce;
        private System.Windows.Forms.TabPage tbpEach;
        private System.Windows.Forms.TabPage tbpBatch;
        private System.Windows.Forms.NumericUpDown nudEach;
        private System.Windows.Forms.Button btnEach;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudBatch;
        private System.Windows.Forms.ProgressBar prbBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMilliSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ProgressBar prbEach;
    }
}
