
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
            this.OptionsButton = new System.Windows.Forms.Button();
            this.HelpButton = new System.Windows.Forms.Button();
            this.WordGuesserButton = new System.Windows.Forms.Button();
            this.PlayButton = new System.Windows.Forms.Button();
            this.MainMenuTitle = new System.Windows.Forms.Label();
            this.MainMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.Controls.Add(this.OptionsButton);
            this.MainMenuPanel.Controls.Add(this.HelpButton);
            this.MainMenuPanel.Controls.Add(this.WordGuesserButton);
            this.MainMenuPanel.Controls.Add(this.PlayButton);
            this.MainMenuPanel.Controls.Add(this.MainMenuTitle);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1264, 681);
            this.MainMenuPanel.TabIndex = 0;
            // 
            // OptionsButton
            // 
            this.OptionsButton.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsButton.Location = new System.Drawing.Point(808, 497);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(407, 145);
            this.OptionsButton.TabIndex = 4;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // HelpButton
            // 
            this.HelpButton.Font = new System.Drawing.Font("Segoe UI", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpButton.Location = new System.Drawing.Point(393, 497);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(407, 145);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Help";
            this.HelpButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // WordGuesserButton
            // 
            this.WordGuesserButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordGuesserButton.Location = new System.Drawing.Point(393, 346);
            this.WordGuesserButton.Name = "WordGuesserButton";
            this.WordGuesserButton.Size = new System.Drawing.Size(822, 145);
            this.WordGuesserButton.TabIndex = 2;
            this.WordGuesserButton.Text = "Word Guesser";
            this.WordGuesserButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.WordGuesserButton.UseVisualStyleBackColor = true;
            this.WordGuesserButton.Click += new System.EventHandler(this.WordGuesserButton_Click);
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(393, 195);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(822, 145);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play ";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // MainMenuTitle
            // 
            this.MainMenuTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MainMenuTitle.AutoSize = true;
            this.MainMenuTitle.Font = new System.Drawing.Font("Segoe UI", 140F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainMenuTitle.Location = new System.Drawing.Point(363, -56);
            this.MainMenuTitle.Name = "MainMenuTitle";
            this.MainMenuTitle.Size = new System.Drawing.Size(910, 248);
            this.MainMenuTitle.TabIndex = 0;
            this.MainMenuTitle.Text = "Hangman";
            this.MainMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "MainForm";
            this.Text = "Hangman";
            this.MainMenuPanel.ResumeLayout(false);
            this.MainMenuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Label MainMenuTitle;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button WordGuesserButton;
        private System.Windows.Forms.Button OptionsButton;
    }
}

