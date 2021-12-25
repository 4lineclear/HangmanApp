using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class MainForm : Form
    {
        char[] letters;
        Panel[] panels = new Panel[3];
        public MainForm()
        {
            InitializeComponent();
            setUpCorrectLetters();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.panels[0] = this.MainMenuPanel;
            this.panels[1] = this.GamemodePanel;
            this.panels[2] = this.WordAssistMenuPanel;
        }
        private void setUpCorrectLetters()
        {
            WAM_CorrectLetters[0] = this.WAM_CorrectLetterBox1;
            WAM_CorrectLetters[1] = this.WAM_CorrectLetterBox2;
            WAM_CorrectLetters[2] = this.WAM_CorrectLetterBox3;
            WAM_CorrectLetters[3] = this.WAM_CorrectLetterBox4;
            WAM_CorrectLetters[4] = this.WAM_CorrectLetterBox5;
            WAM_CorrectLetters[5] = this.WAM_CorrectLetterBox6;
            WAM_CorrectLetters[6] = this.WAM_CorrectLetterBox7;
            WAM_CorrectLetters[7] = this.WAM_CorrectLetterBox8;
            WAM_CorrectLetters[8] = this.WAM_CorrectLetterBox9;
            WAM_CorrectLetters[9] = this.WAM_CorrectLetterBox10;
            WAM_CorrectLetters[10] = this.WAM_CorrectLetterBox11;
            WAM_CorrectLetters[11] = this.WAM_CorrectLetterBox12;
            WAM_CorrectLetters[12] = this.WAM_CorrectLetterBox13;
            WAM_CorrectLetters[13] = this.WAM_CorrectLetterBox14;
            WAM_CorrectLetters[14] = this.WAM_CorrectLetterBox15;
            WAM_CorrectLetters[15] = this.WAM_CorrectLetterBox16;
            WAM_CorrectLetters[16] = this.WAM_CorrectLetterBox17;
            WAM_CorrectLetters[17] = this.WAM_CorrectLetterBox18;
            WAM_CorrectLetters[18] = this.WAM_CorrectLetterBox19;
            WAM_CorrectLetters[19] = this.WAM_CorrectLetterBox20;
            WAM_CorrectLetters[20] = this.WAM_CorrectLetterBox21;
            WAM_CorrectLetters[21] = this.WAM_CorrectLetterBox22;
        }
        
        #region MainMenu Panel EventHandlers
        private void MMP_PlayButton_Click(object sender, EventArgs e)
        {
            this.panels[1].BringToFront();
        }

        private void MMP_WordAssistButton_Click(object sender, EventArgs e)
        {
            this.panels[2].BringToFront();
        }

        private void MMP_HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void MMP_OptionsButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Gamemode Panel EventHandlers
        private void GP_BackButton_Click(object sender, EventArgs e)
        {
            this.panels[0].BringToFront();
        }

        private void GP_SingeplayerButton_Click(object sender, EventArgs e)
        {

        }

        private void GP_MultiplayerButton_Click(object sender, EventArgs e)
        {

        }

        private void GP_LocalNetworkButton_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region WordAssit Panel EventHandlers
        private void WAM_BackButton_Click(object sender, EventArgs e)
        {
            this.panels[0].BringToFront();
        }

        private void WAM_LetterCountSlider_Scroll(object sender, EventArgs e)
        {
            this.WAM_LetterCountSliderLabel.Text = "Word Count:"+this.WAM_LetterCountSlider.Value;
            for (int i = 0;i<WAM_LetterCountSlider.Value;i++)
            {
                this.WAM_CorrectLetters[i].Visible = true;
            }
            for (int i = WAM_LetterCountSlider.Value; i < 22; i++)
            {
                this.WAM_CorrectLetters[i].Visible = false;
            }
        }
        private void WAM_StartButton_Click(object sender, EventArgs e)
        {
            this.letters = new char[this.WAM_LetterCountSlider.Value];
            for (int i = 0; i < this.letters.Length; i++)
            {
                if (this.WAM_CorrectLetters[i].Text != "")
                {
                    this.letters[i] = this.WAM_CorrectLetters[i].Text[0];
                }
            }
        }
        #endregion

    }
}
