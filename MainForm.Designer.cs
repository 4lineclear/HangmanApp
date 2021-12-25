
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
            this.WAM_CorrectLetterBox22 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox21 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox20 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox19 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox18 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox17 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox16 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox15 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox14 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox13 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox12 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox11 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox10 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox9 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox8 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox7 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox6 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox5 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox4 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox3 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox2 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLetterBox1 = new System.Windows.Forms.TextBox();
            this.WAM_CorrectLettersLabel = new System.Windows.Forms.Label();
            this.WAM_StartButton = new System.Windows.Forms.Button();
            this.WAM_IncorrectLettersLabel = new System.Windows.Forms.Label();
            this.WAM_Letters_Guessed = new System.Windows.Forms.CheckedListBox();
            this.WAM_LetterCountSliderLabel = new System.Windows.Forms.Label();
            this.WAM_LetterCountSlider = new System.Windows.Forms.TrackBar();
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
            ((System.ComponentModel.ISupportInitialize)(this.WAM_LetterCountSlider)).BeginInit();
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
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox22);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox21);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox20);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox19);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox18);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox17);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox16);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox15);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox14);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox13);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox12);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox11);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox10);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox9);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox8);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox7);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox6);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox5);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox4);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox3);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox2);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLetterBox1);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_CorrectLettersLabel);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_StartButton);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_IncorrectLettersLabel);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_Letters_Guessed);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_LetterCountSliderLabel);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_LetterCountSlider);
            this.WordAssistMenuPanel.Controls.Add(this.WordAssistMenuTitle);
            this.WordAssistMenuPanel.Controls.Add(this.WAM_BackButton);
            this.WordAssistMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.WordAssistMenuPanel.Name = "WordAssistMenuPanel";
            this.WordAssistMenuPanel.Size = new System.Drawing.Size(1264, 681);
            this.WordAssistMenuPanel.TabIndex = 5;
            // 
            // WAM_CorrectLetterBox22
            // 
            this.WAM_CorrectLetterBox22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox22.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox22.Location = new System.Drawing.Point(993, 394);
            this.WAM_CorrectLetterBox22.MaxLength = 1;
            this.WAM_CorrectLetterBox22.Name = "WAM_CorrectLetterBox22";
            this.WAM_CorrectLetterBox22.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox22.TabIndex = 31;
            this.WAM_CorrectLetterBox22.Visible = false;
            // 
            // WAM_CorrectLetterBox21
            // 
            this.WAM_CorrectLetterBox21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox21.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox21.Location = new System.Drawing.Point(963, 394);
            this.WAM_CorrectLetterBox21.MaxLength = 1;
            this.WAM_CorrectLetterBox21.Name = "WAM_CorrectLetterBox21";
            this.WAM_CorrectLetterBox21.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox21.TabIndex = 30;
            this.WAM_CorrectLetterBox21.Visible = false;
            // 
            // WAM_CorrectLetterBox20
            // 
            this.WAM_CorrectLetterBox20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox20.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox20.Location = new System.Drawing.Point(933, 394);
            this.WAM_CorrectLetterBox20.MaxLength = 1;
            this.WAM_CorrectLetterBox20.Name = "WAM_CorrectLetterBox20";
            this.WAM_CorrectLetterBox20.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox20.TabIndex = 29;
            this.WAM_CorrectLetterBox20.Visible = false;
            // 
            // WAM_CorrectLetterBox19
            // 
            this.WAM_CorrectLetterBox19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox19.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox19.Location = new System.Drawing.Point(903, 394);
            this.WAM_CorrectLetterBox19.MaxLength = 1;
            this.WAM_CorrectLetterBox19.Name = "WAM_CorrectLetterBox19";
            this.WAM_CorrectLetterBox19.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox19.TabIndex = 28;
            this.WAM_CorrectLetterBox19.Visible = false;
            // 
            // WAM_CorrectLetterBox18
            // 
            this.WAM_CorrectLetterBox18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox18.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox18.Location = new System.Drawing.Point(873, 394);
            this.WAM_CorrectLetterBox18.MaxLength = 1;
            this.WAM_CorrectLetterBox18.Name = "WAM_CorrectLetterBox18";
            this.WAM_CorrectLetterBox18.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox18.TabIndex = 27;
            this.WAM_CorrectLetterBox18.Visible = false;
            // 
            // WAM_CorrectLetterBox17
            // 
            this.WAM_CorrectLetterBox17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox17.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox17.Location = new System.Drawing.Point(843, 394);
            this.WAM_CorrectLetterBox17.MaxLength = 1;
            this.WAM_CorrectLetterBox17.Name = "WAM_CorrectLetterBox17";
            this.WAM_CorrectLetterBox17.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox17.TabIndex = 26;
            this.WAM_CorrectLetterBox17.Visible = false;
            // 
            // WAM_CorrectLetterBox16
            // 
            this.WAM_CorrectLetterBox16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox16.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox16.Location = new System.Drawing.Point(813, 394);
            this.WAM_CorrectLetterBox16.MaxLength = 1;
            this.WAM_CorrectLetterBox16.Name = "WAM_CorrectLetterBox16";
            this.WAM_CorrectLetterBox16.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox16.TabIndex = 25;
            this.WAM_CorrectLetterBox16.Visible = false;
            // 
            // WAM_CorrectLetterBox15
            // 
            this.WAM_CorrectLetterBox15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox15.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox15.Location = new System.Drawing.Point(783, 394);
            this.WAM_CorrectLetterBox15.MaxLength = 1;
            this.WAM_CorrectLetterBox15.Name = "WAM_CorrectLetterBox15";
            this.WAM_CorrectLetterBox15.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox15.TabIndex = 24;
            this.WAM_CorrectLetterBox15.Visible = false;
            // 
            // WAM_CorrectLetterBox14
            // 
            this.WAM_CorrectLetterBox14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox14.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox14.Location = new System.Drawing.Point(753, 394);
            this.WAM_CorrectLetterBox14.MaxLength = 1;
            this.WAM_CorrectLetterBox14.Name = "WAM_CorrectLetterBox14";
            this.WAM_CorrectLetterBox14.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox14.TabIndex = 23;
            this.WAM_CorrectLetterBox14.Visible = false;
            // 
            // WAM_CorrectLetterBox13
            // 
            this.WAM_CorrectLetterBox13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox13.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox13.Location = new System.Drawing.Point(723, 394);
            this.WAM_CorrectLetterBox13.MaxLength = 1;
            this.WAM_CorrectLetterBox13.Name = "WAM_CorrectLetterBox13";
            this.WAM_CorrectLetterBox13.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox13.TabIndex = 22;
            this.WAM_CorrectLetterBox13.Visible = false;
            // 
            // WAM_CorrectLetterBox12
            // 
            this.WAM_CorrectLetterBox12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox12.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox12.Location = new System.Drawing.Point(693, 394);
            this.WAM_CorrectLetterBox12.MaxLength = 1;
            this.WAM_CorrectLetterBox12.Name = "WAM_CorrectLetterBox12";
            this.WAM_CorrectLetterBox12.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox12.TabIndex = 21;
            this.WAM_CorrectLetterBox12.Visible = false;
            // 
            // WAM_CorrectLetterBox11
            // 
            this.WAM_CorrectLetterBox11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox11.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox11.Location = new System.Drawing.Point(663, 394);
            this.WAM_CorrectLetterBox11.MaxLength = 1;
            this.WAM_CorrectLetterBox11.Name = "WAM_CorrectLetterBox11";
            this.WAM_CorrectLetterBox11.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox11.TabIndex = 20;
            this.WAM_CorrectLetterBox11.Visible = false;
            // 
            // WAM_CorrectLetterBox10
            // 
            this.WAM_CorrectLetterBox10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox10.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox10.Location = new System.Drawing.Point(633, 394);
            this.WAM_CorrectLetterBox10.MaxLength = 1;
            this.WAM_CorrectLetterBox10.Name = "WAM_CorrectLetterBox10";
            this.WAM_CorrectLetterBox10.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox10.TabIndex = 19;
            this.WAM_CorrectLetterBox10.Visible = false;
            // 
            // WAM_CorrectLetterBox9
            // 
            this.WAM_CorrectLetterBox9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox9.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox9.Location = new System.Drawing.Point(603, 394);
            this.WAM_CorrectLetterBox9.MaxLength = 1;
            this.WAM_CorrectLetterBox9.Name = "WAM_CorrectLetterBox9";
            this.WAM_CorrectLetterBox9.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox9.TabIndex = 18;
            this.WAM_CorrectLetterBox9.Visible = false;
            // 
            // WAM_CorrectLetterBox8
            // 
            this.WAM_CorrectLetterBox8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox8.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox8.Location = new System.Drawing.Point(573, 394);
            this.WAM_CorrectLetterBox8.MaxLength = 1;
            this.WAM_CorrectLetterBox8.Name = "WAM_CorrectLetterBox8";
            this.WAM_CorrectLetterBox8.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox8.TabIndex = 17;
            this.WAM_CorrectLetterBox8.Visible = false;
            // 
            // WAM_CorrectLetterBox7
            // 
            this.WAM_CorrectLetterBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox7.Location = new System.Drawing.Point(543, 394);
            this.WAM_CorrectLetterBox7.MaxLength = 1;
            this.WAM_CorrectLetterBox7.Name = "WAM_CorrectLetterBox7";
            this.WAM_CorrectLetterBox7.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox7.TabIndex = 16;
            this.WAM_CorrectLetterBox7.Visible = false;
            // 
            // WAM_CorrectLetterBox6
            // 
            this.WAM_CorrectLetterBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox6.Location = new System.Drawing.Point(513, 394);
            this.WAM_CorrectLetterBox6.MaxLength = 1;
            this.WAM_CorrectLetterBox6.Name = "WAM_CorrectLetterBox6";
            this.WAM_CorrectLetterBox6.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox6.TabIndex = 15;
            this.WAM_CorrectLetterBox6.Visible = false;
            // 
            // WAM_CorrectLetterBox5
            // 
            this.WAM_CorrectLetterBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox5.Location = new System.Drawing.Point(483, 394);
            this.WAM_CorrectLetterBox5.MaxLength = 1;
            this.WAM_CorrectLetterBox5.Name = "WAM_CorrectLetterBox5";
            this.WAM_CorrectLetterBox5.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox5.TabIndex = 14;
            this.WAM_CorrectLetterBox5.Visible = false;
            // 
            // WAM_CorrectLetterBox4
            // 
            this.WAM_CorrectLetterBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox4.Location = new System.Drawing.Point(453, 394);
            this.WAM_CorrectLetterBox4.MaxLength = 1;
            this.WAM_CorrectLetterBox4.Name = "WAM_CorrectLetterBox4";
            this.WAM_CorrectLetterBox4.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox4.TabIndex = 13;
            this.WAM_CorrectLetterBox4.Visible = false;
            // 
            // WAM_CorrectLetterBox3
            // 
            this.WAM_CorrectLetterBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox3.Location = new System.Drawing.Point(423, 394);
            this.WAM_CorrectLetterBox3.MaxLength = 1;
            this.WAM_CorrectLetterBox3.Name = "WAM_CorrectLetterBox3";
            this.WAM_CorrectLetterBox3.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox3.TabIndex = 12;
            this.WAM_CorrectLetterBox3.Visible = false;
            // 
            // WAM_CorrectLetterBox2
            // 
            this.WAM_CorrectLetterBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox2.Location = new System.Drawing.Point(393, 394);
            this.WAM_CorrectLetterBox2.MaxLength = 1;
            this.WAM_CorrectLetterBox2.Name = "WAM_CorrectLetterBox2";
            this.WAM_CorrectLetterBox2.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox2.TabIndex = 11;
            // 
            // WAM_CorrectLetterBox1
            // 
            this.WAM_CorrectLetterBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLetterBox1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLetterBox1.Location = new System.Drawing.Point(363, 394);
            this.WAM_CorrectLetterBox1.MaxLength = 1;
            this.WAM_CorrectLetterBox1.Name = "WAM_CorrectLetterBox1";
            this.WAM_CorrectLetterBox1.Size = new System.Drawing.Size(28, 36);
            this.WAM_CorrectLetterBox1.TabIndex = 10;
            // 
            // WAM_CorrectLettersLabel
            // 
            this.WAM_CorrectLettersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_CorrectLettersLabel.AutoSize = true;
            this.WAM_CorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_CorrectLettersLabel.Location = new System.Drawing.Point(363, 346);
            this.WAM_CorrectLettersLabel.Name = "WAM_CorrectLettersLabel";
            this.WAM_CorrectLettersLabel.Size = new System.Drawing.Size(229, 45);
            this.WAM_CorrectLettersLabel.TabIndex = 9;
            this.WAM_CorrectLettersLabel.Text = "Correct Letters";
            // 
            // WAM_StartButton
            // 
            this.WAM_StartButton.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_StartButton.Location = new System.Drawing.Point(1025, 529);
            this.WAM_StartButton.Name = "WAM_StartButton";
            this.WAM_StartButton.Size = new System.Drawing.Size(190, 113);
            this.WAM_StartButton.TabIndex = 8;
            this.WAM_StartButton.Text = "Start";
            this.WAM_StartButton.UseVisualStyleBackColor = true;
            this.WAM_StartButton.Click += new System.EventHandler(this.WAM_StartButton_Click);
            // 
            // WAM_IncorrectLettersLabel
            // 
            this.WAM_IncorrectLettersLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_IncorrectLettersLabel.AutoSize = true;
            this.WAM_IncorrectLettersLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_IncorrectLettersLabel.Location = new System.Drawing.Point(363, 243);
            this.WAM_IncorrectLettersLabel.Name = "WAM_IncorrectLettersLabel";
            this.WAM_IncorrectLettersLabel.Size = new System.Drawing.Size(251, 45);
            this.WAM_IncorrectLettersLabel.TabIndex = 7;
            this.WAM_IncorrectLettersLabel.Text = "Incorrect Letters";
            // 
            // WAM_Letters_Guessed
            // 
            this.WAM_Letters_Guessed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_Letters_Guessed.BackColor = System.Drawing.SystemColors.Control;
            this.WAM_Letters_Guessed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WAM_Letters_Guessed.CheckOnClick = true;
            this.WAM_Letters_Guessed.ColumnWidth = 68;
            this.WAM_Letters_Guessed.Cursor = System.Windows.Forms.Cursors.Default;
            this.WAM_Letters_Guessed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.WAM_Letters_Guessed.Location = new System.Drawing.Point(363, 291);
            this.WAM_Letters_Guessed.MultiColumn = true;
            this.WAM_Letters_Guessed.Name = "WAM_Letters_Guessed";
            this.WAM_Letters_Guessed.Size = new System.Drawing.Size(894, 48);
            this.WAM_Letters_Guessed.TabIndex = 6;
            // 
            // WAM_LetterCountSliderLabel
            // 
            this.WAM_LetterCountSliderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_LetterCountSliderLabel.AutoSize = true;
            this.WAM_LetterCountSliderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAM_LetterCountSliderLabel.Location = new System.Drawing.Point(363, 142);
            this.WAM_LetterCountSliderLabel.Name = "WAM_LetterCountSliderLabel";
            this.WAM_LetterCountSliderLabel.Size = new System.Drawing.Size(221, 45);
            this.WAM_LetterCountSliderLabel.TabIndex = 4;
            this.WAM_LetterCountSliderLabel.Text = "Letter Count:2";
            // 
            // WAM_LetterCountSlider
            // 
            this.WAM_LetterCountSlider.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WAM_LetterCountSlider.LargeChange = 1;
            this.WAM_LetterCountSlider.Location = new System.Drawing.Point(363, 195);
            this.WAM_LetterCountSlider.Maximum = 22;
            this.WAM_LetterCountSlider.Minimum = 2;
            this.WAM_LetterCountSlider.Name = "WAM_LetterCountSlider";
            this.WAM_LetterCountSlider.Size = new System.Drawing.Size(852, 45);
            this.WAM_LetterCountSlider.TabIndex = 3;
            this.WAM_LetterCountSlider.Value = 2;
            this.WAM_LetterCountSlider.Scroll += new System.EventHandler(this.WAM_LetterCountSlider_Scroll);
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
            ((System.ComponentModel.ISupportInitialize)(this.WAM_LetterCountSlider)).EndInit();
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
        private System.Windows.Forms.TrackBar WAM_LetterCountSlider;
        private System.Windows.Forms.Label WAM_LetterCountSliderLabel;
        private System.Windows.Forms.Label WAM_IncorrectLettersLabel;
        private System.Windows.Forms.CheckedListBox WAM_Letters_Guessed;
        private System.Windows.Forms.Button WAM_StartButton;
        private System.Windows.Forms.Label WAM_CorrectLettersLabel;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox22;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox21;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox20;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox19;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox18;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox17;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox16;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox15;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox14;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox13;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox12;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox11;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox10;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox9;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox8;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox7;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox6;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox5;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox4;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox3;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox2;
        private System.Windows.Forms.TextBox WAM_CorrectLetterBox1;
        System.Windows.Forms.TextBox[] WAM_CorrectLetters = new System.Windows.Forms.TextBox[22];
    }
}

