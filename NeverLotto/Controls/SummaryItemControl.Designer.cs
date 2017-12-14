namespace NeverLotto.Controls
{
    partial class SummaryItemControl
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
            this.lblPrize = new System.Windows.Forms.Label();
            this.lblPrizeEach = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrize
            // 
            this.lblPrize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrize.Location = new System.Drawing.Point(59, 49);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(201, 23);
            this.lblPrize.TabIndex = 56;
            this.lblPrize.Text = "\\1,000,000";
            this.lblPrize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrizeEach
            // 
            this.lblPrizeEach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrizeEach.Location = new System.Drawing.Point(59, 26);
            this.lblPrizeEach.Name = "lblPrizeEach";
            this.lblPrizeEach.Size = new System.Drawing.Size(201, 23);
            this.lblPrizeEach.TabIndex = 55;
            this.lblPrizeEach.Text = "\\100,000";
            this.lblPrizeEach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCount
            // 
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Font = new System.Drawing.Font("Gulim", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCount.Location = new System.Drawing.Point(59, 3);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(201, 23);
            this.lblCount.TabIndex = 54;
            this.lblCount.Text = "123,456 회 (0.123456 %)";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblRank
            // 
            this.lblRank.BackColor = System.Drawing.Color.Gold;
            this.lblRank.Location = new System.Drawing.Point(3, 3);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(50, 23);
            this.lblRank.TabIndex = 53;
            this.lblRank.Text = "1등";
            this.lblRank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 57;
            this.label1.Text = "당첨금";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 23);
            this.label2.TabIndex = 58;
            this.label2.Text = "합계";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SummaryItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lblPrizeEach);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblRank);
            this.Name = "SummaryItemControl";
            this.Size = new System.Drawing.Size(263, 74);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.Label lblPrizeEach;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
