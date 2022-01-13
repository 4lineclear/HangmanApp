
namespace HangmanApp
{
    partial class WordAssistMenuPanel
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
            this.CorrectLettersLabel = new System.Windows.Forms.Label();
            this.LettersGuessedListBox = new System.Windows.Forms.CheckedListBox();
            this.IncorrectLettersLabel = new System.Windows.Forms.Label();
            this.MainTitle = new System.Windows.Forms.Label();
            this.BackButton = new HangmanApp.ParentButton();
            this.WordLengthLabel = new System.Windows.Forms.Label();
            this.WordLengthSlider = new System.Windows.Forms.TrackBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.CorrectLettersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordLengthSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 12;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.99996F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.99996F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00002F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999955F));
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.999955F));
            this.MainPanel.Controls.Add(this.CorrectLettersLabel, 4, 7);
            this.MainPanel.Controls.Add(this.LettersGuessedListBox, 4, 6);
            this.MainPanel.Controls.Add(this.IncorrectLettersLabel, 4, 5);
            this.MainPanel.Controls.Add(this.MainTitle, 4, 0);
            this.MainPanel.Controls.Add(this.BackButton, 0, 0);
            this.MainPanel.Controls.Add(this.WordLengthLabel, 4, 3);
            this.MainPanel.Controls.Add(this.WordLengthSlider, 4, 4);
            this.MainPanel.Controls.Add(this.StartButton, 9, 9);
            this.MainPanel.Controls.Add(this.CorrectLettersPanel, 4, 8);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 11;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882405F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.441203F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33605F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.66803F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.66803F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.00005F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33605F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.66803F));
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 0;
            // 
            // CorrectLettersLabel
            // 
            this.CorrectLettersLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.CorrectLettersLabel, 3);
            this.CorrectLettersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorrectLettersLabel.Location = new System.Drawing.Point(450, 456);
            this.CorrectLettersLabel.Name = "CorrectLettersLabel";
            this.CorrectLettersLabel.Size = new System.Drawing.Size(313, 46);
            this.CorrectLettersLabel.TabIndex = 8;
            this.CorrectLettersLabel.Text = "Correct Letters";
            // 
            // LettersGuessedListBox
            // 
            this.LettersGuessedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.LettersGuessedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LettersGuessedListBox.CheckOnClick = true;
            this.MainPanel.SetColumnSpan(this.LettersGuessedListBox, 7);
            this.LettersGuessedListBox.ColumnWidth = 58;
            this.LettersGuessedListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.LettersGuessedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LettersGuessedListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LettersGuessedListBox.FormattingEnabled = true;
            this.LettersGuessedListBox.Items.AddRange(new object[] {
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
            this.LettersGuessedListBox.Location = new System.Drawing.Point(450, 361);
            this.LettersGuessedListBox.MultiColumn = true;
            this.LettersGuessedListBox.Name = "LettersGuessedListBox";
            this.LettersGuessedListBox.Size = new System.Drawing.Size(760, 66);
            this.LettersGuessedListBox.TabIndex = 7;
            // 
            // IncorrectLettersLabel
            // 
            this.IncorrectLettersLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.IncorrectLettersLabel, 3);
            this.IncorrectLettersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IncorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncorrectLettersLabel.Location = new System.Drawing.Point(450, 312);
            this.IncorrectLettersLabel.Name = "IncorrectLettersLabel";
            this.IncorrectLettersLabel.Size = new System.Drawing.Size(313, 46);
            this.IncorrectLettersLabel.TabIndex = 5;
            this.IncorrectLettersLabel.Text = "Incorrect Letters";
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MainTitle, 7);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(450, 0);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainPanel.SetRowSpan(this.MainTitle, 3);
            this.MainTitle.Size = new System.Drawing.Size(760, 190);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Word Assist Menu";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackButton
            // 
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(122, 57);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // WordLengthLabel
            // 
            this.WordLengthLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.WordLengthLabel, 3);
            this.WordLengthLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WordLengthLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordLengthLabel.Location = new System.Drawing.Point(450, 192);
            this.WordLengthLabel.Name = "WordLengthLabel";
            this.WordLengthLabel.Size = new System.Drawing.Size(313, 46);
            this.WordLengthLabel.TabIndex = 2;
            this.WordLengthLabel.Text = "Word Length: 2";
            // 
            // WordLengthSlider
            // 
            this.MainPanel.SetColumnSpan(this.WordLengthSlider, 7);
            this.WordLengthSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.WordLengthSlider.LargeChange = 3;
            this.WordLengthSlider.Location = new System.Drawing.Point(450, 241);
            this.WordLengthSlider.Maximum = 22;
            this.WordLengthSlider.Minimum = 2;
            this.WordLengthSlider.Name = "WordLengthSlider";
            this.WordLengthSlider.Size = new System.Drawing.Size(760, 42);
            this.WordLengthSlider.TabIndex = 3;
            this.WordLengthSlider.Value = 2;
            this.WordLengthSlider.Scroll += new System.EventHandler(this.WordLengthSlider_Scroll);
            // 
            // StartButton
            // 
            this.MainPanel.SetColumnSpan(this.StartButton, 2);
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartButton.Location = new System.Drawing.Point(1025, 577);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(185, 90);
            this.StartButton.TabIndex = 4;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // CorrectLettersPanel
            // 
            this.MainPanel.SetColumnSpan(this.CorrectLettersPanel, 7);
            this.CorrectLettersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorrectLettersPanel.Location = new System.Drawing.Point(450, 505);
            this.CorrectLettersPanel.Name = "CorrectLettersPanel";
            this.CorrectLettersPanel.Size = new System.Drawing.Size(760, 66);
            this.CorrectLettersPanel.TabIndex = 9;
            // 
            // WordAssistMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "WordAssistMenuPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WordLengthSlider)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private new System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Label MainTitle;
        private ParentButton BackButton;
        private System.Windows.Forms.Label WordLengthLabel;
        private System.Windows.Forms.TrackBar WordLengthSlider;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label IncorrectLettersLabel;
        private System.Windows.Forms.CheckedListBox LettersGuessedListBox;
        private System.Windows.Forms.Label CorrectLettersLabel;
        private System.Windows.Forms.FlowLayoutPanel CorrectLettersPanel;
    }
}
