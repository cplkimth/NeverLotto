namespace NeverLotto.Controls
{
    partial class SectorControl
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
            this.chbName = new System.Windows.Forms.CheckBox();
            this.rdbMaximum = new System.Windows.Forms.RadioButton();
            this.rdbMinimum = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // chbName
            // 
            this.chbName.AutoSize = true;
            this.chbName.Location = new System.Drawing.Point(3, 8);
            this.chbName.Name = "chbName";
            this.chbName.Size = new System.Drawing.Size(76, 16);
            this.chbName.TabIndex = 0;
            this.chbName.Text = "출현 번호";
            this.chbName.UseVisualStyleBackColor = true;
            this.chbName.CheckedChanged += new System.EventHandler(this.chbName_CheckedChanged);
            // 
            // rdbMaximum
            // 
            this.rdbMaximum.Checked = true;
            this.rdbMaximum.Enabled = false;
            this.rdbMaximum.Location = new System.Drawing.Point(97, 3);
            this.rdbMaximum.Name = "rdbMaximum";
            this.rdbMaximum.Size = new System.Drawing.Size(117, 24);
            this.rdbMaximum.TabIndex = 2;
            this.rdbMaximum.TabStop = true;
            this.rdbMaximum.Text = "최다 (137 - 134))";
            this.rdbMaximum.UseVisualStyleBackColor = true;
            // 
            // rdbMinimum
            // 
            this.rdbMinimum.Enabled = false;
            this.rdbMinimum.Location = new System.Drawing.Point(220, 7);
            this.rdbMinimum.Name = "rdbMinimum";
            this.rdbMinimum.Size = new System.Drawing.Size(116, 16);
            this.rdbMinimum.TabIndex = 3;
            this.rdbMinimum.Text = "최다 (137 - 134))";
            this.rdbMinimum.UseVisualStyleBackColor = true;
            // 
            // SectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdbMinimum);
            this.Controls.Add(this.rdbMaximum);
            this.Controls.Add(this.chbName);
            this.Name = "SectorControl";
            this.Size = new System.Drawing.Size(621, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbName;
        private System.Windows.Forms.RadioButton rdbMaximum;
        private System.Windows.Forms.RadioButton rdbMinimum;
    }
}
