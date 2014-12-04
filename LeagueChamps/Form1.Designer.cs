namespace LeagueChamps
{
    partial class mainForm
    {
        /// <summary>
        /// Vyžadovaná proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolnit všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by měl být spravovaný prostředek odstraněn, jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu návrháře - neupravovat
        /// obsah této metody s editorem kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.hraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.restartMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.infMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.setMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.informationGoup = new System.Windows.Forms.GroupBox();
            this.lifesValue = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.timeLimitValue = new System.Windows.Forms.Label();
            this.lifesLabel = new System.Windows.Forms.Label();
            this.answerStateValue = new System.Windows.Forms.Label();
            this.questionOverviewValue = new System.Windows.Forms.Label();
            this.timeLimitLabel = new System.Windows.Forms.Label();
            this.answerStateLabel = new System.Windows.Forms.Label();
            this.questionOverviewLabel = new System.Windows.Forms.Label();
            this.settingsOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.answerField = new System.Windows.Forms.TextBox();
            this.answerButton = new System.Windows.Forms.Button();
            this.answerGroup = new System.Windows.Forms.GroupBox();
            this.afterNameLabel = new System.Windows.Forms.Label();
            this.beforeNameLabel = new System.Windows.Forms.Label();
            this.helpOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.controlGroup = new System.Windows.Forms.GroupBox();
            this.nextQButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lifeCheckTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.informationGoup.SuspendLayout();
            this.answerGroup.SuspendLayout();
            this.controlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programMenu,
            this.infMenu,
            this.setMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(309, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programMenu
            // 
            this.programMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hraToolStripMenuItem,
            this.closeMenu});
            this.programMenu.Name = "programMenu";
            this.programMenu.Size = new System.Drawing.Size(65, 20);
            this.programMenu.Text = "Program";
            // 
            // hraToolStripMenuItem
            // 
            this.hraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startMenu,
            this.restartMenu,
            this.resetMenu});
            this.hraToolStripMenuItem.Name = "hraToolStripMenuItem";
            this.hraToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.hraToolStripMenuItem.Text = "Hra";
            // 
            // startMenu
            // 
            this.startMenu.Name = "startMenu";
            this.startMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.startMenu.Size = new System.Drawing.Size(184, 22);
            this.startMenu.Text = "Spustit";
            this.startMenu.Click += new System.EventHandler(this.StartGame);
            // 
            // restartMenu
            // 
            this.restartMenu.Enabled = false;
            this.restartMenu.Name = "restartMenu";
            this.restartMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
            this.restartMenu.Size = new System.Drawing.Size(184, 22);
            this.restartMenu.Text = "Restartovat";
            this.restartMenu.Click += new System.EventHandler(this.RestartGame);
            // 
            // resetMenu
            // 
            this.resetMenu.Enabled = false;
            this.resetMenu.Name = "resetMenu";
            this.resetMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F7)));
            this.resetMenu.Size = new System.Drawing.Size(184, 22);
            this.resetMenu.Text = "Resetovat";
            this.resetMenu.Click += new System.EventHandler(this.ResetGame);
            // 
            // closeMenu
            // 
            this.closeMenu.Name = "closeMenu";
            this.closeMenu.Size = new System.Drawing.Size(115, 22);
            this.closeMenu.Text = "Ukončit";
            this.closeMenu.Click += new System.EventHandler(this.Close);
            // 
            // infMenu
            // 
            this.infMenu.Name = "infMenu";
            this.infMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.infMenu.Size = new System.Drawing.Size(73, 20);
            this.infMenu.Text = "Nápověda";
            this.infMenu.Click += new System.EventHandler(this.openHelp);
            // 
            // setMenu
            // 
            this.setMenu.Name = "setMenu";
            this.setMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.setMenu.Size = new System.Drawing.Size(71, 20);
            this.setMenu.Text = "Nastavení";
            this.setMenu.Click += new System.EventHandler(this.openSettings);
            // 
            // informationGoup
            // 
            this.informationGoup.Controls.Add(this.lifesValue);
            this.informationGoup.Controls.Add(this.progressBar);
            this.informationGoup.Controls.Add(this.timeLimitValue);
            this.informationGoup.Controls.Add(this.lifesLabel);
            this.informationGoup.Controls.Add(this.answerStateValue);
            this.informationGoup.Controls.Add(this.questionOverviewValue);
            this.informationGoup.Controls.Add(this.timeLimitLabel);
            this.informationGoup.Controls.Add(this.answerStateLabel);
            this.informationGoup.Controls.Add(this.questionOverviewLabel);
            this.informationGoup.Location = new System.Drawing.Point(12, 27);
            this.informationGoup.Name = "informationGoup";
            this.informationGoup.Size = new System.Drawing.Size(284, 172);
            this.informationGoup.TabIndex = 1;
            this.informationGoup.TabStop = false;
            this.informationGoup.Text = "Informace";
            // 
            // lifesValue
            // 
            this.lifesValue.Location = new System.Drawing.Point(120, 47);
            this.lifesValue.Name = "lifesValue";
            this.lifesValue.Size = new System.Drawing.Size(158, 31);
            this.lifesValue.TabIndex = 7;
            this.lifesValue.Text = "-/-";
            this.lifesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 143);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(272, 23);
            this.progressBar.TabIndex = 4;
            // 
            // timeLimitValue
            // 
            this.timeLimitValue.Location = new System.Drawing.Point(120, 109);
            this.timeLimitValue.Name = "timeLimitValue";
            this.timeLimitValue.Size = new System.Drawing.Size(158, 31);
            this.timeLimitValue.TabIndex = 5;
            this.timeLimitValue.Text = "-";
            this.timeLimitValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lifesLabel
            // 
            this.lifesLabel.Location = new System.Drawing.Point(6, 47);
            this.lifesLabel.Name = "lifesLabel";
            this.lifesLabel.Size = new System.Drawing.Size(108, 31);
            this.lifesLabel.TabIndex = 6;
            this.lifesLabel.Text = "Počet životů:";
            this.lifesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // answerStateValue
            // 
            this.answerStateValue.Location = new System.Drawing.Point(120, 78);
            this.answerStateValue.Name = "answerStateValue";
            this.answerStateValue.Size = new System.Drawing.Size(158, 31);
            this.answerStateValue.TabIndex = 4;
            this.answerStateValue.Text = "-";
            this.answerStateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questionOverviewValue
            // 
            this.questionOverviewValue.Location = new System.Drawing.Point(120, 16);
            this.questionOverviewValue.Name = "questionOverviewValue";
            this.questionOverviewValue.Size = new System.Drawing.Size(158, 31);
            this.questionOverviewValue.TabIndex = 3;
            this.questionOverviewValue.Text = "-/-";
            this.questionOverviewValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timeLimitLabel
            // 
            this.timeLimitLabel.Location = new System.Drawing.Point(6, 109);
            this.timeLimitLabel.Name = "timeLimitLabel";
            this.timeLimitLabel.Size = new System.Drawing.Size(108, 31);
            this.timeLimitLabel.TabIndex = 2;
            this.timeLimitLabel.Text = "Časový limit:";
            this.timeLimitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // answerStateLabel
            // 
            this.answerStateLabel.Location = new System.Drawing.Point(6, 78);
            this.answerStateLabel.Name = "answerStateLabel";
            this.answerStateLabel.Size = new System.Drawing.Size(108, 31);
            this.answerStateLabel.TabIndex = 1;
            this.answerStateLabel.Text = "Stav odpovědi:";
            this.answerStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // questionOverviewLabel
            // 
            this.questionOverviewLabel.Location = new System.Drawing.Point(6, 16);
            this.questionOverviewLabel.Name = "questionOverviewLabel";
            this.questionOverviewLabel.Size = new System.Drawing.Size(108, 31);
            this.questionOverviewLabel.TabIndex = 0;
            this.questionOverviewLabel.Text = "Aktuální otázka:";
            this.questionOverviewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // settingsOpenTimer
            // 
            this.settingsOpenTimer.Tick += new System.EventHandler(this.settingsOpenedCheck);
            // 
            // answerField
            // 
            this.answerField.Location = new System.Drawing.Point(101, 22);
            this.answerField.Name = "answerField";
            this.answerField.Size = new System.Drawing.Size(85, 20);
            this.answerField.TabIndex = 2;
            this.answerField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.answerEnterKey);
            // 
            // answerButton
            // 
            this.answerButton.Location = new System.Drawing.Point(6, 19);
            this.answerButton.Name = "answerButton";
            this.answerButton.Size = new System.Drawing.Size(87, 23);
            this.answerButton.TabIndex = 3;
            this.answerButton.Text = "Odeslat";
            this.answerButton.UseVisualStyleBackColor = true;
            this.answerButton.Click += new System.EventHandler(this.answer);
            // 
            // answerGroup
            // 
            this.answerGroup.Controls.Add(this.afterNameLabel);
            this.answerGroup.Controls.Add(this.beforeNameLabel);
            this.answerGroup.Controls.Add(this.answerField);
            this.answerGroup.Location = new System.Drawing.Point(12, 205);
            this.answerGroup.Name = "answerGroup";
            this.answerGroup.Size = new System.Drawing.Size(285, 55);
            this.answerGroup.TabIndex = 6;
            this.answerGroup.TabStop = false;
            this.answerGroup.Text = "Doplnění";
            // 
            // afterNameLabel
            // 
            this.afterNameLabel.Location = new System.Drawing.Point(192, 16);
            this.afterNameLabel.Name = "afterNameLabel";
            this.afterNameLabel.Size = new System.Drawing.Size(87, 31);
            this.afterNameLabel.TabIndex = 7;
            this.afterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // beforeNameLabel
            // 
            this.beforeNameLabel.Location = new System.Drawing.Point(7, 16);
            this.beforeNameLabel.Name = "beforeNameLabel";
            this.beforeNameLabel.Size = new System.Drawing.Size(88, 31);
            this.beforeNameLabel.TabIndex = 6;
            this.beforeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // helpOpenTimer
            // 
            this.helpOpenTimer.Tick += new System.EventHandler(this.helpOpenedCheck);
            // 
            // controlGroup
            // 
            this.controlGroup.Controls.Add(this.nextQButton);
            this.controlGroup.Controls.Add(this.restartButton);
            this.controlGroup.Controls.Add(this.answerButton);
            this.controlGroup.Location = new System.Drawing.Point(12, 266);
            this.controlGroup.Name = "controlGroup";
            this.controlGroup.Size = new System.Drawing.Size(285, 49);
            this.controlGroup.TabIndex = 7;
            this.controlGroup.TabStop = false;
            this.controlGroup.Text = "Ovládání";
            // 
            // nextQButton
            // 
            this.nextQButton.Location = new System.Drawing.Point(192, 19);
            this.nextQButton.Name = "nextQButton";
            this.nextQButton.Size = new System.Drawing.Size(87, 23);
            this.nextQButton.TabIndex = 5;
            this.nextQButton.Text = "Další otázka";
            this.nextQButton.UseVisualStyleBackColor = true;
            this.nextQButton.Click += new System.EventHandler(this.NextQGame);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(99, 19);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(87, 23);
            this.restartButton.TabIndex = 4;
            this.restartButton.Text = "Restartovat";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.RestartGame);
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 1000;
            this.progressTimer.Tick += new System.EventHandler(this.progressTick);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerTick);
            // 
            // lifeCheckTimer
            // 
            this.lifeCheckTimer.Interval = 4000;
            this.lifeCheckTimer.Tick += new System.EventHandler(this.lifeCheck);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 328);
            this.Controls.Add(this.controlGroup);
            this.Controls.Add(this.answerGroup);
            this.Controls.Add(this.informationGoup);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(325, 367);
            this.MinimumSize = new System.Drawing.Size(325, 367);
            this.Name = "mainForm";
            this.Text = "LeagueChamps v1.4";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.informationGoup.ResumeLayout(false);
            this.answerGroup.ResumeLayout(false);
            this.answerGroup.PerformLayout();
            this.controlGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox answerField;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.GroupBox informationGoup;
        public System.Windows.Forms.Timer settingsOpenTimer;
        public System.Windows.Forms.Button answerButton;
        public System.Windows.Forms.Label questionOverviewValue;
        public System.Windows.Forms.Label timeLimitLabel;
        public System.Windows.Forms.Label answerStateLabel;
        public System.Windows.Forms.Label questionOverviewLabel;
        public System.Windows.Forms.Label timeLimitValue;
        public System.Windows.Forms.Label answerStateValue;
        public System.Windows.Forms.ProgressBar progressBar;
        public System.Windows.Forms.ToolStripMenuItem programMenu;
        public System.Windows.Forms.ToolStripMenuItem closeMenu;
        public System.Windows.Forms.ToolStripMenuItem setMenu;
        public System.Windows.Forms.ToolStripMenuItem infMenu;
        public System.Windows.Forms.GroupBox answerGroup;
        public System.Windows.Forms.Label afterNameLabel;
        public System.Windows.Forms.Label beforeNameLabel;
        public System.Windows.Forms.Timer helpOpenTimer;
        public System.Windows.Forms.Label lifesValue;
        public System.Windows.Forms.Label lifesLabel;
        private System.Windows.Forms.GroupBox controlGroup;
        public System.Windows.Forms.Timer progressTimer;
        public System.Windows.Forms.Button nextQButton;
        public System.Windows.Forms.Button restartButton;
        public System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Timer lifeCheckTimer;
        public System.Windows.Forms.ToolStripMenuItem hraToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem startMenu;
        public System.Windows.Forms.ToolStripMenuItem restartMenu;
        public System.Windows.Forms.ToolStripMenuItem resetMenu;
    }
}

