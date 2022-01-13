
namespace HangmanApp
{
    partial class GamemodeMenuPanel
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
            this.LocalNetworkButton = new System.Windows.Forms.Button();
            this.MultiplayerButton = new System.Windows.Forms.Button();
            this.MainTitle = new System.Windows.Forms.Label();
            this.SingleplayerButton = new System.Windows.Forms.Button();
            this.BackButton = new ParentButton();
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
            this.MainPanel.Controls.Add(this.LocalNetworkButton, 4, 8);
            this.MainPanel.Controls.Add(this.MultiplayerButton, 4, 6);
            this.MainPanel.Controls.Add(this.MainTitle, 4, 0);
            this.MainPanel.Controls.Add(this.SingleplayerButton, 4, 4);
            this.MainPanel.Controls.Add(this.BackButton, 0, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 11;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.881698F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.440849F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33499F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667498F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667498F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33499F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33499F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667498F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667498F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33499F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.667498F));
            this.MainPanel.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.TabIndex = 0;
            // 
            // LocalNetworkButton
            // 
            this.LocalNetworkButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.LocalNetworkButton, 7);
            this.LocalNetworkButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LocalNetworkButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalNetworkButton.Location = new System.Drawing.Point(450, 529);
            this.LocalNetworkButton.Name = "LocalNetworkButton";
            this.MainPanel.SetRowSpan(this.LocalNetworkButton, 2);
            this.LocalNetworkButton.Size = new System.Drawing.Size(760, 138);
            this.LocalNetworkButton.TabIndex = 3;
            this.LocalNetworkButton.Text = "Local Network";
            this.LocalNetworkButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LocalNetworkButton.UseVisualStyleBackColor = true;
            // 
            // MultiplayerButton
            // 
            this.MultiplayerButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MultiplayerButton, 7);
            this.MultiplayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplayerButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplayerButton.Location = new System.Drawing.Point(450, 385);
            this.MultiplayerButton.Name = "MultiplayerButton";
            this.MainPanel.SetRowSpan(this.MultiplayerButton, 2);
            this.MultiplayerButton.Size = new System.Drawing.Size(760, 138);
            this.MultiplayerButton.TabIndex = 2;
            this.MultiplayerButton.Text = "Multiplayer";
            this.MultiplayerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MultiplayerButton.UseVisualStyleBackColor = true;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.MainTitle, 7);
            this.MainTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 95F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainTitle.Location = new System.Drawing.Point(450, 63);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainPanel.SetRowSpan(this.MainTitle, 4);
            this.MainTitle.Size = new System.Drawing.Size(760, 175);
            this.MainTitle.TabIndex = 0;
            this.MainTitle.Text = "Gamemode";
            this.MainTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SingleplayerButton
            // 
            this.SingleplayerButton.AutoSize = true;
            this.MainPanel.SetColumnSpan(this.SingleplayerButton, 7);
            this.SingleplayerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SingleplayerButton.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SingleplayerButton.Location = new System.Drawing.Point(450, 241);
            this.SingleplayerButton.Name = "SingleplayerButton";
            this.MainPanel.SetRowSpan(this.SingleplayerButton, 2);
            this.SingleplayerButton.Size = new System.Drawing.Size(760, 138);
            this.SingleplayerButton.TabIndex = 1;
            this.SingleplayerButton.Text = "Singleplayer";
            this.SingleplayerButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SingleplayerButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(122, 57);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // GamemodeMenuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainPanel);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "GamemodeMenuPanel";
            this.Size = new System.Drawing.Size(1280, 720);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Button SingleplayerButton;
        private System.Windows.Forms.Button MultiplayerButton;
        private System.Windows.Forms.Button LocalNetworkButton;
        private ParentButton BackButton;
    }
}
