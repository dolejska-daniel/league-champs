namespace LeagueChamps
{
    partial class settingsForm
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
            this.difficultyBar = new System.Windows.Forms.TrackBar();
            this.difficultyGroup = new System.Windows.Forms.GroupBox();
            this.difficultyValue = new System.Windows.Forms.Label();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.questionGroup = new System.Windows.Forms.GroupBox();
            this.questionValue = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBar)).BeginInit();
            this.difficultyGroup.SuspendLayout();
            this.questionGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // difficultyBar
            // 
            this.difficultyBar.LargeChange = 1;
            this.difficultyBar.Location = new System.Drawing.Point(6, 19);
            this.difficultyBar.Maximum = 2;
            this.difficultyBar.Name = "difficultyBar";
            this.difficultyBar.Size = new System.Drawing.Size(247, 45);
            this.difficultyBar.TabIndex = 7;
            this.difficultyBar.ValueChanged += new System.EventHandler(this.difficultyRateChange);
            this.difficultyBar.MouseCaptureChanged += new System.EventHandler(this.difficultyRateChange);
            // 
            // difficultyGroup
            // 
            this.difficultyGroup.Controls.Add(this.difficultyValue);
            this.difficultyGroup.Controls.Add(this.difficultyLabel);
            this.difficultyGroup.Controls.Add(this.difficultyBar);
            this.difficultyGroup.Location = new System.Drawing.Point(12, 13);
            this.difficultyGroup.Name = "difficultyGroup";
            this.difficultyGroup.Size = new System.Drawing.Size(264, 104);
            this.difficultyGroup.TabIndex = 8;
            this.difficultyGroup.TabStop = false;
            this.difficultyGroup.Text = "Obtížnost";
            // 
            // difficultyValue
            // 
            this.difficultyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.difficultyValue.Location = new System.Drawing.Point(100, 67);
            this.difficultyValue.Name = "difficultyValue";
            this.difficultyValue.Size = new System.Drawing.Size(158, 31);
            this.difficultyValue.TabIndex = 9;
            this.difficultyValue.Text = "0%";
            this.difficultyValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Location = new System.Drawing.Point(6, 67);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(88, 31);
            this.difficultyLabel.TabIndex = 8;
            this.difficultyLabel.Text = "Hodnota:";
            this.difficultyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questionGroup
            // 
            this.questionGroup.Controls.Add(this.questionValue);
            this.questionGroup.Controls.Add(this.questionLabel);
            this.questionGroup.Controls.Add(this.questionBar);
            this.questionGroup.Location = new System.Drawing.Point(12, 123);
            this.questionGroup.Name = "questionGroup";
            this.questionGroup.Size = new System.Drawing.Size(264, 104);
            this.questionGroup.TabIndex = 10;
            this.questionGroup.TabStop = false;
            this.questionGroup.Text = "Počet otázek";
            // 
            // questionValue
            // 
            this.questionValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionValue.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.questionValue.Location = new System.Drawing.Point(100, 67);
            this.questionValue.Name = "questionValue";
            this.questionValue.Size = new System.Drawing.Size(158, 31);
            this.questionValue.TabIndex = 9;
            this.questionValue.Text = "10";
            this.questionValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questionLabel
            // 
            this.questionLabel.Location = new System.Drawing.Point(6, 67);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(88, 31);
            this.questionLabel.TabIndex = 8;
            this.questionLabel.Text = "Hodnota:";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questionBar
            // 
            this.questionBar.LargeChange = 1;
            this.questionBar.Location = new System.Drawing.Point(6, 19);
            this.questionBar.Maximum = 3;
            this.questionBar.Name = "questionBar";
            this.questionBar.Size = new System.Drawing.Size(247, 45);
            this.questionBar.TabIndex = 7;
            this.questionBar.ValueChanged += new System.EventHandler(this.questionRateChange);
            this.questionBar.MouseCaptureChanged += new System.EventHandler(this.questionRateChange);
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 241);
            this.Controls.Add(this.questionGroup);
            this.Controls.Add(this.difficultyGroup);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(305, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(305, 280);
            this.Name = "settingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nastavení";
            ((System.ComponentModel.ISupportInitialize)(this.difficultyBar)).EndInit();
            this.difficultyGroup.ResumeLayout(false);
            this.difficultyGroup.PerformLayout();
            this.questionGroup.ResumeLayout(false);
            this.questionGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar difficultyBar;
        private System.Windows.Forms.GroupBox difficultyGroup;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label difficultyValue;
        private System.Windows.Forms.GroupBox questionGroup;
        private System.Windows.Forms.Label questionValue;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TrackBar questionBar;
    }
}