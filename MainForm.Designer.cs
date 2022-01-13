
using System.Collections.Generic;

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
            this.mainMenuPanel1 = new HangmanApp.MainMenuPanel();
            this.gamemodeMenuPanel1 = new HangmanApp.GamemodeMenuPanel();
            this.wordAssistMenuPanel1 = new HangmanApp.WordAssistMenuPanel();
            this.helpPagePanel1 = new HangmanApp.HelpPagePanel();
            this.optionsMenuPanel1 = new HangmanApp.OptionsMenuPanel();
            this.SuspendLayout();
            // 
            // mainMenuPanel1
            // 
            this.mainMenuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.mainMenuPanel1.MinimumSize = new System.Drawing.Size(1280, 720);
            this.mainMenuPanel1.Name = "mainMenuPanel1";
            this.mainMenuPanel1.Size = new System.Drawing.Size(1280, 720);
            this.mainMenuPanel1.TabIndex = 0;
            // 
            // gamemodeMenuPanel1
            // 
            this.gamemodeMenuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamemodeMenuPanel1.Location = new System.Drawing.Point(0, 0);
            this.gamemodeMenuPanel1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.gamemodeMenuPanel1.MinimumSize = new System.Drawing.Size(1280, 720);
            this.gamemodeMenuPanel1.Name = "gamemodeMenuPanel1";
            this.gamemodeMenuPanel1.Size = new System.Drawing.Size(1280, 720);
            this.gamemodeMenuPanel1.TabIndex = 1;
            // 
            // wordAssistMenuPanel1
            // 
            this.wordAssistMenuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wordAssistMenuPanel1.Location = new System.Drawing.Point(0, 0);
            this.wordAssistMenuPanel1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.wordAssistMenuPanel1.MinimumSize = new System.Drawing.Size(1280, 720);
            this.wordAssistMenuPanel1.Name = "wordAssistMenuPanel1";
            this.wordAssistMenuPanel1.Size = new System.Drawing.Size(1280, 720);
            this.wordAssistMenuPanel1.TabIndex = 2;
            // 
            // helpPagePanel1
            // 
            this.helpPagePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpPagePanel1.Location = new System.Drawing.Point(0, 0);
            this.helpPagePanel1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.helpPagePanel1.MinimumSize = new System.Drawing.Size(1280, 720);
            this.helpPagePanel1.Name = "helpPagePanel1";
            this.helpPagePanel1.Size = new System.Drawing.Size(1280, 720);
            this.helpPagePanel1.TabIndex = 3;
            // 
            // optionsMenuPanel1
            // 
            this.optionsMenuPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsMenuPanel1.Location = new System.Drawing.Point(0, 0);
            this.optionsMenuPanel1.MaximumSize = new System.Drawing.Size(1280, 720);
            this.optionsMenuPanel1.MinimumSize = new System.Drawing.Size(1280, 720);
            this.optionsMenuPanel1.Name = "optionsMenuPanel1";
            this.optionsMenuPanel1.Size = new System.Drawing.Size(1280, 720);
            this.optionsMenuPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.mainMenuPanel1);
            this.Controls.Add(this.gamemodeMenuPanel1);
            this.Controls.Add(this.wordAssistMenuPanel1);
            this.Controls.Add(this.helpPagePanel1);
            this.Controls.Add(this.optionsMenuPanel1);
            this.Name = "MainForm";
            this.Text = "Hangman";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MainMenuPanel mainMenuPanel1;
        private GamemodeMenuPanel gamemodeMenuPanel1;
        private WordAssistMenuPanel wordAssistMenuPanel1;
        private HelpPagePanel helpPagePanel1;
        private OptionsMenuPanel optionsMenuPanel1;
    }
}

