
namespace HangmanApp
{
    partial class MainMenuPanel
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
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HelpButton = new ChildButton();
            this.WordAssistButton = new ChildButton();
            this.MainTitle = new System.Windows.Forms.Label();
            this.PlayButton = new ChildButton();
            this.OptionsButton = new ChildButton();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 13;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999961F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999961F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.000001F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.000001F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999956F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999956F));
            this.MainPanel.Controls.Add(this.OptionsButton, 8, 7);
            this.MainPanel.Controls.Add(this.HelpButton, 4, 7);
            this.MainPanel.Controls.Add(this.WordAssistButton, 4, 5);
            this.MainPanel.Controls.Add(this.MainTitle, 4, 0);
            this.MainPanel.Controls.Add(this.PlayButton, 4, 3);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 10;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 0;
            // 
            // HelpButton
            // 
            this.HelpButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.HelpButton, 4);
            this.HelpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HelpButton.Location = new System.Drawing.Point(450, 531);
            this.HelpButton.Name = "HelpButton";
            this.MainPanel.SetRowSpan(this.HelpButton, 2);
            this.HelpButton.Size = new System.Drawing.Size(377, 138);
            this.HelpButton.TabIndex = 3;
            this.HelpButton.Text = "Help";
            this.HelpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelpButton.UseVisualStyleBackColor = true;
            // 
            // WordAssistButton
            // 
            this.WordAssistButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.WordAssistButton, 8);
            this.WordAssistButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordAssistButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordAssistButton.Location = new System.Drawing.Point(450, 387);
            this.WordAssistButton.Name = "WordAssistButton";
            this.MainPanel.SetRowSpan(this.WordAssistButton, 2);
            this.WordAssistButton.Size = new System.Drawing.Size(760, 138);
            this.WordAssistButton.TabIndex = 2;
            this.WordAssistButton.Text = "Word Assist";
            this.WordAssistButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WordAssistButton.UseVisualStyleBackColor = true;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MainTitle, 8);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 115F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(450, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainPanel.SetRowSpan(this.MainTitle, 3);
            this.MainTitle.Size = new System.Drawing.Size(760, 240);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Hangman";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlayButton
            // 
            this.PlayButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.PlayButton, 8);
            this.PlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayButton.Location = new System.Drawing.Point(450, 243);
            this.PlayButton.Name = "PlayButton";
            this.MainPanel.SetRowSpan(this.PlayButton, 2);
            this.PlayButton.Size = new System.Drawing.Size(760, 138);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PlayButton.UseVisualStyleBackColor = true;
            // 
            // OptionsButton
            // 
            this.OptionsButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.OptionsButton, 4);
            this.OptionsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsButton.Location = new System.Drawing.Point(833, 531);
            this.OptionsButton.Name = "OptionsButton";
            this.MainPanel.SetRowSpan(this.OptionsButton, 2);
            this.OptionsButton.Size = new System.Drawing.Size(377, 138);
            this.OptionsButton.TabIndex = 4;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OptionsButton.UseVisualStyleBackColor = true;
            // 
            // MainMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainMenuPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainTitle;
        private ChildButton PlayButton;
        private ChildButton WordAssistButton;
        private ChildButton HelpButton;
        private ChildButton OptionsButton;
    }
}
