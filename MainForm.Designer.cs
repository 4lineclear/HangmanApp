
namespace HangmanApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.MMP_OptionsButton = new System.Windows.Forms.Button();
            this.MMP_HelpButton = new System.Windows.Forms.Button();
            this.MMP_WordAssistButton = new System.Windows.Forms.Button();
            this.MMP_PlayButton = new System.Windows.Forms.Button();
            this.MainMenuTitle = new System.Windows.Forms.Label();
            this.WordAssistMenuPanel = new System.Windows.Forms.Panel();
            this.WAM_IncorrectLettersLabel = new System.Windows.Forms.Label();
            this.WAM_Letters_Guessed = new System.Windows.Forms.CheckedListBox();
            this.WAM_WordCountSliderLabel = new System.Windows.Forms.Label();
            this.WAM_WordCountSlider = new System.Windows.Forms.TrackBar();
            this.WordAssistMenuTitle = new System.Windows.Forms.Label();
            this.WAM_BackButton = new System.Windows.Forms.Button();
            this.GamemodePanel = new System.Windows.Forms.Panel();
            this.GP_LocalNetworkButton = new System.Windows.Forms.Button();
            this.GP_MultiplayerButton = new System.Windows.Forms.Button();
            this.GP_SingeplayerButton = new System.Windows.Forms.Button();
            this.GamemodeTitle = new System.Windows.Forms.Label();
            this.GP_BackButton = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.WordAssistMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WAM_WordCountSlider)).BeginInit();
            this.GamemodePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainMenuPanel.Controls.Add(this.MMP_OptionsButton);
            this.MainMenuPanel.Controls.Add(this.MMP_HelpButton);
            this.MainMenuPanel.Controls.Add(this.MMP_WordAssistButton);
            this.MainMenuPanel.Controls.Add(this.MMP_PlayButton);
            this.MainMenuPanel.Controls.Add(this.MainMenuTitle);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1264, 681);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // MMP_OptionsButton
            // 
            this.MMP_OptionsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MMP_OptionsButton.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MMP_OptionsButton.Location = new System.Drawing.Point(808, 497);
            this.MMP_OptionsButton.Name = "MMP_OptionsButton";
            this.MMP_OptionsButton.Size = new System.Drawing.Size(407, 145);
            this.MMP_OptionsButton.TabIndex = 4;
            this.MMP_OptionsButton.Text = "Options";
            this.MMP_OptionsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MMP_OptionsButton.UseVisualStyleBackColor = true;
            this.MMP_OptionsButton.Click += new System.EventHandler(this.MMP_OptionsButton_Click);
            // 
            // MMP_HelpButton
            // 
            this.MMP_HelpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MMP_HelpButton.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MMP_HelpButton.Location = new System.Drawing.Point(393, 497);
            this.MMP_HelpButton.Name = "MMP_HelpButton";
            this.MMP_HelpButton.Size = new System.Drawing.Size(407, 145);
            this.MMP_HelpButton.TabIndex = 3;
            this.MMP_HelpButton.Text = "Help";
            this.MMP_HelpButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MMP_HelpButton.UseVisualStyleBackColor = true;
            this.MMP_HelpButton.Click += new System.EventHandler(this.MMP_HelpButton_Click);
            // 
            // MMP_WordAssistButton
            // 
            this.MMP_WordAssistButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MMP_WordAssistButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MMP_WordAssistButton.Location = new System.Drawing.Point(393, 346);
            this.MMP_WordAssistButton.Name = "MMP_WordAssistButton";
            this.MMP_WordAssistButton.Size = new System.Drawing.Size(822, 145);
            this.MMP_WordAssistButton.TabIndex = 2;
            this.MMP_WordAssistButton.Text = "Word Assist";
            this.MMP_WordAssistButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MMP_WordAssistButton.UseVisualStyleBackColor = true;
            this.MMP_WordAssistButton.Click += new System.EventHandler(this.MMP_WordAssistButton_Click);
            // 
            // MMP_PlayButton
            // 
            this.MMP_PlayButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MMP_PlayButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MMP_PlayButton.Location = new System.Drawing.Point(393, 195);
            this.MMP_PlayButton.Name = "MMP_PlayButton";
            this.MMP_PlayButton.Size = new System.Drawing.Size(822, 145);
            this.MMP_PlayButton.TabIndex = 1;
            this.MMP_PlayButton.Text = "Play ";
            this.MMP_PlayButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MMP_PlayButton.UseVisualStyleBackColor = true;
            this.MMP_PlayButton.Click += new System.EventHandler(this.MMP_PlayButton_Click);
            // 
            // MainMenuTitle
            // 
            this.MainMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainMenuTitle.AutoSize = true;
            this.MainMenuTitle.Font = new System.Drawing.Font("Segoe UI", 140F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuTitle.Location = new System.Drawing.Point(363, -56);
            this.MainMenuTitle.Name = "MainMenuTitle";
            this.MainMenuTitle.Size = new System.Drawing.Size(910, 248);
            this.MainMenuTitle.TabIndex = 0;
            this.MainMenuTitle.Text = "Hangman";
            this.MainMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WordAssistMenuPanel
            // 
            this.WordAssistMenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WordAssistMenuPanel.Controls.Add(this.WAM_IncorrectLettersLabel);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_Letters_Guessed);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_WordCountSliderLabel);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_WordCountSlider);
            this.WordAssistMenuPanel.Controls.Add(this.WordAssistMenuTitle);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_BackButton);
            this.WordAssistMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.WordAssistMenuPanel.Name = "WordAssistMenuPanel";
            this.WordAssistMenuPanel.Size = new System.Drawing.Size(1264, 681);
            this.WordAssistMenuPanel.TabIndex = 5;
            this.WordAssistMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.WordAssistMenuPanel_Paint);
            // 
            // WAM_IncorrectLettersLabel
            // 
            this.WAM_IncorrectLettersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_IncorrectLettersLabel.AutoSize = true;
            this.WAM_IncorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_IncorrectLettersLabel.Location = new System.Drawing.Point(1091, 142);
            this.WAM_IncorrectLettersLabel.Name = "WAM_IncorrectLettersLabel";
            this.WAM_IncorrectLettersLabel.Size = new System.Drawing.Size(170, 30);
            this.WAM_IncorrectLettersLabel.TabIndex = 7;
            this.WAM_IncorrectLettersLabel.Text = "Incorrect Letters";
            // 
            // WAM_Letters_Guessed
            // 
            this.WAM_Letters_Guessed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_Letters_Guessed.CheckOnClick = true;
            this.WAM_Letters_Guessed.Cursor = System.Windows.Forms.Cursors.Default;
            this.WAM_Letters_Guessed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_Letters_Guessed.FormattingEnabled = true;
            this.WAM_Letters_Guessed.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.WAM_Letters_Guessed.Location = new System.Drawing.Point(1091, 175);
            this.WAM_Letters_Guessed.Name = "WAM_Letters_Guessed";
            this.WAM_Letters_Guessed.Size = new System.Drawing.Size(170, 472);
            this.WAM_Letters_Guessed.TabIndex = 6;
            // 
            // WAM_WordCountSliderLabel
            // 
            this.WAM_WordCountSliderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_WordCountSliderLabel.AutoSize = true;
            this.WAM_WordCountSliderLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_WordCountSliderLabel.Location = new System.Drawing.Point(363, 142);
            this.WAM_WordCountSliderLabel.Name = "WAM_WordCountSliderLabel";
            this.WAM_WordCountSliderLabel.Size = new System.Drawing.Size(148, 30);
            this.WAM_WordCountSliderLabel.TabIndex = 4;
            this.WAM_WordCountSliderLabel.Text = "Word Count:3";
            // 
            // WAM_WordCountSlider
            // 
            this.WAM_WordCountSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_WordCountSlider.Location = new System.Drawing.Point(363, 175);
            this.WAM_WordCountSlider.Maximum = 30;
            this.WAM_WordCountSlider.Minimum = 3;
            this.WAM_WordCountSlider.Name = "WAM_WordCountSlider";
            this.WAM_WordCountSlider.Size = new System.Drawing.Size(733, 45);
            this.WAM_WordCountSlider.TabIndex = 3;
            this.WAM_WordCountSlider.Value = 3;
            this.WAM_WordCountSlider.Scroll += new System.EventHandler(this.WAM_WordCountSlider_Scroll);
            // 
            // WordAssistMenuTitle
            // 
            this.WordAssistMenuTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WordAssistMenuTitle.AutoSize = true;
            this.WordAssistMenuTitle.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordAssistMenuTitle.Location = new System.Drawing.Point(347, 0);
            this.WordAssistMenuTitle.Name = "WordAssistMenuTitle";
            this.WordAssistMenuTitle.Size = new System.Drawing.Size(917, 142);
            this.WordAssistMenuTitle.TabIndex = 2;
            this.WordAssistMenuTitle.Text = "Word Assist Menu";
            // 
            // WAM_BackButton
            // 
            this.WAM_BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_BackButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_BackButton.Location = new System.Drawing.Point(0, 0);
            this.WAM_BackButton.Name = "WAM_BackButton";
            this.WAM_BackButton.Size = new System.Drawing.Size(112, 60);
            this.WAM_BackButton.TabIndex = 1;
            this.WAM_BackButton.Text = "Back";
            this.WAM_BackButton.UseVisualStyleBackColor = true;
            this.WAM_BackButton.Click += new System.EventHandler(this.WAM_BackButton_Click);
            // 
            // GamemodePanel
            // 
            this.GamemodePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamemodePanel.Controls.Add(this.GP_LocalNetworkButton);
            this.GamemodePanel.Controls.Add(this.GP_MultiplayerButton);
            this.GamemodePanel.Controls.Add(this.GP_SingeplayerButton);
            this.GamemodePanel.Controls.Add(this.GamemodeTitle);
            this.GamemodePanel.Controls.Add(this.GP_BackButton);
            this.GamemodePanel.Location = new System.Drawing.Point(0, 0);
            this.GamemodePanel.Name = "GamemodePanel";
            this.GamemodePanel.Size = new System.Drawing.Size(1264, 681);
            this.GamemodePanel.TabIndex = 5;
            // 
            // GP_LocalNetworkButton
            // 
            this.GP_LocalNetworkButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GP_LocalNetworkButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GP_LocalNetworkButton.Location = new System.Drawing.Point(393, 497);
            this.GP_LocalNetworkButton.Name = "GP_LocalNetworkButton";
            this.GP_LocalNetworkButton.Size = new System.Drawing.Size(822, 145);
            this.GP_LocalNetworkButton.TabIndex = 4;
            this.GP_LocalNetworkButton.Text = "Local Network";
            this.GP_LocalNetworkButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GP_LocalNetworkButton.UseVisualStyleBackColor = true;
            this.GP_LocalNetworkButton.Click += new System.EventHandler(this.GP_LocalNetworkButton_Click);
            // 
            // GP_MultiplayerButton
            // 
            this.GP_MultiplayerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GP_MultiplayerButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GP_MultiplayerButton.Location = new System.Drawing.Point(393, 346);
            this.GP_MultiplayerButton.Name = "GP_MultiplayerButton";
            this.GP_MultiplayerButton.Size = new System.Drawing.Size(822, 145);
            this.GP_MultiplayerButton.TabIndex = 3;
            this.GP_MultiplayerButton.Text = "Multiplayer";
            this.GP_MultiplayerButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GP_MultiplayerButton.UseVisualStyleBackColor = true;
            this.GP_MultiplayerButton.Click += new System.EventHandler(this.GP_MultiplayerButton_Click);
            // 
            // GP_SingeplayerButton
            // 
            this.GP_SingeplayerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GP_SingeplayerButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GP_SingeplayerButton.Location = new System.Drawing.Point(393, 195);
            this.GP_SingeplayerButton.Name = "GP_SingeplayerButton";
            this.GP_SingeplayerButton.Size = new System.Drawing.Size(822, 145);
            this.GP_SingeplayerButton.TabIndex = 2;
            this.GP_SingeplayerButton.Text = "Singleplayer";
            this.GP_SingeplayerButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.GP_SingeplayerButton.UseVisualStyleBackColor = true;
            this.GP_SingeplayerButton.Click += new System.EventHandler(this.GP_SingeplayerButton_Click);
            // 
            // GamemodeTitle
            // 
            this.GamemodeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamemodeTitle.AutoSize = true;
            this.GamemodeTitle.Font = new System.Drawing.Font("Segoe UI", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GamemodeTitle.Location = new System.Drawing.Point(352, -44);
            this.GamemodeTitle.Name = "GamemodeTitle";
            this.GamemodeTitle.Size = new System.Drawing.Size(912, 212);
            this.GamemodeTitle.TabIndex = 1;
            this.GamemodeTitle.Text = "Gamemode";
            // 
            // GP_BackButton
            // 
            this.GP_BackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GP_BackButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GP_BackButton.Location = new System.Drawing.Point(0, 0);
            this.GP_BackButton.Name = "GP_BackButton";
            this.GP_BackButton.Size = new System.Drawing.Size(112, 60);
            this.GP_BackButton.TabIndex = 0;
            this.GP_BackButton.Text = "Back";
            this.GP_BackButton.UseVisualStyleBackColor = true;
            this.GP_BackButton.Click += new System.EventHandler(this.GP_BackButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.GamemodePanel);
            this.Controls.Add(this.WordAssistMenuPanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.WordAssistMenuPanel.ResumeLayout(false);
            this.WordAssistMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WAM_WordCountSlider)).EndInit();
            this.GamemodePanel.ResumeLayout(false);
            this.GamemodePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Label MainMenuTitle;
        private System.Windows.Forms.Button MMP_PlayButton;
        private System.Windows.Forms.Button MMP_HelpButton;
        private System.Windows.Forms.Button MMP_WordAssistButton;
        private System.Windows.Forms.Button MMP_OptionsButton;
        private System.Windows.Forms.Panel GamemodePanel;
        private System.Windows.Forms.Button GP_BackButton;
        private System.Windows.Forms.Label GamemodeTitle;
        private System.Windows.Forms.Button GP_LocalNetworkButton;
        private System.Windows.Forms.Button GP_MultiplayerButton;
        private System.Windows.Forms.Button GP_SingeplayerButton;
        private System.Windows.Forms.Panel WordAssistMenuPanel;
        private System.Windows.Forms.Label WordAssistMenuTitle;
        private System.Windows.Forms.Button WAM_BackButton;
        private System.Windows.Forms.TrackBar WAM_WordCountSlider;
        private System.Windows.Forms.Label WAM_WordCountSliderLabel;
        private System.Windows.Forms.Label WAM_IncorrectLettersLabel;
        private System.Windows.Forms.CheckedListBox WAM_Letters_Guessed;
    }
}

