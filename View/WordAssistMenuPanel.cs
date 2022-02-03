using HangmanApp.Presenter;
using HangmanApp.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class WordAssistMenuPanel : WordAssistBase
    {
        private static int PreviousCorrectTextBoxCount = 2;
        public WordAssistMenuPanel()
        {
            InitializeComponent();
            base.MainPanel = this.MainPanel;
            base.CorrectLettersPanel = this.CorrectLettersPanel;
            base.IncorrectLettersListBox = this.IncorrectLettersListBox;
            this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox());
            this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox());
        }
        private void WordLengthSlider_Scroll(object sender, EventArgs e)
        {
            this.WordLengthLabel.Text = $"Word Length: {WordLengthSlider.Value}";
            int difference = Math.Abs(WordLengthSlider.Value - PreviousCorrectTextBoxCount);
            for (int i = 0; i < difference; i++)
            {
                if (WordLengthSlider.Value > PreviousCorrectTextBoxCount)
                {
                    this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox());
                }
                else
                {
                    this.CorrectLettersPanel.Controls.RemoveAt(CorrectLettersPanel.Controls.Count - 1);
                }
            }
            PreviousCorrectTextBoxCount = CorrectLettersPanel.Controls.Count;
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            Presenter.StartAssist(this.CorrectLetters, this.IncorrectLetters);
        }

        
    }
}
