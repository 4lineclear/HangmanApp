
namespace HangmanApp.View
{
    partial class WordAssistPanel
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
            this.components = new System.ComponentModel.Container();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.NextGuessLabel = new System.Windows.Forms.Label();
            this.WordGuessesLabel = new System.Windows.Forms.Label();
            this.CorrectLettersLabel = new System.Windows.Forms.Label();
            this.IncorrectLettersListBox = new System.Windows.Forms.CheckedListBox();
            this.IncorrectLettersLabel = new System.Windows.Forms.Label();
            this.MainTitle = new System.Windows.Forms.Label();
            this.BackButton = new HangmanApp.ParentButton();
            this.CorrectLettersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WordGuessesListView = new System.Windows.Forms.ListView();
            this.GuessesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MainPanel.SuspendLayout();
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
            this.MainPanel.Controls.Add(this.NextGuessLabel, 7, 7);
            this.MainPanel.Controls.Add(this.WordGuessesLabel, 4, 7);
            this.MainPanel.Controls.Add(this.CorrectLettersLabel, 4, 3);
            this.MainPanel.Controls.Add(this.IncorrectLettersListBox, 4, 6);
            this.MainPanel.Controls.Add(this.IncorrectLettersLabel, 4, 5);
            this.MainPanel.Controls.Add(this.MainTitle, 4, 0);
            this.MainPanel.Controls.Add(this.BackButton, 0, 0);
            this.MainPanel.Controls.Add(this.CorrectLettersPanel, 4, 4);
            this.MainPanel.Controls.Add(this.WordGuessesListView, 4, 8);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 10;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.882236F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.441118F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33579F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667902F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66968F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999858F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999858F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.999858F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33579F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667902F));
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 0;
            // 
            // NextGuessLabel
            // 
            this.NextGuessLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.NextGuessLabel, 4);
            this.NextGuessLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NextGuessLabel.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NextGuessLabel.Location = new System.Drawing.Point(769, 529);
            this.NextGuessLabel.Name = "NextGuessLabel";
            this.NextGuessLabel.Size = new System.Drawing.Size(441, 42);
            this.NextGuessLabel.TabIndex = 15;
            this.NextGuessLabel.Text = "Recommended Next Guess:";
            // 
            // WordGuessesLabel
            // 
            this.WordGuessesLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.WordGuessesLabel, 3);
            this.WordGuessesLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WordGuessesLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WordGuessesLabel.Location = new System.Drawing.Point(450, 525);
            this.WordGuessesLabel.Name = "WordGuessesLabel";
            this.WordGuessesLabel.Size = new System.Drawing.Size(313, 46);
            this.WordGuessesLabel.TabIndex = 12;
            this.WordGuessesLabel.Text = "Guesses";
            // 
            // CorrectLettersLabel
            // 
            this.CorrectLettersLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.CorrectLettersLabel, 3);
            this.CorrectLettersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CorrectLettersLabel.Location = new System.Drawing.Point(450, 192);
            this.CorrectLettersLabel.Name = "CorrectLettersLabel";
            this.CorrectLettersLabel.Size = new System.Drawing.Size(313, 46);
            this.CorrectLettersLabel.TabIndex = 10;
            this.CorrectLettersLabel.Text = "Correct Letters";
            // 
            // IncorrectLettersListBox
            // 
            this.IncorrectLettersListBox.BackColor = System.Drawing.SystemColors.Control;
            this.IncorrectLettersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IncorrectLettersListBox.CheckOnClick = true;
            this.MainPanel.SetColumnSpan(this.IncorrectLettersListBox, 7);
            this.IncorrectLettersListBox.ColumnWidth = 58;
            this.IncorrectLettersListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncorrectLettersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncorrectLettersListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncorrectLettersListBox.FormattingEnabled = true;
            this.IncorrectLettersListBox.Items.AddRange(new object[] {
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
            this.IncorrectLettersListBox.Location = new System.Drawing.Point(450, 432);
            this.IncorrectLettersListBox.MultiColumn = true;
            this.IncorrectLettersListBox.Name = "IncorrectLettersListBox";
            this.IncorrectLettersListBox.Size = new System.Drawing.Size(760, 65);
            this.IncorrectLettersListBox.TabIndex = 7;
            this.IncorrectLettersListBox.SelectedIndexChanged += new System.EventHandler(this.IncorrectLettersListBox_SelectedIndexChanged);
            // 
            // IncorrectLettersLabel
            // 
            this.IncorrectLettersLabel.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.IncorrectLettersLabel, 3);
            this.IncorrectLettersLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IncorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncorrectLettersLabel.Location = new System.Drawing.Point(450, 383);
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
            // CorrectLettersPanel
            // 
            this.CorrectLettersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.SetColumnSpan(this.CorrectLettersPanel, 7);
            this.CorrectLettersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CorrectLettersPanel.Location = new System.Drawing.Point(450, 241);
            this.CorrectLettersPanel.Name = "CorrectLettersPanel";
            this.CorrectLettersPanel.Size = new System.Drawing.Size(760, 114);
            this.CorrectLettersPanel.TabIndex = 9;
            // 
            // WordGuessesListView
            // 
            this.WordGuessesListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.WordGuessesListView.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.MainPanel.SetColumnSpan(this.WordGuessesListView, 7);
            this.WordGuessesListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WordGuessesListView.HideSelection = false;
            this.WordGuessesListView.Location = new System.Drawing.Point(450, 574);
            this.WordGuessesListView.MultiSelect = false;
            this.WordGuessesListView.Name = "WordGuessesListView";
            this.WordGuessesListView.Size = new System.Drawing.Size(760, 90);
            this.WordGuessesListView.TabIndex = 14;
            this.WordGuessesListView.TileSize = new System.Drawing.Size(150, 24);
            this.GuessesToolTip.SetToolTip(this.WordGuessesListView, "Click on Guess to Open Googles Search\r\n");
            this.WordGuessesListView.UseCompatibleStateImageBehavior = false;
            this.WordGuessesListView.View = System.Windows.Forms.View.SmallIcon;
            this.WordGuessesListView.SelectedIndexChanged += new System.EventHandler(this.GuessesListView_SelectedIndexChanged);
            // 
            // WordAssistPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "WordAssistPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private new System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Label MainTitle;
        private ParentButton BackButton;
        private System.Windows.Forms.Label IncorrectLettersLabel;
        private new System.Windows.Forms.CheckedListBox IncorrectLettersListBox;
        private new System.Windows.Forms.FlowLayoutPanel CorrectLettersPanel;
        private System.Windows.Forms.Label CorrectLettersLabel;
        private System.Windows.Forms.Label WordGuessesLabel;
        private System.Windows.Forms.ListView WordGuessesListView;
        private System.Windows.Forms.ToolTip GuessesToolTip;
        private System.Windows.Forms.Label NextGuessLabel;
    }
}
