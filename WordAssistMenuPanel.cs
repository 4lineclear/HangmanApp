using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HangmanApp
{
    public partial class WordAssistMenuPanel : TreeControl
    {
        private static int PreviousCorrectTextBoxCount = 2;
        public WordAssistMenuPanel()
        {
            InitializeComponent();
            this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox(1));
            this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox(2));
        }

        private void WordLengthSlider_Scroll(object sender, EventArgs e)
        {
            this.WordLengthLabel.Text = $"Word Length: {WordLengthSlider.Value}";
            int difference = Math.Abs(WordLengthSlider.Value - PreviousCorrectTextBoxCount);

            for (int i = 0; i < difference; i++)
            {
                if (WordLengthSlider.Value > PreviousCorrectTextBoxCount)
                {
                    this.CorrectLettersPanel.Controls.Add(CreateNextCorrectTextBox(WordLengthSlider.Value));
                }
                else
                {
                    this.CorrectLettersPanel.Controls.RemoveAt(CorrectLettersPanel.Controls.Count - 1);
                }
            }
            PreviousCorrectTextBoxCount = CorrectLettersPanel.Controls.Count;
        }
        private TextBox CreateNextCorrectTextBox(int count)
        {
            TextBox temp = new TextBox();
            temp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            temp.Location = new System.Drawing.Point(3, 3);
            temp.MaxLength = 1;
            temp.Name = $"CorrectTextBox{count}";
            temp.Size = new System.Drawing.Size(26, 36);
            temp.TabIndex = count;
            return temp;
        }
    }
}
